using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialoguesModaux
{
    public partial class DialModal : Form
    {
        public DialModal()
        {
            InitializeComponent();
        }
        

        private void EventValidatingID(object sender, CancelEventArgs e)
        {
          
            char[] Arr = textID.Text.ToCharArray();
            foreach (char item in Arr)
            {
                if ((textID.Text == string.Empty) || (textID.Text.Length < 5) || (!char.IsDigit(item)) || (!char.IsLetter(item)))
                {
                    e.Cancel = true;


                }
                else
                {
                    e.Cancel = false;
                }

            }






        }



        private void EventValidatingMDP(object sender, CancelEventArgs e)
        {
            if (textMDP.Text == string.Empty)
            {
                e.Cancel = true;
            }
        }

       

        private void EventClickConnect(object sender, EventArgs e)
        {
            
        }

        private void EventClickQuit(object sender, EventArgs e)
        {

        }

        private void EventClickTest(object sender, EventArgs e)
        {
            Debug.WriteLine($"Test de validating", textID.Text.ToCharArray());
        }

        
    }
}
