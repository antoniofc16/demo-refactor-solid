using RefactorSolidConsole.Interfaces;
using RefactorSolidConsole.Services;

IReportService reportService = new ReporteService();
IEmailService emailService = new EmailService();
IDataService dataService = new DataService();
IFileService fileService = new FileService();


Console.WriteLine("Demostracion de refactorizacion: Single Responsibility Principle");
Console.WriteLine("==============================================================================================");
Console.WriteLine(string.Empty);

dataService.ConsultarDatos();
Console.WriteLine(string.Empty);
reportService.GenerarReporte("Reporte de Ventas.txt");
Console.WriteLine(string.Empty);
fileService.GuardarArchivo("ReporteVentas.txt", "Contenido del reporte de ventas");
Console.WriteLine(string.Empty);
emailService.EnviarCorreo("jlopez@nttdata.com", "Reporte de Ventas", "Por favor, encuentre el reporte adjunto.");