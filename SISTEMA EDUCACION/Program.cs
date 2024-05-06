namespace SISTEMA_EDUCACION
{
    internal static class Program{
        [STAThread]
        static void Main(){
            ApplicationConfiguration.Initialize();
            Application.Run(new FORMULARIOS.ESCUELA.FrmPrincipalEscuela());
        }
    }
}