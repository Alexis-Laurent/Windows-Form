using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BddClient
{
    public partial class Form1 : Form
    {
        //SqlConnection cnx = new SqlConnection(@"Data Source = STA6101380\SQLEXPRESS; Initial Catalog = vpc; Integrated Security = True");
        SqlConnection cnx = new SqlConnection(@"Data Source = DESKTOP-8JQ5N7I\SQLEXPRESS; Initial Catalog = vpc; Integrated Security = True");
        

        public Form1()
        {
            InitializeComponent();
            InitialiserClient();
        }


        //affichage liste des clients au démarrage
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                cnx.Open();
                SqlCommand cmd1 = new SqlCommand("select * from dbo.Client", cnx);
                cmd1.CommandType = CommandType.Text;

                //création databable
                DataTable dt1 = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd1);
                adapter.Fill(dt1);

                //affichage
                dataGridView1.DataSource = dt1;
                cnx.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
        }


        //tous les clients
        private void tousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {   
                cnx.Open();
                SqlCommand cmd1 = new SqlCommand("select * from dbo.Client", cnx);
                cmd1.CommandType = CommandType.Text;

                //création databable
                DataTable dt1 = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd1);
                adapter.Fill(dt1);

                //affichage
                dataGridView1.DataSource = dt1;
                cnx.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
        }
                       

        //coordonnées
        private void coordonneesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                cnx.Open();
                SqlCommand cmd2 = new SqlCommand("select * from dbo.Adresse", cnx);
                cmd2.CommandType = CommandType.Text;

                //création databable
                DataTable dt2 = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd2);
                adapter.Fill(dt2);

                dataGridView2.DataSource = dt2;
                cnx.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
        }


        //commandes
        private void commandesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                cnx.Open();
                SqlCommand cmd3 = new SqlCommand("select * from dbo.Commande", cnx);
                cmd3.CommandType = CommandType.Text;

                //création databable
                DataTable dt3 = new DataTable(); 
                SqlDataAdapter adapter = new SqlDataAdapter(cmd3);
                adapter.Fill(dt3);

                dataGridView3.DataSource = dt3;
                cnx.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
        }


        //factures
        private void facturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                cnx.Open();
                SqlCommand cmd4 = new SqlCommand("select * from dbo.Facture", cnx);
                cmd4.CommandType = CommandType.Text;

                //création databable
                DataTable dt4 = new DataTable(); 
                SqlDataAdapter adapter = new SqlDataAdapter(cmd4);
                adapter.Fill(dt4);

                dataGridView4.DataSource = dt4;
                cnx.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
        }
        
        
        //barre de recherche
        private void textBox_rechercheclient_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cnx.Open();
                SqlCommand cmd5 = new SqlCommand("select * from dbo.Client where IdClient=@IdClient", cnx);
                cmd5.CommandType = CommandType.Text;
                cmd5.Parameters.AddWithValue("@IdClient", textBox_rechercheclient.Text);

                //création databable
                DataTable dt5 = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd5);
                adapter.Fill(dt5);

                dataGridView1.DataSource = dt5;
                cnx.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
        }


        //datarow liste des clients dans le menu
        private void InitialiserClient()
        {
            try
            {
                cnx.Open();
                SqlCommand cmd6 = new SqlCommand("select IdClient,NomClient,PrenomClient from dbo.Client", cnx);
                cmd6.CommandType = CommandType.Text;

                //création databable
                DataTable dt6 = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd6);
                adapter.Fill(dt6);

                //affichage
                DataRow[] listeClients = dt6.Select();
                foreach (DataRow item in listeClients)
                {
                    ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
                    toolStripMenuItem.Text = item[1] + " " + item[2];
                    toolStripMenuItem.Tag = item[0] + ToString();
                    toolStripMenuItem.Click += new EventHandler(toolStripMenuItem_Click); //événement click
                    clientsToolStripMenuItem.DropDownItems.Add(toolStripMenuItem);
                }
                cnx.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
        }


        //événement click
        private void toolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)sender;
            //StatutLabel.Text = "référence du client : " + toolStripMenuItem.Tag.ToString();            
        }


        //selection d'un client dans dataGridView1
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            //barre de statut
           StatutLabel.Text = "référence du client : " + dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();

            int IdClient = Int32.Parse(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            
            try
            {
                cnx.Open();
                SqlCommand cmd8 = new SqlCommand("select * from dbo.Adresse where IdClient=@IdClient", cnx);
                cmd8.CommandType = CommandType.Text;
                cmd8.Parameters.AddWithValue("@IdClient", IdClient);

                //création databable
                DataTable dt8 = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd8);
                adapter.Fill(dt8);

                //affichage
                dataGridView2.DataSource = dt8;
                cnx.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }

            try
            {
                cnx.Open();
                SqlCommand cmd9 = new SqlCommand("select * from dbo.Commande where IdClient=@IdClient", cnx);
                cmd9.CommandType = CommandType.Text;
                cmd9.Parameters.AddWithValue("@IdClient", IdClient);

                //création databable
                DataTable dt9 = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd9);
                adapter.Fill(dt9);

                //affichage
                dataGridView3.DataSource = dt9;
                cnx.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }

            try
            {
                cnx.Open();
                SqlCommand cmd10 = new SqlCommand("select * from dbo.Facture where IdClient=@IdClient", cnx);
                cmd10.CommandType = CommandType.Text;
                cmd10.Parameters.AddWithValue("@IdClient", IdClient);

                //création databable
                DataTable dt10 = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd10);
                adapter.Fill(dt10);

                //affichage
                dataGridView4.DataSource = dt10;
                cnx.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }


            //affiche les informations du client dans le formulaire
            textBox_nom.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox_prenom.Text = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            dateTimePicker1.Text = DateTime.Parse(dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString()).ToString();
            textBox_telephone.Text = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox_email.Text = dataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBox_password.Text = dataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
                  
        }


        //redirection au formulaire ajouter un client
        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }




        private void DataGridView_click(object sender, EventArgs e) {}
        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {}
        private void toolStripTextBox1_Click(object sender, EventArgs e) {}        
    }
}
