using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LectureEcritureFichier
{
    public partial class Form1 : Form
    {

        public String Line;
        public string Fichier = "Lecture_Ecriture.txt";
        public string chemin = Directory.GetCurrentDirectory() + "/Lecture_Ecriture.txt";


        public Form1()
        {
            InitializeComponent();
        }


        //lire le fichier
        private void Lire_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader(chemin); 
                Line = sr.ReadLine();

                while (Line != null)
                {
                    richTextBox1.Text = Line;
                    Line = sr.ReadLine();
                }

                sr.Close();
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
            
        }
        
               
        //vider la lecture
        private void Vider_lecture_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }


        //retour à la ligne
        private void Retour_ligne_Click(object sender, EventArgs e)
        {
            richTextBox2.Text += "\r\n";
        }


        //retour initial du curseur
        private void Retour_initial_Click(object sender, EventArgs e)
        {
            this.richTextBox2.Focus();
            this.richTextBox2.SelectionStart = 0;
            this.richTextBox2.SelectionLength = 0;
        }


        //vider l'écriture
        private void Vider_ecriture_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear();
        }


        //enregistrer le fichier
        private void Ecrire_fichier_Click(object sender, EventArgs e)
        {
            File.WriteAllText(chemin, richTextBox2.Text);          
        }


        //vider le fichier
        private void Vider_fichier_Click(object sender, EventArgs e)
        {
            File.WriteAllText(chemin, "");
        }


        //supprimer le fichier
        private void Supprimer_fichier_Click(object sender, EventArgs e)
        {
            File.Delete(chemin);
        }


        //déplacer
        private void Deplacer_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = folderBrowserDialog1.ShowDialog();

            if (dialogResult == DialogResult.OK && folderBrowserDialog1.SelectedPath != "")
            {
                File.Move(chemin, folderBrowserDialog1.SelectedPath + "/" + Fichier);
            }
        }


        //ouvrir avec Word
        private void Word_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", chemin);
        }

               
        

        private void label2_Click(object sender, EventArgs e) {}    
    }
}
