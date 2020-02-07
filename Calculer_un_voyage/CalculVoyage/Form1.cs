using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculVoyage
{
    public partial class Form1 : Form
    {

        public double Consomation = 0;
        public double Kilometre = 0;
        public double PrixLitre = 0;


        public Form1()
        {
            InitializeComponent();
        }

               
        //option textbox1
        private void textBox1_TextChanged(object sender, EventArgs e)
        {            
            textBox_Consomation.ForeColor = Color.Black;

            //enlever le "-"
            if (textBox_Consomation.Text == "-")
            {
                textBox_Consomation.Text = "";
            } 

            if (TestChampNombre(textBox_Consomation.Text) == false)
            {
                textBox_Consomation.ForeColor = Color.Red;
            }
        }

        //option textbox2
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox_Kilometre.ForeColor = Color.Black;

            if (textBox_Kilometre.Text == "-")
            {
                textBox_Kilometre.Text = "";
            }

            if (TestChampNombre(textBox_Kilometre.Text) == false)
            {
                textBox_Kilometre.ForeColor = Color.Red;
            }
        }

        //option textbox3
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox_prixLitre.ForeColor = Color.Black;

            if (textBox_prixLitre.Text == "-")
            {
                textBox_prixLitre.Text = "";
            }

            if (TestChampNombre(textBox_prixLitre.Text) == false)
            {
                textBox_prixLitre.ForeColor = Color.Red;
            }
        }


        //bouton valider
        private void Valider_Click(object sender, EventArgs e)
        {
            LB_Resultat.Text = "";
            LB_Resultat.ForeColor = Color.Black; 

            if (textBox_Consomation.Text == "")
            {
                LB_Resultat.Text = "Définissez la consomation";
                LB_Resultat.ForeColor = Color.Red; 
            }
            else if (textBox_Kilometre.Text == "")
            {
                LB_Resultat.Text = "Définissez le nombre de kilomètre";
                LB_Resultat.ForeColor = Color.Red; 
            }
            else if (textBox_prixLitre.Text == "")
            {
                LB_Resultat.Text = "Définissez le prix du litre";
                LB_Resultat.ForeColor = Color.Red; 
            }

            //si pas de nombres
            else if (TestChampNombre(textBox_Consomation.Text) == false || TestChampNombre(textBox_Kilometre.Text) == false || TestChampNombre(textBox_prixLitre.Text) == false)
            {
                LB_Resultat.Text = "Veillez indiquer un nombre";
                LB_Resultat.ForeColor = Color.Red;
            }

            else
            {   //calcul
                Consomation = Double.Parse(textBox_Consomation.Text.Replace(".", ","));
                Kilometre = Double.Parse(textBox_Kilometre.Text.Replace(".", ","));
                PrixLitre = Double.Parse(textBox_prixLitre.Text.Replace(".", ","));

                double Resultat = Consomation * (Kilometre / 100) * PrixLitre;

                if(Resultat.ToString().Contains(",")) //récupere 2 chiffres apres la virgule
                {
                    string[] result = Resultat.ToString().Split(','); 
                    LB_Resultat.Text = "Votre trajet coûtera : " + result[0] + "," + result[1].Substring(0, 2);
                }
                else
                {
                    LB_Resultat.Text += "votre consomation en litre sera de : " + Resultat.ToString();
                }
                double litreConso = Kilometre / 100 * Consomation; //conso par litre                    
                LB_Resultat.Text += "\r\nvotre consomation en litre sera de : " + litreConso;
            }
        }



        private bool TestChampNombre(string texte)
        {
            double nbre = 15.45;

            if (Double.TryParse(texte.Replace(".", ","), out nbre) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }




        private void LB_Resultat_Click(object sender, EventArgs e) {}
        private void Form1_Load(object sender, EventArgs e) {}
        private void label3_Click(object sender, EventArgs e) {}
    }
}
