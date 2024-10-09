namespace TPBDD_Cinema
{
    partial class FenetreActeur
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
            ajouterButton = new Button();
            Modifier = new Button();
            Supprimer = new Button();
            tableActeurs = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            filmactorsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            actorBindingSource = new BindingSource(components);
            textBoxNom = new TextBox();
            labelNom = new Label();
            okModifier = new Button();
            ajouterTextBox = new TextBox();
            ajouterLabel = new Label();
            ajouterActeurButton = new Button();
            ((System.ComponentModel.ISupportInitialize)tableActeurs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)actorBindingSource).BeginInit();
            SuspendLayout();
            // 
            // ajouterButton
            // 
            ajouterButton.Location = new Point(54, 269);
            ajouterButton.Name = "ajouterButton";
            ajouterButton.Size = new Size(75, 23);
            ajouterButton.TabIndex = 0;
            ajouterButton.Text = "Ajouter";
            ajouterButton.UseVisualStyleBackColor = true;
            ajouterButton.Click += ajouterButton_Click;
            // 
            // Modifier
            // 
            Modifier.Location = new Point(186, 269);
            Modifier.Name = "Modifier";
            Modifier.Size = new Size(75, 23);
            Modifier.TabIndex = 1;
            Modifier.Text = "Modifier";
            Modifier.UseVisualStyleBackColor = true;
            Modifier.Click += Modifier_Click;
            // 
            // Supprimer
            // 
            Supprimer.Location = new Point(310, 269);
            Supprimer.Name = "Supprimer";
            Supprimer.Size = new Size(75, 23);
            Supprimer.TabIndex = 2;
            Supprimer.Text = "Supprimer";
            Supprimer.UseVisualStyleBackColor = true;
            Supprimer.Click += button3_Click;
            // 
            // tableActeurs
            // 
            tableActeurs.AutoGenerateColumns = false;
            tableActeurs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableActeurs.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, filmactorsDataGridViewTextBoxColumn });
            tableActeurs.DataSource = actorBindingSource;
            tableActeurs.Location = new Point(41, 12);
            tableActeurs.Name = "tableActeurs";
            tableActeurs.ReadOnly = true;
            tableActeurs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tableActeurs.Size = new Size(362, 228);
            tableActeurs.TabIndex = 3;
            tableActeurs.CellClick += tableActeurs_CellClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // filmactorsDataGridViewTextBoxColumn
            // 
            filmactorsDataGridViewTextBoxColumn.DataPropertyName = "Filmactors";
            filmactorsDataGridViewTextBoxColumn.HeaderText = "Filmactors";
            filmactorsDataGridViewTextBoxColumn.Name = "filmactorsDataGridViewTextBoxColumn";
            filmactorsDataGridViewTextBoxColumn.ReadOnly = true;
            filmactorsDataGridViewTextBoxColumn.Visible = false;
            // 
            // actorBindingSource
            // 
            actorBindingSource.DataSource = typeof(Models.Actor);
            // 
            // textBoxNom
            // 
            textBoxNom.Location = new Point(234, 336);
            textBoxNom.Name = "textBoxNom";
            textBoxNom.Size = new Size(194, 23);
            textBoxNom.TabIndex = 4;
            textBoxNom.TextChanged += textBoxNom_TextChanged;
            // 
            // labelNom
            // 
            labelNom.AutoSize = true;
            labelNom.Location = new Point(42, 344);
            labelNom.Name = "labelNom";
            labelNom.Size = new Size(174, 15);
            labelNom.TabIndex = 5;
            labelNom.Text = "Entrez le nouveau nom d'acteur";
            // 
            // okModifier
            // 
            okModifier.Location = new Point(186, 391);
            okModifier.Name = "okModifier";
            okModifier.Size = new Size(75, 23);
            okModifier.TabIndex = 6;
            okModifier.Text = "MODIFIER";
            okModifier.UseVisualStyleBackColor = true;
            okModifier.Click += okModifier_Click;
            // 
            // ajouterTextBox
            // 
            ajouterTextBox.Location = new Point(234, 336);
            ajouterTextBox.Name = "ajouterTextBox";
            ajouterTextBox.Size = new Size(201, 23);
            ajouterTextBox.TabIndex = 5;
            ajouterTextBox.TextChanged += ajouterTextBox_TextChanged;
            // 
            // ajouterLabel
            // 
            ajouterLabel.AutoSize = true;
            ajouterLabel.Location = new Point(18, 344);
            ajouterLabel.Name = "ajouterLabel";
            ajouterLabel.Size = new Size(210, 15);
            ajouterLabel.TabIndex = 7;
            ajouterLabel.Text = "Entrez le nom de votre nouveau acteur";
            // 
            // ajouterActeurButton
            // 
            ajouterActeurButton.Location = new Point(186, 391);
            ajouterActeurButton.Name = "ajouterActeurButton";
            ajouterActeurButton.Size = new Size(75, 23);
            ajouterActeurButton.TabIndex = 8;
            ajouterActeurButton.Text = "AJOUTER";
            ajouterActeurButton.UseVisualStyleBackColor = true;
            ajouterActeurButton.Click += ajouterActeurButton_Click;
            // 
            // FenetreActeur
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ajouterActeurButton);
            Controls.Add(ajouterLabel);
            Controls.Add(okModifier);
            Controls.Add(labelNom);
            Controls.Add(textBoxNom);
            Controls.Add(tableActeurs);
            Controls.Add(ajouterTextBox);
            Controls.Add(Supprimer);
            Controls.Add(Modifier);
            Controls.Add(ajouterButton);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FenetreActeur";
            Text = "FenetreActeur";
            Load += FenetreActeur_Load;
            ((System.ComponentModel.ISupportInitialize)tableActeurs).EndInit();
            ((System.ComponentModel.ISupportInitialize)actorBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ajouterButton;
        private Button Modifier;
        private Button Supprimer;
        private DataGridView tableActeurs;
        private BindingSource actorBindingSource;
        private TextBox ajouterTextBox;
        private TextBox textBoxNom;
        private Label labelNom;
        private Button okModifier;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn filmactorsDataGridViewTextBoxColumn;
        private Label ajouterLabel;
        private Button ajouterActeurButton;
    }
}