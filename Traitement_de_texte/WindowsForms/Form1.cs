using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form1 : Form
    {

        int cptDocOpen = 1;  //compteur
        string[] listeAccesFichiers = new string [100];  //tableau de 100 éléments

        public Form1()  //constructeur
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {   
            //label du bas   
            StatutLabel.Text = "Nombre de documents : " + cptDocOpen;
        }


        //créer un nouveau document
        private void nouveauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cptDocOpen++; //incrément
            StatutLabel.Text = "Nombre de documents : " + cptDocOpen;

            TabPage tabPage2 = new TabPage();  //nouvelle page
            tabPage2.Text = "Onglet" + cptDocOpen; ;
            menuOnglet.Controls.Add(tabPage2);

            RichTextBox richTextBox2 = new RichTextBox();  //zone de texte
            richTextBox2.Text = "" + cptDocOpen;
            richTextBox2.Dock = DockStyle.Fill;  //Fill (affichage tout écran)

            tabPage2.Controls.Add(richTextBox2);
        }
                
        
        //enregistrer fichier
        private void enregistrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string chemin = Directory.GetCurrentDirectory(); 
            File.WriteAllText(chemin + "/" + tabPage1.Text, richTextBox1.Text); 
        }
              
                
        //bonton quitter
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        //ouvrir document
        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();  //ouvrir une fenetre de dialogue
        }
        

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            StatutLabel.Text = openFileDialog1.FileName; //récupère le nom du fichier
            bool existeFichier = false;
            int i = 0;

            if(listeAccesFichiers != null && listeAccesFichiers[0] != null)
            {
                for (i = 0; i < listeAccesFichiers.Count() - 1; i++)
                {
                    if (listeAccesFichiers[i]==openFileDialog1.FileName)
                    {
                        existeFichier = true;
                        break;
                    }
                }
                if (existeFichier == true)
                {
                    menuOnglet.SelectedTab = menuOnglet.TabPages[i + 1];
                    //StatutInformation.Text = "Tab Page trouvé";
                }
                else
                {
                    listeAccesFichiers[listeAccesFichiers.Count() - 1] = openFileDialog1.FileName;
                    //ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
                    //toolStripMenuItem.Text = openFileDialog1.FileName;
                    //listeToolStripMenuItem.DropDownItems.Add(toolStripMenuItem);
                }
            }  
            else
            {
                listeAccesFichiers[0] = openFileDialog1.FileName;
                //ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
                //toolStripMenuItem.Text = openFileDialog1.FileName;
                //listeToolStripMenuItem.DropDownItems.Add(toolStripMenuItem);
            }
                        

            StatutLabel.Text = openFileDialog1.FileName; //récupère le nom du fichier
            
            if(listeAccesFichiers ==null)
            {
                listeAccesFichiers[0] = openFileDialog1.FileName;
            }

            if (existeFichier == false)
            {
                string[] nomFichier = openFileDialog1.FileName.Split('\\'); //découpe le chemin du document
                StatutLabel.Text = nomFichier[nomFichier.Count() - 1]; //récupere le nom du fichier


                cptDocOpen++; //incrément
                StatutLabel.Text = "Nombre de documents : " + cptDocOpen; //label statut


                TabPage tabPage2 = new TabPage(); //nouvelle page
                tabPage2.Text = nomFichier[nomFichier.Count() - 1]; //nom fichier
                menuOnglet.Controls.Add(tabPage2); //ajoute un onglet


                RichTextBox richTextBox2 = new RichTextBox();
                StreamReader texteReader = new StreamReader(openFileDialog1.FileName);  //lecture du fichier
                string blocTexte = "";

                while ((blocTexte = texteReader.ReadLine()) != null)
                {
                    richTextBox2.Text += blocTexte;
                }

                richTextBox2.Dock = DockStyle.Fill;
                tabPage2.Controls.Add(richTextBox2);

                menuOnglet.SelectedTab = menuOnglet.TabPages[menuOnglet.TabCount - 1];  //menu onglet
            }                
        }




        private void toolStripStatusLabel1_Click(object sender, EventArgs e) { }
        private void richTextBox1_TextChanged(object sender, EventArgs e) { }
        private void tabPage1_Click(object sender, EventArgs e) { }
    }
}
