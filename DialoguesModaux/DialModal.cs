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
            errorProviderID.SetError(textID, string.Empty);
            if ((textID.Text == string.Empty) || (textID.Text.Length < 5))
            {
                errorProviderID.SetError(textID, "Doit contenir 1 lettre en premier et au moins 5 caractères");
                e.Cancel = true;
               
               
                
            }
            else if (!char.IsLetter(textID.Text[0]))
            {
                errorProviderID.SetError(textID, "Le premier caractère doit être une lettre");
                e.Cancel = true;

            }
            else
            {
                for (int i = 1; i < textID.Text.Length; i++)
                {
                    if (!char.IsDigit(textID.Text[i]) && !char.IsLetter(textID.Text[i]))
                    {
                        errorProviderID.SetError(textID, "Les caractères doivent être une lettre ou un chiffre");
                        e.Cancel = true;
                    }
                }
            }












        }



        private void EventValidatingMDP(object sender, CancelEventArgs e)
        {
            errorProviderMDP.SetError(textMDP, string.Empty);
            if (textMDP.Text == string.Empty || textMDP.Text.Length < 5)
            {
                errorProviderMDP.SetError(textMDP, "Le mot de passe doit être identique à celui de l'identifiant");
                e.Cancel = true;
                


            }

        }


        private void EventClickConnect(object sender, EventArgs e)
        {
            
            if (textMDP.Text != textID.Text)
            {
                errorProviderMDP.SetError(textMDP, "Le mot de passe doit être identique à celui de l'identifiant");
                this.DialogResult = DialogResult.None;
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }


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
