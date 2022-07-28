using Entra21.Gerenciador.Hospital.Vet.Views.Veterinarios;

namespace Entra21.Gerenciador.Hospital.Vet
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new VeterinarioListagemForm());
        }
    }
}