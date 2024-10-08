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
            Ajouter = new Button();
            Modifier = new Button();
            Supprimer = new Button();
            dataGridView1 = new DataGridView();
            actorBindingSource = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            filmactorsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)actorBindingSource).BeginInit();
            SuspendLayout();
            // 
            // Ajouter
            // 
            Ajouter.Location = new Point(690, 41);
            Ajouter.Name = "Ajouter";
            Ajouter.Size = new Size(75, 23);
            Ajouter.TabIndex = 0;
            Ajouter.Text = "Ajouter";
            Ajouter.UseVisualStyleBackColor = true;
            Ajouter.Click += button1_Click;
            // 
            // Modifier
            // 
            Modifier.Location = new Point(690, 97);
            Modifier.Name = "Modifier";
            Modifier.Size = new Size(75, 23);
            Modifier.TabIndex = 1;
            Modifier.Text = "Modifier";
            Modifier.UseVisualStyleBackColor = true;
            // 
            // Supprimer
            // 
            Supprimer.Location = new Point(690, 197);
            Supprimer.Name = "Supprimer";
            Supprimer.Size = new Size(75, 23);
            Supprimer.TabIndex = 2;
            Supprimer.Text = "Supprimer";
            Supprimer.UseVisualStyleBackColor = true;
            Supprimer.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, filmactorsDataGridViewTextBoxColumn });
            dataGridView1.DataSource = actorBindingSource;
            dataGridView1.Location = new Point(61, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(512, 228);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // actorBindingSource
            // 
            actorBindingSource.DataSource = typeof(Models.Actor);
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // filmactorsDataGridViewTextBoxColumn
            // 
            filmactorsDataGridViewTextBoxColumn.DataPropertyName = "Filmactors";
            filmactorsDataGridViewTextBoxColumn.HeaderText = "Filmactors";
            filmactorsDataGridViewTextBoxColumn.Name = "filmactorsDataGridViewTextBoxColumn";
            // 
            // FenetreActeur
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(Supprimer);
            Controls.Add(Modifier);
            Controls.Add(Ajouter);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FenetreActeur";
            Text = "FenetreActeur";
            Load += FenetreActeur_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)actorBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Ajouter;
        private Button Modifier;
        private Button Supprimer;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn filmactorsDataGridViewTextBoxColumn;
        private BindingSource actorBindingSource;
    }
}