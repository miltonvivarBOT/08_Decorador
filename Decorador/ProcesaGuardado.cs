using PatronDecorador.DTO;
using PatronDecorador.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatronDecorador.Decorador
{
    class ProcesaGuardado : IProcesadorGuardadoCxP
    {
        public void GuardarCxP(CxPDTO CxP)
        {
            Console.WriteLine("Guardando CxP");
        }
    }
}
