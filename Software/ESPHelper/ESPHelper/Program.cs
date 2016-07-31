using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;

namespace ESPHelper
{
    static class Program
    {
        public static MainFrm mainFrm = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            DevExpress.Data.CurrencyDataController.DisableThreadingProblemsDetection = true;
            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            mainFrm = new MainFrm();
            Application.Run(mainFrm);
        }
    }
}
