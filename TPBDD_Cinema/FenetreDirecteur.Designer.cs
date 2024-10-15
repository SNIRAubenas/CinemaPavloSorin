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
            ((System.ComponentModel.ISupportInitialize)tableDirecteurs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)directorBindingSource).BeginInit();
            SuspendLayout();
            // 
            // Ajouter
            // 
            Ajouter.Location = new Point(469, 80);
            Ajouter.Name = "Ajouter";
            Ajouter.Size = new Size(75, 23);
            Ajouter.TabIndex = 0;
            Ajouter.Text = "Ajouter";
            Ajouter.UseVisualStyleBackColor = true;
            // 
            // Modifier
            // 
            Modifier.Location = new Point(469, 169);
            Modifier.Name = "Modifier";
            Modifier.Size = new Size(75, 23);
            Modifier.TabIndex = 1;
            Modifier.Text = "Modifier";
            Modifier.UseVisualStyleBackColor = true;
            // 
            // Supprimer
            // 
            Supprimer.Location = new Point(469, 263);
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
            tableDirecteurs.Location = new Point(49, 80);
            tableDirecteurs.Name = "tableDirecteurs";
            tableDirecteurs.Size = new Size(347, 206);
            tableDirecteurs.TabIndex = 3;
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
            // filmdirectorsDataGridViewTextBoxColumn
            // 
            filmdirectorsDataGridViewTextBoxColumn.DataPropertyName = "Filmdirectors";
            filmdirectorsDataGridViewTextBoxColumn.HeaderText = "Filmdirectors";
            filmdirectorsDataGridViewTextBoxColumn.Name = "filmdirectorsDataGridViewTextBoxColumn";
            // 
            // directorBindingSource
            // 
            directorBindingSource.DataSource = typeof(Models.Director);
            // 
            // FenetreDirecteur
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(663, 404);
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
        }

        #endregion

        private Button Ajouter;
        private Button Modifier;
        private Button Supprimer;
        private DataGridView tableDirecteurs;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn filmdirectorsDataGridViewTextBoxColumn;
        private BindingSource directorBindingSource;
    }
}