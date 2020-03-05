using PatronDecorador.Decorador;
using PatronDecorador.DTO;
using PatronDecorador.Interfaces;
using System;

namespace PatronDecorador
{
    class Principal
    {
        static void Main(string[] args)
        {
            CxPDTO cxpDTO = new CxPDTO();
            IProcesadorGuardadoCxP procesadorGuardado = new ProcesaGuardado();
            procesadorGuardado.GuardarCxP(cxpDTO);
            Console.WriteLine("--------------------------------\n");

            IProcesadorGuardadoCxP procesadorGuardadoHistorial = new ProcesaGuardadoHistorial(procesadorGuardado);
            procesadorGuardadoHistorial.GuardarCxP(cxpDTO);
           
            Console.WriteLine("--------------------------------\n");
            IProcesadorGuardadoCxP procesadorGuardadoEnvioCorreo = new ProcesaEnvioCorreo(procesadorGuardado);
            procesadorGuardadoEnvioCorreo.GuardarCxP(cxpDTO);
            Console.WriteLine("--------------------------------\n");


            IProcesadorGuardadoCxP procesadorCompleto = new ProcesaGuardado();
            procesadorCompleto = new ProcesaGuardadoHistorial(procesadorCompleto);
            procesadorCompleto = new ProcesaEnvioCorreo(procesadorCompleto);
            procesadorCompleto.GuardarCxP(cxpDTO);
            Console.WriteLine("--------------------------------\n");
        }
    }
}
