

using ComClassSys;

namespace ComercialSys
{
    internal static class Program
    {

        

        /// <summary>
        ///  Propriedade criada para armazenar os dados de usuário logado no sistema
        /// </summary>
        /// 
        public static Usuario Usuario { get; set; } 

        [STAThread]
        static void Main()
        {
            Usuario = new();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new FrmPrincipal());
            Application.Run(new FrmPrincipal());
        }
    }
}