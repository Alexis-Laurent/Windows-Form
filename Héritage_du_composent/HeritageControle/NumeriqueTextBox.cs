using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeritageControle
{
    public partial class NumeriqueTextBox: TextBox
    {
        public NumeriqueTextBox()
        {
            InitializeComponent();
            this.TextChanged += new EventHandler(NumeriqueTextBox_TextChanged);
        }

        [Description("Valeur du controle")]
        public double Value
        {
            set
            {
                Text = value.ToString();
            }
            get
            {
                try
                {
                    return double.Parse(Text);
                }
                catch { }
                return 0;
            }
        }

        void NumeriqueTextBox_TextChanged(object sender, EventArgs e)
        {
            //remplace le . en ,
            if (this.Text.Contains(".")){
                this.Text = this.Text.Replace(".", ",");
                this.Select(Text.Length, 0);
            }

            
            try
            {
                if (Text == "-")
                {
                    this.ForeColor = Color.Red;
                }

                else if (double.Parse(Text) < 0)
                {
                    this.ForeColor = Color.Red;
                }

                else
                {
                    this.ForeColor = Color.Blue;
                }

            }
            catch (Exception)
            {
                Value = 0;
                this.SelectAll();
            }

        }

    }

}
