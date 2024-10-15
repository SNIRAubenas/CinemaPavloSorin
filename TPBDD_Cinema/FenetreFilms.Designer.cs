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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            richTextBox1 = new RichTextBox();
            label4 = new Label();
            insererImage = new Button();
            pictureBox = new PictureBox();
            validerAjouterFilme = new Button();
            numericUpDown1 = new NumericUpDown();
            label6 = new Label();
            numericUpDown2 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            label7 = new Label();
            label8 = new Label();
            label5 = new Label();
            filmBindingSource1 = new BindingSource(components);
            filmBindingSource2 = new BindingSource(components);
            panelAjouterFilm = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)filmBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)filmBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)filmBindingSource2).BeginInit();
            panelAjouterFilm.SuspendLayout();
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
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(573, 386);
            dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            titleDataGridViewTextBoxColumn.HeaderText = "Title";
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            yearDataGridViewTextBoxColumn.HeaderText = "Year";
            yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            yearDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lengthDataGridViewTextBoxColumn
            // 
            lengthDataGridViewTextBoxColumn.DataPropertyName = "Length";
            lengthDataGridViewTextBoxColumn.HeaderText = "Length";
            lengthDataGridViewTextBoxColumn.Name = "lengthDataGridViewTextBoxColumn";
            lengthDataGridViewTextBoxColumn.ReadOnly = true;
            lengthDataGridViewTextBoxColumn.Width = 130;
            // 
            // summaryDataGridViewTextBoxColumn
            // 
            summaryDataGridViewTextBoxColumn.DataPropertyName = "Summary";
            summaryDataGridViewTextBoxColumn.HeaderText = "Summary";
            summaryDataGridViewTextBoxColumn.Name = "summaryDataGridViewTextBoxColumn";
            summaryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // posterDataGridViewImageColumn
            // 
            posterDataGridViewImageColumn.DataPropertyName = "Poster";
            posterDataGridViewImageColumn.HeaderText = "Poster";
            posterDataGridViewImageColumn.Name = "posterDataGridViewImageColumn";
            posterDataGridViewImageColumn.ReadOnly = true;
            posterDataGridViewImageColumn.Visible = false;
            // 
            // filmactorsDataGridViewTextBoxColumn
            // 
            filmactorsDataGridViewTextBoxColumn.DataPropertyName = "Filmactors";
            filmactorsDataGridViewTextBoxColumn.HeaderText = "Filmactors";
            filmactorsDataGridViewTextBoxColumn.Name = "filmactorsDataGridViewTextBoxColumn";
            filmactorsDataGridViewTextBoxColumn.ReadOnly = true;
            filmactorsDataGridViewTextBoxColumn.Visible = false;
            // 
            // filmdirectorsDataGridViewTextBoxColumn
            // 
            filmdirectorsDataGridViewTextBoxColumn.DataPropertyName = "Filmdirectors";
            filmdirectorsDataGridViewTextBoxColumn.HeaderText = "Filmdirectors";
            filmdirectorsDataGridViewTextBoxColumn.Name = "filmdirectorsDataGridViewTextBoxColumn";
            filmdirectorsDataGridViewTextBoxColumn.ReadOnly = true;
            filmdirectorsDataGridViewTextBoxColumn.Visible = false;
            // 
            // filmBindingSource
            // 
            filmBindingSource.DataSource = typeof(Models.Film);
            // 
            // AjouterFilm
            // 
            AjouterFilm.Location = new Point(754, 60);
            AjouterFilm.Name = "AjouterFilm";
            AjouterFilm.Size = new Size(75, 23);
            AjouterFilm.TabIndex = 1;
            AjouterFilm.Text = "Ajouter";
            AjouterFilm.UseVisualStyleBackColor = true;
            // 
            // ModifierFilm
            // 
            ModifierFilm.Location = new Point(863, 60);
            ModifierFilm.Name = "ModifierFilm";
            ModifierFilm.Size = new Size(75, 23);
            ModifierFilm.TabIndex = 2;
            ModifierFilm.Text = "Modifier";
            ModifierFilm.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(975, 60);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "Supprimer";
            button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 27);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 4;
            label1.Text = "Entrez le titre";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(127, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(165, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(229, 76);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(63, 23);
            textBox2.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 76);
            label2.Name = "label2";
            label2.Size = new Size(154, 15);
            label2.TabIndex = 7;
            label2.Text = "Entrez l'annee de la creation";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 144);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 8;
            label3.Text = "Entrez la duree";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(169, 208);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(320, 133);
            richTextBox1.TabIndex = 10;
            richTextBox1.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 211);
            label4.Name = "label4";
            label4.Size = new Size(113, 15);
            label4.TabIndex = 11;
            label4.Text = "Entrez la description";
            // 
            // insererImage
            // 
            insererImage.Location = new Point(40, 407);
            insererImage.Name = "insererImage";
            insererImage.Size = new Size(104, 23);
            insererImage.TabIndex = 12;
            insererImage.Text = "Choisir Image";
            insererImage.UseVisualStyleBackColor = true;
            insererImage.Click += insererImage_Click;
            // 
            // pictureBox
            // 
            pictureBox.BackColor = SystemColors.AppWorkspace;
            pictureBox.BorderStyle = BorderStyle.Fixed3D;
            pictureBox.Location = new Point(212, 361);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(214, 154);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 13;
            pictureBox.TabStop = false;
            // 
            // validerAjouterFilme
            // 
            validerAjouterFilme.Location = new Point(229, 596);
            validerAjouterFilme.Name = "validerAjouterFilme";
            validerAjouterFilme.Size = new Size(116, 48);
            validerAjouterFilme.TabIndex = 15;
            validerAjouterFilme.Text = "OK";
            validerAjouterFilme.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(229, 144);
            numericUpDown1.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(58, 23);
            numericUpDown1.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(169, 144);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 17;
            label6.Text = "Heures";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(381, 144);
            numericUpDown2.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(58, 23);
            numericUpDown2.TabIndex = 18;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(519, 142);
            numericUpDown3.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(61, 23);
            numericUpDown3.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(312, 144);
            label7.Name = "label7";
            label7.Size = new Size(50, 15);
            label7.TabIndex = 20;
            label7.Text = "Minutes";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(456, 144);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 21;
            label8.Text = "Secondes";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8F);
            label5.Location = new Point(275, 518);
            label5.Name = "label5";
            label5.Size = new Size(87, 13);
            label5.TabIndex = 22;
            label5.Text = "Previsualisation";
            // 
            // filmBindingSource1
            // 
            filmBindingSource1.DataSource = typeof(Models.Film);
            // 
            // filmBindingSource2
            // 
            filmBindingSource2.DataSource = typeof(Models.Film);
            // 
            // panelAjouterFilm
            // 
            panelAjouterFilm.Controls.Add(label1);
            panelAjouterFilm.Controls.Add(label5);
            panelAjouterFilm.Controls.Add(textBox1);
            panelAjouterFilm.Controls.Add(validerAjouterFilme);
            panelAjouterFilm.Controls.Add(numericUpDown3);
            panelAjouterFilm.Controls.Add(pictureBox);
            panelAjouterFilm.Controls.Add(label8);
            panelAjouterFilm.Controls.Add(insererImage);
            panelAjouterFilm.Controls.Add(label2);
            panelAjouterFilm.Controls.Add(richTextBox1);
            panelAjouterFilm.Controls.Add(label4);
            panelAjouterFilm.Controls.Add(label7);
            panelAjouterFilm.Controls.Add(numericUpDown2);
            panelAjouterFilm.Controls.Add(textBox2);
            panelAjouterFilm.Controls.Add(label3);
            panelAjouterFilm.Controls.Add(label6);
            panelAjouterFilm.Controls.Add(numericUpDown1);
            panelAjouterFilm.Location = new Point(677, 89);
            panelAjouterFilm.Name = "panelAjouterFilm";
            panelAjouterFilm.Size = new Size(591, 660);
            panelAjouterFilm.TabIndex = 23;
            // 
            // FenetreFilms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1341, 772);
            Controls.Add(panelAjouterFilm);
            Controls.Add(button3);
            Controls.Add(ModifierFilm);
            Controls.Add(AjouterFilm);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FenetreFilms";
            Text = "FenetreFilms";
            Load += FenetreFilms_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)filmBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)filmBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)filmBindingSource2).EndInit();
            panelAjouterFilm.ResumeLayout(false);
            panelAjouterFilm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button AjouterFilm;
        private Button ModifierFilm;
        private Button button3;
        private BindingSource filmBindingSource;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private RichTextBox richTextBox1;
        private Label label4;
        private Button insererImage;
        private PictureBox pictureBox;
        private Button validerAjouterFilme;
        private NumericUpDown numericUpDown1;
        private Label label6;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private Label label7;
        private Label label8;
        private Label label5;
        private BindingSource filmBindingSource1;
        private BindingSource filmBindingSource2;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lengthDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn summaryDataGridViewTextBoxColumn;
        private DataGridViewImageColumn posterDataGridViewImageColumn;
        private DataGridViewTextBoxColumn filmactorsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn filmdirectorsDataGridViewTextBoxColumn;
        private Panel panelAjouterFilm;
    }
}