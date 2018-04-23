using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;

namespace ReadOnlyApp {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            XPBaseObject.AutoSaveOnEndEdit = false;
            string conn = MSSqlConnectionProvider.GetConnectionString("(local)", "AdventureWorks");
            ReadOnlyDataStore readOnlyStore = new ReadOnlyDataStore(XpoDefault.GetConnectionProvider(conn, AutoCreateOption.SchemaAlreadyExists));
            XpoDefault.DataLayer = new SimpleDataLayer(readOnlyStore);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}