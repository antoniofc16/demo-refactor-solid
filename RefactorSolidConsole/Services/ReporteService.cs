using System;
using System.Collections.Generic;
using System.Text;
using RefactorSolidConsole.Interfaces;

namespace RefactorSolidConsole.Services
{
    public class ReporteService : IReportService
    {
        public void GenerarReporte(string nombreReporte)
        {
            Console.WriteLine($"Generando reporte '{nombreReporte}'...");
        }
    }
}
