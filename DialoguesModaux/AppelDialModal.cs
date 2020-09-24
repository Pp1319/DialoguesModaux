using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialoguesModaux
{
    public partial class AppelDialogueModal : Form
    {
        public AppelDialogueModal()
        {
            InitializeComponent();
        }

        private void ConnexionDial(object sender, EventArgs e)
        {
            DialModal dialogue = new DialModal();
            DialogResult res = dialogue.ShowDialog();
        }
    }
}
