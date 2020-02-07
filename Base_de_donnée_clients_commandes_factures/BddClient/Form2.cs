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
    public partial class Form2 : Form
    {

        SqlConnection cnx = new SqlConnection(@"Data Source = DESKTOP-8JQ5N7I\SQLEXPRESS; Initial Catalog = vpc; Integrated Security = True");


        public Form2()
        {
            InitializeComponent();
        }


        //redirection des clients
        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }


        //ajouter un client
        private void button_ajouter_client_Click(object sender, EventArgs e)
        {
          
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'vPCDataSet.Client'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.clientTableAdapter.Fill(this.vPCDataSet.Client);

        }

        private void dataGridView_supprimer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            //barre de statut
            //StatutLabel.Text = "référence du client : " + dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();

            int IdClient = Int32.Parse(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());

            try
            {
                cnx.Open();
                SqlCommand cmd20 = new SqlCommand("delete IdCclient from dbo.Client", cnx);
                cmd20.CommandType = CommandType.Text;
                cmd20.Parameters.AddWithValue("@IdClient", IdClient);

                //creation databable
                DataTable dt20 = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd20);
                adapter.Fill(dt20);

                //affichage
                dataGridView_supprimer.DataSource = dt20;
                cnx.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
        }
    }
}
