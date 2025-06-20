﻿// --- Archivo: doctor_agenda.aspx.cs ---
using SoftBO;
using SoftBO.loginWS;
using SoftBO.medicoWS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;
using usuarioDTO = SoftBO.loginWS.usuarioDTO;

namespace SoftWA
{

    public class CitaConPaciente
    {
        public citaDTO Cita { get; set; }
        public usuarioDTO Paciente { get; set; }

        public string fechaCita { get; set; }
        public turnoDTO turno { get; set; }
        public especialidadDTO especialidad { get; set; }
        public int IdCita { get; set; }
    }

    public partial class doctor_agenda : System.Web.UI.Page
    {
        private readonly MedicoBO _medicoBO;
        private readonly HistoriaClinicaPorCitaBO _historiaClinicaPorCitaBO;
        public doctor_agenda()
        {
            _medicoBO = new MedicoBO();
            _historiaClinicaPorCitaBO = new HistoriaClinicaPorCitaBO();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int idDoctorLogueado = ObtenerIdDoctorLogueado();
                if (idDoctorLogueado == 0)
                {
                    Response.Redirect("~/indexLogin.aspx");
                    return;
                }
                CargarAgenda(idDoctorLogueado);
            }
        }

        private int ObtenerIdDoctorLogueado()
        {
            var usuario = Session["UsuarioCompleto"] as usuarioDTO;
            return usuario?.idUsuario ?? 0;
        }

        private void CargarAgenda(int idDoctor)
        {
            List<citaDTO> agendaCompleta;
            try
            {
                agendaCompleta = _medicoBO.ListarCitasProgramadasMedico(idDoctor).ToList();
            }
            catch (Exception ex)
            {
                // Manejar error de conexión
                phNoAgenda.Visible = true;
                (phNoAgenda.Controls[0] as Literal).Text = "<div class='alert alert-danger'>Error al conectar con el servidor para obtener la agenda.</div>";
                pnlProximaCita.Visible = false;
                pnlSiguientesCitas.Visible = false;
                hrSeparadorCitas.Visible = false;
                System.Diagnostics.Debug.WriteLine($"Error en ListarCitasProgramadasMedico: {ex.Message}");
                return;
            }

            // Filtrar citas pendientes (no atendidas, no canceladas, etc.)
            // Asumimos que el estado "RESERVADO" (código 0) es el que debe atenderse.
            var citasPendientes = agendaCompleta
                .Where(c => c.estado == estadoCita.DISPONIBLE)  // cambiarrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrr cuabndo haya datos
                .OrderBy(c => DateTime.Parse(c.fechaCita))
                .ThenBy(c => c.turno.horaInicio)
                .ToList();

            if (citasPendientes.Any())
            {
                phNoAgenda.Visible = false;

                // Configurar la próxima cita
                var proximaCita = citasPendientes.First();
                pnlProximaCita.Visible = true;

                var historiaClinicaPorCita = _historiaClinicaPorCitaBO.ObtenerHistoriaClinicaPorIdCita(proximaCita.idCita);
                var historiaClinica = historiaClinicaPorCita.historiaClinica;
                var paciente = historiaClinica.paciente;

                ltlProximaPacienteNombre.Text = Server.HtmlEncode($"{paciente.nombres} {paciente.apellidoPaterno}");
                ltlProximaFecha.Text = DateTime.Parse(proximaCita.fechaCita).ToString("dddd, dd 'de' MMMM 'de' yyyy");
                ltlProximaHorario.Text = Server.HtmlEncode(proximaCita.turno.horaInicio.ToString("HH:mm") + " - " + proximaCita.turno.horaFin.ToString("HH:mm"));
                ltlProximaEspecialidad.Text = Server.HtmlEncode(proximaCita.especialidad.nombreEspecialidad);
                btnAtenderProximaCita.CommandArgument = proximaCita.idCita.ToString();

                // Configurar las siguientes citas
                var siguientesCitas = citasPendientes.Skip(1)
                .Select(cita =>
                {
                    var historiaClinicaPorCita1 = _historiaClinicaPorCitaBO.ObtenerHistoriaClinicaPorIdCita(cita.idCita);
                    var paciente1 = historiaClinicaPorCita?.historiaClinica?.paciente;
                    var pacienteMapped = new usuarioDTO
                    {
                        idUsuario = paciente1?.idUsuario ?? 0,
                        nombres = paciente1?.nombres,
                        apellidoPaterno = paciente1?.apellidoPaterno,
                        apellidoMaterno = paciente1?.apellidoMaterno,
                        correoElectronico = paciente1?.correoElectronico,
                        numDocumento = paciente1?.numDocumento,
                        // Map other properties as needed
                    };
                    return new CitaConPaciente
                    {
                        Cita = cita,
                        Paciente = pacienteMapped,
                        fechaCita= cita.fechaCita,
                        turno= cita.turno,
                        especialidad=cita.especialidad,
                        IdCita= cita.idCita
                    };
                })
                .ToList();

                if (siguientesCitas.Any())
                {
                    pnlSiguientesCitas.Visible = true;
                    hrSeparadorCitas.Visible = true;
                    rptSiguientesCitas.DataSource = siguientesCitas;
                    rptSiguientesCitas.DataBind();
                }
                else
                {
                    pnlSiguientesCitas.Visible = false;
                    hrSeparadorCitas.Visible = false;
                }

            }
            else
            {
                phNoAgenda.Visible = true;
                pnlProximaCita.Visible = false;
                pnlSiguientesCitas.Visible = false;
                hrSeparadorCitas.Visible = false;
            }
            updAgendaPrincipal.Update();
        }

        private void RedirigirARegistroAtencion(int idCita)
        {
            string url = $"doctor_registrar_atencion.aspx?idCita={idCita}";
            // Script para abrir en una nueva pestaña y luego refrescar la página actual
            string script = $"window.open('{url}', '_blank');";
            ScriptManager.RegisterStartupScript(this, GetType(), "OpenAtencionWindow", script, true);
            // Opcional: podrías agregar un temporizador para refrescar la agenda después de un tiempo,
            // pero es mejor que el médico la refresque manualmente para no interrumpir su flujo.
        }

        protected void btnAtenderProximaCita_Click(object sender, EventArgs e)
        {
            var btn = (LinkButton)sender;
            if (int.TryParse(btn.CommandArgument, out int idCita))
            {
                RedirigirARegistroAtencion(idCita);
            }
        }

        protected void rptSiguientesCitas_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "AtenderCita")
            {
                if (int.TryParse(e.CommandArgument.ToString(), out int idCita))
                {
                    RedirigirARegistroAtencion(idCita);
                }
            }
        }
    }
}