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

namespace Password_formulaire
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (TextBoxEmail.Text=="admin@gmail.com" && TextBoxPassword.Text=="admin")
            {
                //ouvrir le fichier
                Process.Start(@"E:\cours Afpa2\C#\BddClient\BddClient\bin\Debug\BddClient.exe");
                this.Hide();
            }

            else
            {
                if (TextBoxEmail.Text == "")
                {
                    LabelMessage.Text = "Veuillez inscrire un Email";
                }
                else if(TextBoxPassword.Text == "")
                {
                    LabelMessage.Text = "Veuillez inscrire un Mot de passe";
                }
                else 
                {
                    LabelMessage.Text = "Email ou Mot de passe invalide";
                }

            }

        }




        private void label3_Click(object sender, EventArgs e) {}
        private void textBoxEmail_TextChanged(object sender, EventArgs e) {}
        private void textBoxPassword_TextChanged(object sender, EventArgs e) {}
        private void label1_Click(object sender, EventArgs e) {}
    }
}
