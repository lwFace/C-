using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WinDriverDemo
{
    static class Program
    {
        public static MainFrm _mainFrm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            _mainFrm = new MainFrm();
            //注册皮肤
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.UserSkins.OfficeSkins.Register();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("zh-CN");
            Application.Run(_mainFrm);
        }
    }
}
