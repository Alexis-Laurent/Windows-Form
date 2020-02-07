namespace BddClient
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coordonneesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDeNaissanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vpcDataSet = new BddClient.vpcDataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idAdresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codePostalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClientDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTypeAdresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vpcDataSet1 = new BddClient.vpcDataSet1();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.idCommandeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProduitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixTTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCommandeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClientDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFactureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commandeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vpcDataSet2 = new BddClient.vpcDataSet2();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.idFactureDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numFactureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClientDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPaiementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAdresseDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vpcDataSet3 = new BddClient.vpcDataSet3();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.clientTableAdapter = new BddClient.vpcDataSetTableAdapters.ClientTableAdapter();
            this.adresseTableAdapter = new BddClient.vpcDataSet1TableAdapters.AdresseTableAdapter();
            this.commandeTableAdapter = new BddClient.vpcDataSet2TableAdapters.CommandeTableAdapter();
            this.factureTableAdapter = new BddClient.vpcDataSet3TableAdapters.FactureTableAdapter();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatutLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_adresse = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_rechercheclient = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_telephone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_prenom = new System.Windows.Forms.TextBox();
            this.textBox_nom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.Label_nom = new System.Windows.Forms.Label();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpcDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adresseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpcDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpcDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpcDataSet3)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientsToolStripMenuItem,
            this.coordonneesToolStripMenuItem,
            this.commandesToolStripMenuItem,
            this.facturesToolStripMenuItem,
            this.ajouterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1005, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tousToolStripMenuItem});
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.clientsToolStripMenuItem.Text = "Clients";
            // 
            // tousToolStripMenuItem
            // 
            this.tousToolStripMenuItem.Name = "tousToolStripMenuItem";
            this.tousToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.tousToolStripMenuItem.Text = "Tous les clients";
            this.tousToolStripMenuItem.Click += new System.EventHandler(this.tousToolStripMenuItem_Click);
            // 
            // coordonneesToolStripMenuItem
            // 
            this.coordonneesToolStripMenuItem.Name = "coordonneesToolStripMenuItem";
            this.coordonneesToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.coordonneesToolStripMenuItem.Text = "Coordonnees";
            this.coordonneesToolStripMenuItem.Click += new System.EventHandler(this.coordonneesToolStripMenuItem_Click);
            // 
            // commandesToolStripMenuItem
            // 
            this.commandesToolStripMenuItem.Name = "commandesToolStripMenuItem";
            this.commandesToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.commandesToolStripMenuItem.Text = "Commandes";
            this.commandesToolStripMenuItem.Click += new System.EventHandler(this.commandesToolStripMenuItem_Click);
            // 
            // facturesToolStripMenuItem
            // 
            this.facturesToolStripMenuItem.Name = "facturesToolStripMenuItem";
            this.facturesToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.facturesToolStripMenuItem.Text = "Factures";
            this.facturesToolStripMenuItem.Click += new System.EventHandler(this.facturesToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClientDataGridViewTextBoxColumn,
            this.nomClientDataGridViewTextBoxColumn,
            this.prenomClientDataGridViewTextBoxColumn,
            this.dateDeNaissanceDataGridViewTextBoxColumn,
            this.sexeDataGridViewTextBoxColumn,
            this.telephoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clientBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(515, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(651, 149);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.vpcDataSet;
            // 
            // vpcDataSet
            // 
            this.vpcDataSet.DataSetName = "vpcDataSet";
            this.vpcDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAdresseDataGridViewTextBoxColumn,
            this.rueDataGridViewTextBoxColumn,
            this.codePostalDataGridViewTextBoxColumn,
            this.villeDataGridViewTextBoxColumn,
            this.paysDataGridViewTextBoxColumn,
            this.regionDataGridViewTextBoxColumn,
            this.idClientDataGridViewTextBoxColumn1,
            this.idTypeAdresseDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.adresseBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(515, 179);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(651, 149);
            this.dataGridView2.TabIndex = 2;
            // 
            // idAdresseDataGridViewTextBoxColumn
            // 
            this.idAdresseDataGridViewTextBoxColumn.DataPropertyName = "IdAdresse";
            this.idAdresseDataGridViewTextBoxColumn.HeaderText = "IdAdresse";
            this.idAdresseDataGridViewTextBoxColumn.Name = "idAdresseDataGridViewTextBoxColumn";
            this.idAdresseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rueDataGridViewTextBoxColumn
            // 
            this.rueDataGridViewTextBoxColumn.DataPropertyName = "Rue";
            this.rueDataGridViewTextBoxColumn.HeaderText = "Rue";
            this.rueDataGridViewTextBoxColumn.Name = "rueDataGridViewTextBoxColumn";
            // 
            // codePostalDataGridViewTextBoxColumn
            // 
            this.codePostalDataGridViewTextBoxColumn.DataPropertyName = "CodePostal";
            this.codePostalDataGridViewTextBoxColumn.HeaderText = "CodePostal";
            this.codePostalDataGridViewTextBoxColumn.Name = "codePostalDataGridViewTextBoxColumn";
            // 
            // villeDataGridViewTextBoxColumn
            // 
            this.villeDataGridViewTextBoxColumn.DataPropertyName = "Ville";
            this.villeDataGridViewTextBoxColumn.HeaderText = "Ville";
            this.villeDataGridViewTextBoxColumn.Name = "villeDataGridViewTextBoxColumn";
            // 
            // paysDataGridViewTextBoxColumn
            // 
            this.paysDataGridViewTextBoxColumn.DataPropertyName = "Pays";
            this.paysDataGridViewTextBoxColumn.HeaderText = "Pays";
            this.paysDataGridViewTextBoxColumn.Name = "paysDataGridViewTextBoxColumn";
            // 
            // regionDataGridViewTextBoxColumn
            // 
            this.regionDataGridViewTextBoxColumn.DataPropertyName = "Region";
            this.regionDataGridViewTextBoxColumn.HeaderText = "Region";
            this.regionDataGridViewTextBoxColumn.Name = "regionDataGridViewTextBoxColumn";
            // 
            // idClientDataGridViewTextBoxColumn1
            // 
            this.idClientDataGridViewTextBoxColumn1.DataPropertyName = "IdClient";
            this.idClientDataGridViewTextBoxColumn1.HeaderText = "IdClient";
            this.idClientDataGridViewTextBoxColumn1.Name = "idClientDataGridViewTextBoxColumn1";
            // 
            // idTypeAdresseDataGridViewTextBoxColumn
            // 
            this.idTypeAdresseDataGridViewTextBoxColumn.DataPropertyName = "IdTypeAdresse";
            this.idTypeAdresseDataGridViewTextBoxColumn.HeaderText = "IdTypeAdresse";
            this.idTypeAdresseDataGridViewTextBoxColumn.Name = "idTypeAdresseDataGridViewTextBoxColumn";
            // 
            // adresseBindingSource
            // 
            this.adresseBindingSource.DataMember = "Adresse";
            this.adresseBindingSource.DataSource = this.vpcDataSet1;
            // 
            // vpcDataSet1
            // 
            this.vpcDataSet1.DataSetName = "vpcDataSet1";
            this.vpcDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCommandeDataGridViewTextBoxColumn,
            this.idProduitDataGridViewTextBoxColumn,
            this.quantiteDataGridViewTextBoxColumn,
            this.prixTTCDataGridViewTextBoxColumn,
            this.dateCommandeDataGridViewTextBoxColumn,
            this.idClientDataGridViewTextBoxColumn2,
            this.idFactureDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.commandeBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(515, 334);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(651, 149);
            this.dataGridView3.TabIndex = 3;
            // 
            // idCommandeDataGridViewTextBoxColumn
            // 
            this.idCommandeDataGridViewTextBoxColumn.DataPropertyName = "IdCommande";
            this.idCommandeDataGridViewTextBoxColumn.HeaderText = "IdCommande";
            this.idCommandeDataGridViewTextBoxColumn.Name = "idCommandeDataGridViewTextBoxColumn";
            this.idCommandeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idProduitDataGridViewTextBoxColumn
            // 
            this.idProduitDataGridViewTextBoxColumn.DataPropertyName = "IdProduit";
            this.idProduitDataGridViewTextBoxColumn.HeaderText = "IdProduit";
            this.idProduitDataGridViewTextBoxColumn.Name = "idProduitDataGridViewTextBoxColumn";
            // 
            // quantiteDataGridViewTextBoxColumn
            // 
            this.quantiteDataGridViewTextBoxColumn.DataPropertyName = "Quantite";
            this.quantiteDataGridViewTextBoxColumn.HeaderText = "Quantite";
            this.quantiteDataGridViewTextBoxColumn.Name = "quantiteDataGridViewTextBoxColumn";
            // 
            // prixTTCDataGridViewTextBoxColumn
            // 
            this.prixTTCDataGridViewTextBoxColumn.DataPropertyName = "PrixTTC";
            this.prixTTCDataGridViewTextBoxColumn.HeaderText = "PrixTTC";
            this.prixTTCDataGridViewTextBoxColumn.Name = "prixTTCDataGridViewTextBoxColumn";
            // 
            // dateCommandeDataGridViewTextBoxColumn
            // 
            this.dateCommandeDataGridViewTextBoxColumn.DataPropertyName = "DateCommande";
            this.dateCommandeDataGridViewTextBoxColumn.HeaderText = "DateCommande";
            this.dateCommandeDataGridViewTextBoxColumn.Name = "dateCommandeDataGridViewTextBoxColumn";
            // 
            // idClientDataGridViewTextBoxColumn2
            // 
            this.idClientDataGridViewTextBoxColumn2.DataPropertyName = "IdClient";
            this.idClientDataGridViewTextBoxColumn2.HeaderText = "IdClient";
            this.idClientDataGridViewTextBoxColumn2.Name = "idClientDataGridViewTextBoxColumn2";
            // 
            // idFactureDataGridViewTextBoxColumn
            // 
            this.idFactureDataGridViewTextBoxColumn.DataPropertyName = "IdFacture";
            this.idFactureDataGridViewTextBoxColumn.HeaderText = "IdFacture";
            this.idFactureDataGridViewTextBoxColumn.Name = "idFactureDataGridViewTextBoxColumn";
            // 
            // commandeBindingSource
            // 
            this.commandeBindingSource.DataMember = "Commande";
            this.commandeBindingSource.DataSource = this.vpcDataSet2;
            // 
            // vpcDataSet2
            // 
            this.vpcDataSet2.DataSetName = "vpcDataSet2";
            this.vpcDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFactureDataGridViewTextBoxColumn1,
            this.numFactureDataGridViewTextBoxColumn,
            this.prixTotalDataGridViewTextBoxColumn,
            this.idClientDataGridViewTextBoxColumn3,
            this.idPaiementDataGridViewTextBoxColumn,
            this.idAdresseDataGridViewTextBoxColumn1});
            this.dataGridView4.DataSource = this.factureBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(515, 488);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(651, 149);
            this.dataGridView4.TabIndex = 4;
            // 
            // idFactureDataGridViewTextBoxColumn1
            // 
            this.idFactureDataGridViewTextBoxColumn1.DataPropertyName = "IdFacture";
            this.idFactureDataGridViewTextBoxColumn1.HeaderText = "IdFacture";
            this.idFactureDataGridViewTextBoxColumn1.Name = "idFactureDataGridViewTextBoxColumn1";
            this.idFactureDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // numFactureDataGridViewTextBoxColumn
            // 
            this.numFactureDataGridViewTextBoxColumn.DataPropertyName = "NumFacture";
            this.numFactureDataGridViewTextBoxColumn.HeaderText = "NumFacture";
            this.numFactureDataGridViewTextBoxColumn.Name = "numFactureDataGridViewTextBoxColumn";
            // 
            // prixTotalDataGridViewTextBoxColumn
            // 
            this.prixTotalDataGridViewTextBoxColumn.DataPropertyName = "PrixTotal";
            this.prixTotalDataGridViewTextBoxColumn.HeaderText = "PrixTotal";
            this.prixTotalDataGridViewTextBoxColumn.Name = "prixTotalDataGridViewTextBoxColumn";
            // 
            // idClientDataGridViewTextBoxColumn3
            // 
            this.idClientDataGridViewTextBoxColumn3.DataPropertyName = "IdClient";
            this.idClientDataGridViewTextBoxColumn3.HeaderText = "IdClient";
            this.idClientDataGridViewTextBoxColumn3.Name = "idClientDataGridViewTextBoxColumn3";
            // 
            // idPaiementDataGridViewTextBoxColumn
            // 
            this.idPaiementDataGridViewTextBoxColumn.DataPropertyName = "IdPaiement";
            this.idPaiementDataGridViewTextBoxColumn.HeaderText = "IdPaiement";
            this.idPaiementDataGridViewTextBoxColumn.Name = "idPaiementDataGridViewTextBoxColumn";
            // 
            // idAdresseDataGridViewTextBoxColumn1
            // 
            this.idAdresseDataGridViewTextBoxColumn1.DataPropertyName = "IdAdresse";
            this.idAdresseDataGridViewTextBoxColumn1.HeaderText = "IdAdresse";
            this.idAdresseDataGridViewTextBoxColumn1.Name = "idAdresseDataGridViewTextBoxColumn1";
            // 
            // factureBindingSource
            // 
            this.factureBindingSource.DataMember = "Facture";
            this.factureBindingSource.DataSource = this.vpcDataSet3;
            // 
            // vpcDataSet3
            // 
            this.vpcDataSet3.DataSetName = "vpcDataSet3";
            this.vpcDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(471, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Clients";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(439, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Coordonnées";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(444, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Commandes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(461, 500);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Factures";
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // adresseTableAdapter
            // 
            this.adresseTableAdapter.ClearBeforeFill = true;
            // 
            // commandeTableAdapter
            // 
            this.commandeTableAdapter.ClearBeforeFill = true;
            // 
            // factureTableAdapter
            // 
            this.factureTableAdapter.ClearBeforeFill = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel1,
            this.StatutLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 660);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1005, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // StatusLabel1
            // 
            this.StatusLabel1.Name = "StatusLabel1";
            this.StatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // StatutLabel
            // 
            this.StatutLabel.Name = "StatutLabel";
            this.StatutLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.textBox_adresse);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.textBox_rechercheclient);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.textBox_password);
            this.panel1.Controls.Add(this.textBox_email);
            this.panel1.Controls.Add(this.textBox_telephone);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBox_prenom);
            this.panel1.Controls.Add(this.textBox_nom);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Label_nom);
            this.panel1.Location = new System.Drawing.Point(11, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 605);
            this.panel1.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(92, 314);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Adresse";
            // 
            // textBox_adresse
            // 
            this.textBox_adresse.Location = new System.Drawing.Point(141, 311);
            this.textBox_adresse.Name = "textBox_adresse";
            this.textBox_adresse.Size = new System.Drawing.Size(200, 20);
            this.textBox_adresse.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(41, 272);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Date de naissance";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(96, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Recherche par ID client";
            // 
            // textBox_rechercheclient
            // 
            this.textBox_rechercheclient.Location = new System.Drawing.Point(222, 19);
            this.textBox_rechercheclient.Name = "textBox_rechercheclient";
            this.textBox_rechercheclient.Size = new System.Drawing.Size(97, 20);
            this.textBox_rechercheclient.TabIndex = 12;
            this.textBox_rechercheclient.TextChanged += new System.EventHandler(this.textBox_rechercheclient_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(63, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(190, 25);
            this.label9.TabIndex = 11;
            this.label9.Text = "Information du Client";
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(139, 448);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(200, 20);
            this.textBox_password.TabIndex = 10;
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(139, 405);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(200, 20);
            this.textBox_email.TabIndex = 9;
            // 
            // textBox_telephone
            // 
            this.textBox_telephone.Location = new System.Drawing.Point(141, 358);
            this.textBox_telephone.Name = "textBox_telephone";
            this.textBox_telephone.Size = new System.Drawing.Size(198, 20);
            this.textBox_telephone.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(82, 451);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(103, 408);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Email";
            // 
            // textBox_prenom
            // 
            this.textBox_prenom.Location = new System.Drawing.Point(143, 223);
            this.textBox_prenom.Name = "textBox_prenom";
            this.textBox_prenom.Size = new System.Drawing.Size(198, 20);
            this.textBox_prenom.TabIndex = 5;
            // 
            // textBox_nom
            // 
            this.textBox_nom.Location = new System.Drawing.Point(143, 179);
            this.textBox_nom.Name = "textBox_nom";
            this.textBox_nom.Size = new System.Drawing.Size(198, 20);
            this.textBox_nom.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Téléphone";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(143, 266);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(198, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Prénom";
            // 
            // Label_nom
            // 
            this.Label_nom.AutoSize = true;
            this.Label_nom.Location = new System.Drawing.Point(108, 182);
            this.Label_nom.Name = "Label_nom";
            this.Label_nom.Size = new System.Drawing.Size(29, 13);
            this.Label_nom.TabIndex = 0;
            this.Label_nom.Text = "Nom";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1005, 682);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Gestion des clients";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpcDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adresseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpcDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpcDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpcDataSet3)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coordonneesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commandesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturesToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private vpcDataSet vpcDataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private vpcDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDeNaissanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private vpcDataSet1 vpcDataSet1;
        private System.Windows.Forms.BindingSource adresseBindingSource;
        private vpcDataSet1TableAdapters.AdresseTableAdapter adresseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAdresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codePostalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClientDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTypeAdresseDataGridViewTextBoxColumn;
        private vpcDataSet2 vpcDataSet2;
        private System.Windows.Forms.BindingSource commandeBindingSource;
        private vpcDataSet2TableAdapters.CommandeTableAdapter commandeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCommandeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProduitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixTTCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCommandeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClientDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFactureDataGridViewTextBoxColumn;
        private vpcDataSet3 vpcDataSet3;
        private System.Windows.Forms.BindingSource factureBindingSource;
        private vpcDataSet3TableAdapters.FactureTableAdapter factureTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFactureDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numFactureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClientDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPaiementDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAdresseDataGridViewTextBoxColumn1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Label_nom;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox_telephone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_prenom;
        private System.Windows.Forms.TextBox textBox_nom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_rechercheclient;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_adresse;
        private System.Windows.Forms.ToolStripStatusLabel StatutLabel;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
    }
}

