using PatronDecorador.DTO;
using PatronDecorador.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatronDecorador.Decorador
{
    class ProcesaGuardadoHistorial : IDecoradorCxP
    {
        private readonly IProcesadorGuardadoCxP procesadorGuardadoCxP;

        public ProcesaGuardadoHistorial(IProcesadorGuardadoCxP procesadorGuardadoCxP)
        {
            this.procesadorGuardadoCxP = procesadorGuardadoCxP;
        }

        public void GuardarCxP(CxPDTO CxP)
        {
            procesadorGuardadoCxP.GuardarCxP(CxP);
            Console.WriteLine("Guardando Historal");
        }
    }
}
