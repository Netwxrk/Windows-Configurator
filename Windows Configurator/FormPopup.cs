using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Configurator {
    public partial class FormPopup : Form {
        public FormPopup() {
            InitializeComponent();
        }

        public void setPopupText(string text)
        {
            rtbPopup.Text = string.Empty;
            rtbPopup.Text = text;
        }

    }
}
