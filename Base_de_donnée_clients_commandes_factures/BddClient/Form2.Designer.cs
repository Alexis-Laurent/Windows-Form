namespace BddClient
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label9 = new System.Windows.Forms.Label();
            this.Label_nom = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker_ajouter = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_ajouter_prenom = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_ajouter_telephone = new System.Windows.Forms.TextBox();
            this.textBox_ajouter_email = new System.Windows.Forms.TextBox();
            this.textBox_ajouter_password = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_ajouter_nom = new System.Windows.Forms.TextBox();
            this.button_ajouter_client = new System.Windows.Forms.Button();
            this.dataGridView_supprimer = new System.Windows.Forms.DataGridView();
            this.vPCDataSet = new BddClient.VPCDataSet();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new BddClient.VPCDataSetTableAdapters.ClientTableAdapter();
            this.idClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDeNaissanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_supprimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(932, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.clientsToolStripMenuItem.Text = "Clients";
            this.clientsToolStripMenuItem.Click += new System.EventHandler(this.clientsToolStripMenuItem_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(156, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 24);
            this.label9.TabIndex = 28;
            this.label9.Text = "Ajouter un Client";
            // 
            // Label_nom
            // 
            this.Label_nom.AutoSize = true;
            this.Label_nom.Location = new System.Drawing.Point(107, 118);
            this.Label_nom.Name = "Label_nom";
            this.Label_nom.Size = new System.Drawing.Size(29, 13);
            this.Label_nom.TabIndex = 17;
            this.Label_nom.Text = "Nom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Prénom";
            // 
            // dateTimePicker_ajouter
            // 
            this.dateTimePicker_ajouter.Location = new System.Drawing.Point(142, 202);
            this.dateTimePicker_ajouter.Name = "dateTimePicker_ajouter";
            this.dateTimePicker_ajouter.Size = new System.Drawing.Size(198, 20);
            this.dateTimePicker_ajouter.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Téléphone";
            // 
            // textBox_ajouter_prenom
            // 
            this.textBox_ajouter_prenom.Location = new System.Drawing.Point(142, 159);
            this.textBox_ajouter_prenom.Name = "textBox_ajouter_prenom";
            this.textBox_ajouter_prenom.Size = new System.Drawing.Size(198, 20);
            this.textBox_ajouter_prenom.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(104, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(83, 345);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Password";
            // 
            // textBox_ajouter_telephone
            // 
            this.textBox_ajouter_telephone.Location = new System.Drawing.Point(142, 252);
            this.textBox_ajouter_telephone.Name = "textBox_ajouter_telephone";
            this.textBox_ajouter_telephone.Size = new System.Drawing.Size(198, 20);
            this.textBox_ajouter_telephone.TabIndex = 25;
            // 
            // textBox_ajouter_email
            // 
            this.textBox_ajouter_email.Location = new System.Drawing.Point(140, 299);
            this.textBox_ajouter_email.Name = "textBox_ajouter_email";
            this.textBox_ajouter_email.Size = new System.Drawing.Size(200, 20);
            this.textBox_ajouter_email.TabIndex = 26;
            // 
            // textBox_ajouter_password
            // 
            this.textBox_ajouter_password.Location = new System.Drawing.Point(140, 342);
            this.textBox_ajouter_password.Name = "textBox_ajouter_password";
            this.textBox_ajouter_password.Size = new System.Drawing.Size(200, 20);
            this.textBox_ajouter_password.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(40, 208);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Date de naissance";
            // 
            // textBox_ajouter_nom
            // 
            this.textBox_ajouter_nom.Location = new System.Drawing.Point(142, 115);
            this.textBox_ajouter_nom.Name = "textBox_ajouter_nom";
            this.textBox_ajouter_nom.Size = new System.Drawing.Size(198, 20);
            this.textBox_ajouter_nom.TabIndex = 21;
            // 
            // button_ajouter_client
            // 
            this.button_ajouter_client.Location = new System.Drawing.Point(199, 388);
            this.button_ajouter_client.Name = "button_ajouter_client";
            this.button_ajouter_client.Size = new System.Drawing.Size(75, 23);
            this.button_ajouter_client.TabIndex = 30;
            this.button_ajouter_client.Text = "Ajouter";
            this.button_ajouter_client.UseVisualStyleBackColor = true;
            this.button_ajouter_client.Click += new System.EventHandler(this.button_ajouter_client_Click);
            // 
            // dataGridView_supprimer
            // 
            this.dataGridView_supprimer.AutoGenerateColumns = false;
            this.dataGridView_supprimer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_supprimer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClientDataGridViewTextBoxColumn,
            this.nomClientDataGridViewTextBoxColumn,
            this.prenomClientDataGridViewTextBoxColumn,
            this.dateDeNaissanceDataGridViewTextBoxColumn,
            this.sexeDataGridViewTextBoxColumn,
            this.telephoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.dataGridView_supprimer.DataSource = this.clientBindingSource;
            this.dataGridView_supprimer.Location = new System.Drawing.Point(446, 224);
            this.dataGridView_supprimer.Name = "dataGridView_supprimer";
            this.dataGridView_supprimer.Size = new System.Drawing.Size(471, 211);
            this.dataGridView_supprimer.TabIndex = 31;
            this.dataGridView_supprimer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_supprimer_CellContentClick);
            // 
            // vPCDataSet
            // 
            this.vPCDataSet.DataSetName = "VPCDataSet";
            this.vPCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.vPCDataSet;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // idClientDataGridViewTextBoxColumn
            // 
            this.idClientDataGridViewTextBoxColumn.DataPropertyName = "IdClient";
            this.idClientDataGridViewTextBoxColumn.HeaderText = "IdClient";
            this.idClientDataGridViewTextBoxColumn.Name = "idClientDataGridViewTextBoxColumn";
            this.idClientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomClientDataGridViewTextBoxColumn
            // 
            this.nomClientDataGridViewTextBoxColumn.DataPropertyName = "NomClient";
            this.nomClientDataGridViewTextBoxColumn.HeaderText = "NomClient";
            this.nomClientDataGridViewTextBoxColumn.Name = "nomClientDataGridViewTextBoxColumn";
            // 
            // prenomClientDataGridViewTextBoxColumn
            // 
            this.prenomClientDataGridViewTextBoxColumn.DataPropertyName = "PrenomClient";
            this.prenomClientDataGridViewTextBoxColumn.HeaderText = "PrenomClient";
            this.prenomClientDataGridViewTextBoxColumn.Name = "prenomClientDataGridViewTextBoxColumn";
            // 
            // dateDeNaissanceDataGridViewTextBoxColumn
            // 
            this.dateDeNaissanceDataGridViewTextBoxColumn.DataPropertyName = "DateDeNaissance";
            this.dateDeNaissanceDataGridViewTextBoxColumn.HeaderText = "DateDeNaissance";
            this.dateDeNaissanceDataGridViewTextBoxColumn.Name = "dateDeNaissanceDataGridViewTextBoxColumn";
            // 
            // sexeDataGridViewTextBoxColumn
            // 
            this.sexeDataGridViewTextBoxColumn.DataPropertyName = "Sexe";
            this.sexeDataGridViewTextBoxColumn.HeaderText = "Sexe";
            this.sexeDataGridViewTextBoxColumn.Name = "sexeDataGridViewTextBoxColumn";
            // 
            // telephoneDataGridViewTextBoxColumn
            // 
            this.telephoneDataGridViewTextBoxColumn.DataPropertyName = "Telephone";
            this.telephoneDataGridViewTextBoxColumn.HeaderText = "Telephone";
            this.telephoneDataGridViewTextBoxColumn.Name = "telephoneDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(443, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Supprimer";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(932, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_supprimer);
            this.Controls.Add(this.button_ajouter_client);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_ajouter_password);
            this.Controls.Add(this.textBox_ajouter_email);
            this.Controls.Add(this.textBox_ajouter_telephone);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_ajouter_prenom);
            this.Controls.Add(this.textBox_ajouter_nom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker_ajouter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Label_nom);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_supprimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Label_nom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ajouter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_ajouter_prenom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_ajouter_telephone;
        private System.Windows.Forms.TextBox textBox_ajouter_email;
        private System.Windows.Forms.TextBox textBox_ajouter_password;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_ajouter_nom;
        private System.Windows.Forms.Button button_ajouter_client;
        private System.Windows.Forms.DataGridView dataGridView_supprimer;
        private VPCDataSet vPCDataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private VPCDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDeNaissanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}