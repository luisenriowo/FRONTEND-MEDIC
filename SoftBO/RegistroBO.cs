﻿using SoftBO.registroWS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftBO
{
    public class RegistroBO
    {
        private RegistroWSClient registroCliente;
        public RegistroBO()
        {
            this.registroCliente = new RegistroWSClient();
        }
        public bool Registrarse(usuarioDTO usuario)
        {
            return this.registroCliente.registrarse(usuario);
        }
    }
}
