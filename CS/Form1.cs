using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Base;

namespace ReadOnlyApp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e) {
            // process template views
            foreach(ColumnView view in gridControl1.ViewCollection)
                view.OptionsBehavior.Editable = false;

            // process visible clone views
            foreach(ColumnView view in gridControl1.Views)
                view.OptionsBehavior.Editable = false;
        }
    }
}