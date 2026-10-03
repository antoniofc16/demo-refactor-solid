using System;
using System.Collections.Generic;
using System.Text;

namespace RefactorSolidConsole.Interfaces
{
    public interface IFileService
    {
        void GuardarArchivo(string nombreArchivo, string contenido);
    }
}
