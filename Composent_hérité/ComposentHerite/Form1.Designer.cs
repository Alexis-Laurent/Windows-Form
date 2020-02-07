namespace ComposentHerite
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.numeriqueTextBox1 = new HeritageControle.NumeriqueTextBox();
            this.SuspendLayout();
            // 
            // numeriqueTextBox1
            // 
            this.numeriqueTextBox1.ForeColor = System.Drawing.Color.Blue;
            this.numeriqueTextBox1.Location = new System.Drawing.Point(12, 162);
            this.numeriqueTextBox1.Name = "numeriqueTextBox1";
            this.numeriqueTextBox1.Size = new System.Drawing.Size(592, 20);
            this.numeriqueTextBox1.TabIndex = 0;
            this.numeriqueTextBox1.Text = "0";
            this.numeriqueTextBox1.Value = 0D;
            this.numeriqueTextBox1.TextChanged += new System.EventHandler(this.numeriqueTextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numeriqueTextBox1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HeritageControle.NumeriqueTextBox numeriqueTextBox1;
    }
}

