using PatronDecorador.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatronDecorador.Interfaces
{
    interface IDecoradorCxP : IProcesadorGuardadoCxP
    {
        abstract void GuardarCxP(CxPDTO CxP);

    }
}
