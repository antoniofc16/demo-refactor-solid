using System;
using System.Collections.Generic;
using System.Text;

namespace RefactorSolidConsole.Interfaces
{
    public interface IEmailService
    {
        void EnviarCorreo(string destinatario, string asunto, string cuerpo);
    }
}
