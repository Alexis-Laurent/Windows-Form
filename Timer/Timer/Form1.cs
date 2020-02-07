using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //bouton start
        private void button1_Click(object sender, EventArgs e)
        {
            //progressBar1.Value = 100;
            timer1.Start();
        }
        

        //bouton reset
        private void button2_Click(object sender, EventArgs e)
        {
            //progressBar1.Value = 0;
            progressBar1.Value = 0;
            timer1.Stop();

            //texte
            labelNombre.Text = "0";
        }

        
        //timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 1;                

                //label Nombre
                labelNombre.Text = (Int32.Parse(labelNombre.Text) + 1).ToString();
                Font font = new Font("Arial", float.Parse(labelNombre.Text));
                labelNombre.Font = font;

                //direction de la barre
                //progressBar1.Location = new Point(43, 100);
            }
        }

        


        private void labelNombre_Click(object sender, EventArgs e) {}
        private void Form1_Load(object sender, EventArgs e) {}
    }
}
