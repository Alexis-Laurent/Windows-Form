namespace CalculVoyage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Consomation = new System.Windows.Forms.TextBox();
            this.textBox_Kilometre = new System.Windows.Forms.TextBox();
            this.textBox_prixLitre = new System.Windows.Forms.TextBox();
            this.Calculer = new System.Windows.Forms.Button();
            this.LB_Resultat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(115, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculer un voyage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(85, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Consomation (L/100Km)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(85, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre de kilomètres";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(85, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prix de l\'essence (€/L)";
            // 
            // textBox_Consomation
            // 
            this.textBox_Consomation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBox_Consomation.Location = new System.Drawing.Point(296, 106);
            this.textBox_Consomation.Name = "textBox_Consomation";
            this.textBox_Consomation.Size = new System.Drawing.Size(100, 20);
            this.textBox_Consomation.TabIndex = 4;
            this.textBox_Consomation.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox_Kilometre
            // 
            this.textBox_Kilometre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBox_Kilometre.Location = new System.Drawing.Point(296, 161);
            this.textBox_Kilometre.Name = "textBox_Kilometre";
            this.textBox_Kilometre.Size = new System.Drawing.Size(100, 20);
            this.textBox_Kilometre.TabIndex = 5;
            this.textBox_Kilometre.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox_prixLitre
            // 
            this.textBox_prixLitre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBox_prixLitre.Location = new System.Drawing.Point(296, 227);
            this.textBox_prixLitre.Name = "textBox_prixLitre";
            this.textBox_prixLitre.Size = new System.Drawing.Size(100, 20);
            this.textBox_prixLitre.TabIndex = 6;
            this.textBox_prixLitre.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Calculer
            // 
            this.Calculer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Calculer.Location = new System.Drawing.Point(286, 299);
            this.Calculer.Name = "Calculer";
            this.Calculer.Size = new System.Drawing.Size(120, 30);
            this.Calculer.TabIndex = 7;
            this.Calculer.Text = "Calculer";
            this.Calculer.UseVisualStyleBackColor = false;
            this.Calculer.Click += new System.EventHandler(this.Valider_Click);
            // 
            // LB_Resultat
            // 
            this.LB_Resultat.AutoSize = true;
            this.LB_Resultat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.LB_Resultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Resultat.Location = new System.Drawing.Point(41, 299);
            this.LB_Resultat.Name = "LB_Resultat";
            this.LB_Resultat.Size = new System.Drawing.Size(0, 15);
            this.LB_Resultat.TabIndex = 8;
            this.LB_Resultat.Click += new System.EventHandler(this.LB_Resultat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = global::CalculVoyage.Properties.Resources.wallpaper;
            this.ClientSize = new System.Drawing.Size(502, 379);
            this.Controls.Add(this.LB_Resultat);
            this.Controls.Add(this.Calculer);
            this.Controls.Add(this.textBox_prixLitre);
            this.Controls.Add(this.textBox_Kilometre);
            this.Controls.Add(this.textBox_Consomation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.MenuText;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Consomation;
        private System.Windows.Forms.TextBox textBox_Kilometre;
        private System.Windows.Forms.TextBox textBox_prixLitre;
        private System.Windows.Forms.Button Calculer;
        private System.Windows.Forms.Label LB_Resultat;
    }
}

