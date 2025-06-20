﻿using SoftBO.usuarioWS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftBO
{
    public class UsuarioBO
    {
        private UsuarioWSClient usuarioCliente;
        public UsuarioBO()
        {
            this.usuarioCliente = new UsuarioWSClient();
        }
        public usuarioDTO ObtenerPorIdUsuario(int id)
        {
            return this.usuarioCliente.obtenerPorIdUsuario(id);
        }
        public usuarioDTO BuscarCuentaUsuario(string documento, string tipoDoc, string contrasenha)
        {
            return this.usuarioCliente.buscarCuentaUsuario(documento, tipoDoc, contrasenha);
        }
        public int InsertarUsuario(usuarioDTO usuario)
        {
            return this.usuarioCliente.insertarUsuario(usuario);
        }
        public int ModificarUsuario(usuarioDTO usuario)
        {
            return this.usuarioCliente.modificarUsuario(usuario);
        }
        public int CambiarEstadoGeneralUsuario(usuarioDTO usuario, int estadoGeneral)
        {
            return this.usuarioCliente.cambiarEstadoGeneralUsuario(usuario, estadoGeneral);
        }
        public int CambiarEstadoLogicoUsuario(usuarioDTO usuario, int estadoLogico)
        {
            return this.usuarioCliente.cambiarEstadoLogicoUsuario(usuario, estadoLogico);
        }
        public usuarioDTO CompletarRolesUsuario(usuarioDTO usuario)
        {
            return this.usuarioCliente.completarRolesUsuario(usuario);
        }
    }
}
