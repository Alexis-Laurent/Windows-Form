using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioBoutonPlay
{
    public partial class Form1 : Form
    {

        //initialisation
        List<RadioButton> liste_radio = new List<RadioButton>();
        int Bouton_On = 0;


        public Form1()
        {
            InitializeComponent();
        }

        
        //play
        private void Play_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 1000;
        }


        //stop
        private void Reset_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Interval = 1000;
        }


        //TrackBar
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 501 - trackBar1.Value * 40;
        }


        //timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Bouton_On
            if (Bouton_On < 12)
            {
                liste_radio[Bouton_On].Checked = true;
                Bouton_On += 1;
            }
            //boucle
            if(Bouton_On == 12)
            {
                Bouton_On = 0;
            }

        }


        //form
        private void Form1_Load(object sender, EventArgs e)
        {
            //création des boutons
            for (int i = 0; i < 12; i++)
            {
                liste_radio.Add(new RadioButton());                
            }

            int pointx = 20;
            int pointy = 30;

            foreach (RadioButton item in liste_radio)
            {
                item.Location = new Point(pointx, pointy);
                item.Width = 20;
                pointx += 40;
                this.Controls.Add(item);
            }
            
        }
    }
    
}
