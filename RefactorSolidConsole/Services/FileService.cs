using System;
using System.Collections.Generic;
using System.Text;
using RefactorSolidConsole.Interfaces;

namespace RefactorSolidConsole.Services
{
    public class FileService : IFileService
    {
        public void GuardarArchivo(string nombreArchivo, string contenido)
        {
            Console.WriteLine($"Guardando archivo '{nombreArchivo}' con contenido: {contenido}");
        }
    }
}
