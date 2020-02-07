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

namespace Treeview
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

            //options de la listview
            listView1.View = View.Details;
            listView1.CheckBoxes = true;
            listView1.LabelEdit = true;
            listView1.AllowColumnReorder = true;
            listView1.FullRowSelect = true;
            addListItems();
            //treeView1.ImageList = imageList1; //image
        }


        //colomnes
        private void addListItems()
        {            
            listView1.Columns.Add("Nom du fichier", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Créé le", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Modifié le", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Lecteur", -2, HorizontalAlignment.Left);
        }
        

        //topNode
        private void Form1_Load(object sender, EventArgs e)
        {           
            string[] repertoire = Directory.GetDirectories(@"E:\cours Afpa2\C# WindowsForm"); //repertoire            
            treeView1.TopNode = treeView1.Nodes.Add(@"E:\cours Afpa2\C# WindowsForm"); //topNode racine choisit
            
            
            foreach (var item in repertoire)
            {   
                //afficher noeud
                TreeNode PremierNoeud = treeView1.TopNode.Nodes.Add(item);
                afficherSousDossier(item, PremierNoeud);
                afficherFichier(item, PremierNoeud);
                //PremierNoeud.ImageIndex = 0; //image

                //afficher colomne
                ListViewItem listViewItem = new ListViewItem(item);
                listViewItem.SubItems.Add(Directory.GetCreationTimeUtc(item).ToLongDateString()); //date création
                listViewItem.SubItems.Add(Directory.GetLastWriteTimeUtc(item).ToLongDateString()); // date modification
                listViewItem.SubItems.Add(Directory.GetDirectoryRoot(item)); //chemin du fichier
                listView1.Items.Add(listViewItem);

                //redimentionner colomne
                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }


        //afficher sous-dossier
        private void afficherSousDossier(string item,TreeNode PremierNoeud)
        {
            try
            {
                string[] sousrepertoire = Directory.GetDirectories(item);

                foreach (string items in sousrepertoire)
                {
                    TreeNode NewNoeud = PremierNoeud.Nodes.Add(items);
                    afficherSousDossier(items, NewNoeud);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }

        }
    

        //afficher fichier
        private void afficherFichier(string item, TreeNode PremierNoeud)
        {
            try
            {
                string[] fichier = Directory.GetFiles(item);

                foreach (string items in fichier)
                {
                    TreeNode NewNoeud = PremierNoeud.Nodes.Add(items);
                    afficherFichier(items, NewNoeud);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }

        }




        private void listView1_SelectedIndexChanged(object sender, EventArgs e) {}
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e) {}       
    }
}
