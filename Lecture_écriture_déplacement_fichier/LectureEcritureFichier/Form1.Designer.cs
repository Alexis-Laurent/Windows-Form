namespace LectureEcritureFichier
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Lire = new System.Windows.Forms.Button();
            this.Vider_lecture = new System.Windows.Forms.Button();
            this.Ecrire_fichier = new System.Windows.Forms.Button();
            this.Vider_ecriture = new System.Windows.Forms.Button();
            this.Word = new System.Windows.Forms.Button();
            this.Vider_fichier = new System.Windows.Forms.Button();
            this.Deplacer = new System.Windows.Forms.Button();
            this.Supprimer_fichier = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.Retour_ligne = new System.Windows.Forms.Button();
            this.Retour_initial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lecture";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.richTextBox1.Location = new System.Drawing.Point(31, 45);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(359, 73);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.richTextBox2.Location = new System.Drawing.Point(31, 216);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(359, 69);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ecriture";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Lire
            // 
            this.Lire.Location = new System.Drawing.Point(31, 144);
            this.Lire.Name = "Lire";
            this.Lire.Size = new System.Drawing.Size(100, 23);
            this.Lire.TabIndex = 4;
            this.Lire.Text = "Lire le fichier";
            this.Lire.UseVisualStyleBackColor = true;
            this.Lire.Click += new System.EventHandler(this.Lire_Click);
            // 
            // Vider_lecture
            // 
            this.Vider_lecture.Location = new System.Drawing.Point(290, 144);
            this.Vider_lecture.Name = "Vider_lecture";
            this.Vider_lecture.Size = new System.Drawing.Size(100, 23);
            this.Vider_lecture.TabIndex = 5;
            this.Vider_lecture.Text = "Vider la lecture";
            this.Vider_lecture.UseVisualStyleBackColor = true;
            this.Vider_lecture.Click += new System.EventHandler(this.Vider_lecture_Click);
            // 
            // Ecrire_fichier
            // 
            this.Ecrire_fichier.Location = new System.Drawing.Point(31, 354);
            this.Ecrire_fichier.Name = "Ecrire_fichier";
            this.Ecrire_fichier.Size = new System.Drawing.Size(100, 23);
            this.Ecrire_fichier.TabIndex = 6;
            this.Ecrire_fichier.Text = "Enregistrer fichier";
            this.Ecrire_fichier.UseVisualStyleBackColor = true;
            this.Ecrire_fichier.Click += new System.EventHandler(this.Ecrire_fichier_Click);
            // 
            // Vider_ecriture
            // 
            this.Vider_ecriture.Location = new System.Drawing.Point(290, 311);
            this.Vider_ecriture.Name = "Vider_ecriture";
            this.Vider_ecriture.Size = new System.Drawing.Size(100, 23);
            this.Vider_ecriture.TabIndex = 7;
            this.Vider_ecriture.Text = "Vider l\'écriture";
            this.Vider_ecriture.UseVisualStyleBackColor = true;
            this.Vider_ecriture.Click += new System.EventHandler(this.Vider_ecriture_Click);
            // 
            // Word
            // 
            this.Word.Location = new System.Drawing.Point(290, 398);
            this.Word.Name = "Word";
            this.Word.Size = new System.Drawing.Size(100, 23);
            this.Word.TabIndex = 8;
            this.Word.Text = "Ouvrir avec Word";
            this.Word.UseVisualStyleBackColor = true;
            this.Word.Click += new System.EventHandler(this.Word_Click);
            // 
            // Vider_fichier
            // 
            this.Vider_fichier.Location = new System.Drawing.Point(289, 354);
            this.Vider_fichier.Name = "Vider_fichier";
            this.Vider_fichier.Size = new System.Drawing.Size(101, 23);
            this.Vider_fichier.TabIndex = 9;
            this.Vider_fichier.Text = "Vider fichier";
            this.Vider_fichier.UseVisualStyleBackColor = true;
            this.Vider_fichier.Click += new System.EventHandler(this.Vider_fichier_Click);
            // 
            // Deplacer
            // 
            this.Deplacer.Location = new System.Drawing.Point(160, 398);
            this.Deplacer.Name = "Deplacer";
            this.Deplacer.Size = new System.Drawing.Size(100, 23);
            this.Deplacer.TabIndex = 10;
            this.Deplacer.Text = "Déplacer";
            this.Deplacer.UseVisualStyleBackColor = true;
            this.Deplacer.Click += new System.EventHandler(this.Deplacer_Click);
            // 
            // Supprimer_fichier
            // 
            this.Supprimer_fichier.Location = new System.Drawing.Point(30, 398);
            this.Supprimer_fichier.Name = "Supprimer_fichier";
            this.Supprimer_fichier.Size = new System.Drawing.Size(101, 23);
            this.Supprimer_fichier.TabIndex = 13;
            this.Supprimer_fichier.Text = "Supprimer fichier";
            this.Supprimer_fichier.UseVisualStyleBackColor = true;
            this.Supprimer_fichier.Click += new System.EventHandler(this.Supprimer_fichier_Click);
            // 
            // Retour_ligne
            // 
            this.Retour_ligne.Location = new System.Drawing.Point(31, 311);
            this.Retour_ligne.Name = "Retour_ligne";
            this.Retour_ligne.Size = new System.Drawing.Size(100, 23);
            this.Retour_ligne.TabIndex = 14;
            this.Retour_ligne.Text = "Retour à la ligne";
            this.Retour_ligne.UseVisualStyleBackColor = true;
            this.Retour_ligne.Click += new System.EventHandler(this.Retour_ligne_Click);
            // 
            // Retour_initial
            // 
            this.Retour_initial.Location = new System.Drawing.Point(147, 311);
            this.Retour_initial.Name = "Retour_initial";
            this.Retour_initial.Size = new System.Drawing.Size(126, 23);
            this.Retour_initial.TabIndex = 15;
            this.Retour_initial.Text = "Retour initial du curseur";
            this.Retour_initial.UseVisualStyleBackColor = true;
            this.Retour_initial.Click += new System.EventHandler(this.Retour_initial_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(425, 453);
            this.Controls.Add(this.Retour_initial);
            this.Controls.Add(this.Retour_ligne);
            this.Controls.Add(this.Supprimer_fichier);
            this.Controls.Add(this.Deplacer);
            this.Controls.Add(this.Vider_fichier);
            this.Controls.Add(this.Word);
            this.Controls.Add(this.Vider_ecriture);
            this.Controls.Add(this.Ecrire_fichier);
            this.Controls.Add(this.Vider_lecture);
            this.Controls.Add(this.Lire);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Lire | Ecrire | Supprimer | Déplacer un fichier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Lire;
        private System.Windows.Forms.Button Vider_lecture;
        private System.Windows.Forms.Button Ecrire_fichier;
        private System.Windows.Forms.Button Vider_ecriture;
        private System.Windows.Forms.Button Word;
        private System.Windows.Forms.Button Vider_fichier;
        private System.Windows.Forms.Button Deplacer;
        private System.Windows.Forms.Button Supprimer_fichier;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button Retour_ligne;
        private System.Windows.Forms.Button Retour_initial;
    }
}

