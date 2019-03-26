using System;
using System.Windows.Forms;
using Unit4HomeOffice.Entities;
using Unit4HomeOffice.Services;

namespace Unit4HomeOffice
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AppSetting setting = new AppSetting();
            MouseClicker mover = new MouseClicker();
            CaseUpdater updater = new CaseUpdater();
            DriverCreator creator = new DriverCreator();          
            Context context = new Context();
            AutoDispatcher dispatcher = new AutoDispatcher(context);
            Application.Run(new Main(setting, mover, updater, creator, dispatcher, context));


            
            
        }


    }
}
