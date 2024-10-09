namespace TPBDD_Cinema
{
    partial class FenetreFilms
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
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            yearDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lengthDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            summaryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            posterDataGridViewImageColumn = new DataGridViewImageColumn();
            filmactorsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            filmdirectorsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            filmBindingSource = new BindingSource(components);
            AjouterFilm = new Button();
            ModifierFilm = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)filmBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, titleDataGridViewTextBoxColumn, yearDataGridViewTextBoxColumn, lengthDataGridViewTextBoxColumn, summaryDataGridViewTextBoxColumn, posterDataGridViewImageColumn, filmactorsDataGridViewTextBoxColumn, filmdirectorsDataGridViewTextBoxColumn });
            dataGridView1.DataSource = filmBindingSource;
            dataGridView1.Location = new Point(51, 37);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(843, 386);
            dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            titleDataGridViewTextBoxColumn.HeaderText = "Title";
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // yearDataGridViewTextBoxColumn
            // 
            yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            yearDataGridViewTextBoxColumn.HeaderText = "Year";
            yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            // 
            // lengthDataGridViewTextBoxColumn
            // 
            lengthDataGridViewTextBoxColumn.DataPropertyName = "Length";
            lengthDataGridViewTextBoxColumn.HeaderText = "Length";
            lengthDataGridViewTextBoxColumn.Name = "lengthDataGridViewTextBoxColumn";
            // 
            // summaryDataGridViewTextBoxColumn
            // 
            summaryDataGridViewTextBoxColumn.DataPropertyName = "Summary";
            summaryDataGridViewTextBoxColumn.HeaderText = "Summary";
            summaryDataGridViewTextBoxColumn.Name = "summaryDataGridViewTextBoxColumn";
            // 
            // posterDataGridViewImageColumn
            // 
            posterDataGridViewImageColumn.DataPropertyName = "Poster";
            posterDataGridViewImageColumn.HeaderText = "Poster";
            posterDataGridViewImageColumn.Name = "posterDataGridViewImageColumn";
            // 
            // filmactorsDataGridViewTextBoxColumn
            // 
            filmactorsDataGridViewTextBoxColumn.DataPropertyName = "Filmactors";
            filmactorsDataGridViewTextBoxColumn.HeaderText = "Filmactors";
            filmactorsDataGridViewTextBoxColumn.Name = "filmactorsDataGridViewTextBoxColumn";
            // 
            // filmdirectorsDataGridViewTextBoxColumn
            // 
            filmdirectorsDataGridViewTextBoxColumn.DataPropertyName = "Filmdirectors";
            filmdirectorsDataGridViewTextBoxColumn.HeaderText = "Filmdirectors";
            filmdirectorsDataGridViewTextBoxColumn.Name = "filmdirectorsDataGridViewTextBoxColumn";
            // 
            // filmBindingSource
            // 
            filmBindingSource.DataSource = typeof(Models.Film);
            // 
            // AjouterFilm
            // 
            AjouterFilm.Location = new Point(69, 472);
            AjouterFilm.Name = "AjouterFilm";
            AjouterFilm.Size = new Size(75, 23);
            AjouterFilm.TabIndex = 1;
            AjouterFilm.Text = "Ajouter";
            AjouterFilm.UseVisualStyleBackColor = true;
            // 
            // ModifierFilm
            // 
            ModifierFilm.Location = new Point(162, 472);
            ModifierFilm.Name = "ModifierFilm";
            ModifierFilm.Size = new Size(75, 23);
            ModifierFilm.TabIndex = 2;
            ModifierFilm.Text = "Modifier";
            ModifierFilm.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(259, 472);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "Supprimer";
            button3.UseVisualStyleBackColor = true;
            // 
            // FenetreFilms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 567);
            Controls.Add(button3);
            Controls.Add(ModifierFilm);
            Controls.Add(AjouterFilm);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FenetreFilms";
            Text = "FenetreFilms";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)filmBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button AjouterFilm;
        private Button ModifierFilm;
        private Button button3;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lengthDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn summaryDataGridViewTextBoxColumn;
        private DataGridViewImageColumn posterDataGridViewImageColumn;
        private DataGridViewTextBoxColumn filmactorsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn filmdirectorsDataGridViewTextBoxColumn;
        private BindingSource filmBindingSource;
    }
}