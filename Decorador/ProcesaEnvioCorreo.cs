using PatronDecorador.DTO;
using PatronDecorador.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatronDecorador.Decorador
{
    class ProcesaEnvioCorreo : IDecoradorCxP
    {
        private readonly IProcesadorGuardadoCxP procesadorGuardadoCxP;

        public ProcesaEnvioCorreo(IProcesadorGuardadoCxP procesadorGuardadoCxP)
        {
            this.procesadorGuardadoCxP = procesadorGuardadoCxP;
        }

        public void GuardarCxP(CxPDTO CxP)
        {
            procesadorGuardadoCxP.GuardarCxP(CxP);
            Console.WriteLine("Enviando Correo");
        }
    }
}
