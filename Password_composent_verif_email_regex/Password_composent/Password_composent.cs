using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Password_composent
{
    public partial class Password_composent: TextBox
    {

        public Password_composent()
        {
            InitializeComponent();
            this.TextChanged += new EventHandler(Password_composent_verification);
        }


        //composent du formulaire - vérification de l'adresse email avec regex
        private bool IsValid()
        {
            try
            {
                string emailAdresse = this.Text;

                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(emailAdresse);

                if (match.Success)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            catch (Exception)
            {
                return false;
            }
        }


        private void Password_composent_verification(object sender, EventArgs e)
        {
            if (IsValid() == true)
            {
                this.ForeColor = Color.Black;
            }
            else
            {
                this.ForeColor = Color.Red;
            }
        }
    }

}
