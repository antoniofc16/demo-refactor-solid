using System;
using System.Collections.Generic;
using System.Text;
using RefactorSolidConsole.Interfaces;

namespace RefactorSolidConsole.Services
{
    public class EmailService : IEmailService
    {
        public void EnviarCorreo(string destinatario, string asunto, string cuerpo)
        {
            Console.WriteLine($"Enviando correo a {destinatario} con asunto '{asunto}' y cuerpo '{cuerpo}'");
        }
    }
}
