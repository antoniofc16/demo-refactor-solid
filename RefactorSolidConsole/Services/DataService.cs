using System;
using System.Collections.Generic;
using System.Text;
using RefactorSolidConsole.Interfaces;

namespace RefactorSolidConsole.Services
{
    public class DataService : IDataService
    {
        public void ConsultarDatos()
        {
            Console.WriteLine("Consultando datos...");
        }
    }
}
