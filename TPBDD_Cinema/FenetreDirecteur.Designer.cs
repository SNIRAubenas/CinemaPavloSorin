namespace TPBDD_Cinema
{
    partial class FenetreDirecteur
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
            components = new System.ComponentModel.Container();
            Ajouter = new Button();
            Modifier = new Button();
            Supprimer = new Button();
            tableDirecteurs = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            filmdirectorsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            directorBindingSource = new BindingSource(components);
            labelDirecteur = new Label();
            ajouterButtonDirecteur = new Button();
            textBoxDirecteur = new TextBox();
            labelModifDirecteur = new Label();
            textBoxModifDir = new TextBox();
            buttonModifDir = new Button();
            ((System.ComponentModel.ISupportInitialize)tableDirecteurs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)directorBindingSource).BeginInit();
            SuspendLayout();
            // 
            // Ajouter
            // 
            Ajouter.Location = new Point(49, 275);
            Ajouter.Name = "Ajouter";
            Ajouter.Size = new Size(75, 33);
            Ajouter.TabIndex = 0;
            Ajouter.Text = "Ajouter";
            Ajouter.UseVisualStyleBackColor = true;
            Ajouter.Click += Ajouter_Click;
            // 
            // Modifier
            // 
            Modifier.Location = new Point(180, 275);
            Modifier.Name = "Modifier";
            Modifier.Size = new Size(75, 33);
            Modifier.TabIndex = 1;
            Modifier.Text = "Modifier";
            Modifier.UseVisualStyleBackColor = true;
            Modifier.Click += Modifier_Click;
            // 
            // Supprimer
            // 
            Supprimer.Location = new Point(312, 275);
            Supprimer.Name = "Supprimer";
            Supprimer.Size = new Size(75, 33);
            Supprimer.TabIndex = 2;
            Supprimer.Text = "Supprimer";
            Supprimer.UseVisualStyleBackColor = true;
            Supprimer.Click += Supprimer_Click;
            // 
            // tableDirecteurs
            // 
            tableDirecteurs.AutoGenerateColumns = false;
            tableDirecteurs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableDirecteurs.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, filmdirectorsDataGridViewTextBoxColumn });
            tableDirecteurs.DataSource = directorBindingSource;
            tableDirecteurs.Location = new Point(49, 44);
            tableDirecteurs.Name = "tableDirecteurs";
            tableDirecteurs.ReadOnly = true;
            tableDirecteurs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tableDirecteurs.Size = new Size(338, 206);
            tableDirecteurs.TabIndex = 3;
            tableDirecteurs.CellClick += tableDirecteurs_CellClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // filmdirectorsDataGridViewTextBoxColumn
            // 
            filmdirectorsDataGridViewTextBoxColumn.DataPropertyName = "Filmdirectors";
            filmdirectorsDataGridViewTextBoxColumn.HeaderText = "Filmdirectors";
            filmdirectorsDataGridViewTextBoxColumn.Name = "filmdirectorsDataGridViewTextBoxColumn";
            filmdirectorsDataGridViewTextBoxColumn.ReadOnly = true;
            filmdirectorsDataGridViewTextBoxColumn.Visible = false;
            // 
            // directorBindingSource
            // 
            directorBindingSource.DataSource = typeof(Models.Director);
            // 
            // labelDirecteur
            // 
            labelDirecteur.AutoSize = true;
            labelDirecteur.Location = new Point(49, 375);
            labelDirecteur.Name = "labelDirecteur";
            labelDirecteur.Size = new Size(175, 15);
            labelDirecteur.TabIndex = 4;
            labelDirecteur.Text = "Entrez le nom de votre directeur";
            // 
            // ajouterButtonDirecteur
            // 
            ajouterButtonDirecteur.Location = new Point(180, 420);
            ajouterButtonDirecteur.Name = "ajouterButtonDirecteur";
            ajouterButtonDirecteur.Size = new Size(75, 23);
            ajouterButtonDirecteur.TabIndex = 5;
            ajouterButtonDirecteur.Text = "AJOUTER";
            ajouterButtonDirecteur.UseVisualStyleBackColor = true;
            ajouterButtonDirecteur.Click += ajouterButtonDirecteur_Click;
            // 
            // textBoxDirecteur
            // 
            textBoxDirecteur.Location = new Point(233, 367);
            textBoxDirecteur.Name = "textBoxDirecteur";
            textBoxDirecteur.Size = new Size(154, 23);
            textBoxDirecteur.TabIndex = 6;
            textBoxDirecteur.TextChanged += textBoxDirecteur_TextChanged;
            // 
            // labelModifDirecteur
            // 
            labelModifDirecteur.AutoSize = true;
            labelModifDirecteur.Location = new Point(33, 345);
            labelModifDirecteur.Name = "labelModifDirecteur";
            labelModifDirecteur.Size = new Size(194, 15);
            labelModifDirecteur.TabIndex = 7;
            labelModifDirecteur.Text = "Entrez le nouveau nom de directeur";
            // 
            // textBoxModifDir
            // 
            textBoxModifDir.Location = new Point(233, 342);
            textBoxModifDir.Name = "textBoxModifDir";
            textBoxModifDir.Size = new Size(154, 23);
            textBoxModifDir.TabIndex = 8;
            textBoxModifDir.TextChanged += textBoxModifDir_TextChanged;
            // 
            // buttonModifDir
            // 
            buttonModifDir.Location = new Point(180, 396);
            buttonModifDir.Name = "buttonModifDir";
            buttonModifDir.Size = new Size(75, 23);
            buttonModifDir.TabIndex = 9;
            buttonModifDir.Text = "MODIFIER";
            buttonModifDir.UseVisualStyleBackColor = true;
            buttonModifDir.Click += buttonModifDir_Click;
            // 
            // FenetreDirecteur
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(731, 534);
            Controls.Add(buttonModifDir);
            Controls.Add(textBoxModifDir);
            Controls.Add(labelModifDirecteur);
            Controls.Add(textBoxDirecteur);
            Controls.Add(ajouterButtonDirecteur);
            Controls.Add(labelDirecteur);
            Controls.Add(tableDirecteurs);
            Controls.Add(Supprimer);
            Controls.Add(Modifier);
            Controls.Add(Ajouter);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FenetreDirecteur";
            Text = "FenetreDirecteur";
            Load += FenetreDirecteur_Load;
            ((System.ComponentModel.ISupportInitialize)tableDirecteurs).EndInit();
            ((System.ComponentModel.ISupportInitialize)directorBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Ajouter;
        private Button Modifier;
        private Button Supprimer;
        private DataGridView tableDirecteurs;
        private BindingSource directorBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn filmdirectorsDataGridViewTextBoxColumn;
        private Label labelDirecteur;
        private Button ajouterButtonDirecteur;
        private TextBox textBoxDirecteur;
        private Label labelModifDirecteur;
        private TextBox textBoxModifDir;
        private Button buttonModifDir;
    }
}