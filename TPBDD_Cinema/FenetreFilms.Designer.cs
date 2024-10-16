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
            tableFilms = new DataGridView();
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
            SupprimerFilm = new Button();
            label1 = new Label();
            textTitreFilmAjouter = new TextBox();
            textYearFilmAjouter = new TextBox();
            label2 = new Label();
            label3 = new Label();
            descAjoutFilm = new RichTextBox();
            label4 = new Label();
            insererImage = new Button();
            pictureBox = new PictureBox();
            validerAjouterFilme = new Button();
            hourAjoutFilm = new NumericUpDown();
            label6 = new Label();
            minAjoutFilm = new NumericUpDown();
            secAjoutFilm = new NumericUpDown();
            label7 = new Label();
            label8 = new Label();
            label5 = new Label();
            filmBindingSource1 = new BindingSource(components);
            filmBindingSource2 = new BindingSource(components);
            panelAjouterFilm = new Panel();
            panelModifierFilm = new Panel();
            label9 = new Label();
            label10 = new Label();
            textTitreModifFilm = new TextBox();
            button1 = new Button();
            secondModifFilm = new NumericUpDown();
            pictureBox1 = new PictureBox();
            label11 = new Label();
            button2 = new Button();
            label12 = new Label();
            richTextBox2 = new RichTextBox();
            label13 = new Label();
            label14 = new Label();
            minuteModifFilm = new NumericUpDown();
            textYearModifFilm = new TextBox();
            label15 = new Label();
            label16 = new Label();
            hourModifFilm = new NumericUpDown();
            label17 = new Label();
            panelFilm = new Panel();
            descFilm = new RichTextBox();
            imageFilm = new PictureBox();
            label25 = new Label();
            label24 = new Label();
            timeFilm = new Label();
            label21 = new Label();
            yearFilm = new Label();
            label18 = new Label();
            titleFilm = new Label();
            mySqlCommandBuilder1 = new MySqlConnector.MySqlCommandBuilder();
            ((System.ComponentModel.ISupportInitialize)tableFilms).BeginInit();
            ((System.ComponentModel.ISupportInitialize)filmBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hourAjoutFilm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minAjoutFilm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)secAjoutFilm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)filmBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)filmBindingSource2).BeginInit();
            panelAjouterFilm.SuspendLayout();
            panelModifierFilm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)secondModifFilm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minuteModifFilm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hourModifFilm).BeginInit();
            panelFilm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imageFilm).BeginInit();
            SuspendLayout();
            // 
            // tableFilms
            // 
            tableFilms.AllowUserToAddRows = false;
            tableFilms.AutoGenerateColumns = false;
            tableFilms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableFilms.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, titleDataGridViewTextBoxColumn, yearDataGridViewTextBoxColumn, lengthDataGridViewTextBoxColumn, summaryDataGridViewTextBoxColumn, posterDataGridViewImageColumn, filmactorsDataGridViewTextBoxColumn, filmdirectorsDataGridViewTextBoxColumn });
            tableFilms.DataSource = filmBindingSource;
            tableFilms.Location = new Point(51, 37);
            tableFilms.Name = "tableFilms";
            tableFilms.ReadOnly = true;
            tableFilms.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tableFilms.Size = new Size(573, 386);
            tableFilms.TabIndex = 0;
            tableFilms.CellClick += tableFilms_CellClick;
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
            AjouterFilm.Click += AjouterFilm_Click;
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
            // SupprimerFilm
            // 
            SupprimerFilm.Location = new Point(975, 60);
            SupprimerFilm.Name = "SupprimerFilm";
            SupprimerFilm.Size = new Size(75, 23);
            SupprimerFilm.TabIndex = 3;
            SupprimerFilm.Text = "Supprimer";
            SupprimerFilm.UseVisualStyleBackColor = true;
            SupprimerFilm.Click += SupprimerFilm_Click;
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
            // textTitreFilmAjouter
            // 
            textTitreFilmAjouter.Location = new Point(127, 27);
            textTitreFilmAjouter.Name = "textTitreFilmAjouter";
            textTitreFilmAjouter.Size = new Size(165, 23);
            textTitreFilmAjouter.TabIndex = 5;
            // 
            // textYearFilmAjouter
            // 
            textYearFilmAjouter.Location = new Point(229, 76);
            textYearFilmAjouter.Name = "textYearFilmAjouter";
            textYearFilmAjouter.Size = new Size(63, 23);
            textYearFilmAjouter.TabIndex = 6;
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
            // descAjoutFilm
            // 
            descAjoutFilm.Location = new Point(169, 208);
            descAjoutFilm.Name = "descAjoutFilm";
            descAjoutFilm.Size = new Size(320, 133);
            descAjoutFilm.TabIndex = 10;
            descAjoutFilm.Text = "";
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
            validerAjouterFilme.Click += validerAjouterFilme_Click;
            // 
            // hourAjoutFilm
            // 
            hourAjoutFilm.Location = new Point(229, 144);
            hourAjoutFilm.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            hourAjoutFilm.Name = "hourAjoutFilm";
            hourAjoutFilm.Size = new Size(58, 23);
            hourAjoutFilm.TabIndex = 16;
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
            // minAjoutFilm
            // 
            minAjoutFilm.Location = new Point(381, 144);
            minAjoutFilm.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            minAjoutFilm.Name = "minAjoutFilm";
            minAjoutFilm.Size = new Size(58, 23);
            minAjoutFilm.TabIndex = 18;
            // 
            // secAjoutFilm
            // 
            secAjoutFilm.Location = new Point(519, 142);
            secAjoutFilm.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            secAjoutFilm.Name = "secAjoutFilm";
            secAjoutFilm.Size = new Size(61, 23);
            secAjoutFilm.TabIndex = 19;
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
            panelAjouterFilm.BorderStyle = BorderStyle.Fixed3D;
            panelAjouterFilm.Controls.Add(label1);
            panelAjouterFilm.Controls.Add(label5);
            panelAjouterFilm.Controls.Add(textTitreFilmAjouter);
            panelAjouterFilm.Controls.Add(validerAjouterFilme);
            panelAjouterFilm.Controls.Add(secAjoutFilm);
            panelAjouterFilm.Controls.Add(pictureBox);
            panelAjouterFilm.Controls.Add(label8);
            panelAjouterFilm.Controls.Add(insererImage);
            panelAjouterFilm.Controls.Add(label2);
            panelAjouterFilm.Controls.Add(descAjoutFilm);
            panelAjouterFilm.Controls.Add(label4);
            panelAjouterFilm.Controls.Add(label7);
            panelAjouterFilm.Controls.Add(minAjoutFilm);
            panelAjouterFilm.Controls.Add(textYearFilmAjouter);
            panelAjouterFilm.Controls.Add(label3);
            panelAjouterFilm.Controls.Add(label6);
            panelAjouterFilm.Controls.Add(hourAjoutFilm);
            panelAjouterFilm.Location = new Point(666, 103);
            panelAjouterFilm.Name = "panelAjouterFilm";
            panelAjouterFilm.Size = new Size(591, 660);
            panelAjouterFilm.TabIndex = 23;
            // 
            // panelModifierFilm
            // 
            panelModifierFilm.BorderStyle = BorderStyle.Fixed3D;
            panelModifierFilm.Controls.Add(label9);
            panelModifierFilm.Controls.Add(label10);
            panelModifierFilm.Controls.Add(textTitreModifFilm);
            panelModifierFilm.Controls.Add(button1);
            panelModifierFilm.Controls.Add(secondModifFilm);
            panelModifierFilm.Controls.Add(pictureBox1);
            panelModifierFilm.Controls.Add(label11);
            panelModifierFilm.Controls.Add(button2);
            panelModifierFilm.Controls.Add(label12);
            panelModifierFilm.Controls.Add(richTextBox2);
            panelModifierFilm.Controls.Add(label13);
            panelModifierFilm.Controls.Add(label14);
            panelModifierFilm.Controls.Add(minuteModifFilm);
            panelModifierFilm.Controls.Add(textYearModifFilm);
            panelModifierFilm.Controls.Add(label15);
            panelModifierFilm.Controls.Add(label16);
            panelModifierFilm.Controls.Add(hourModifFilm);
            panelModifierFilm.Location = new Point(682, 87);
            panelModifierFilm.Name = "panelModifierFilm";
            panelModifierFilm.Size = new Size(591, 660);
            panelModifierFilm.TabIndex = 24;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(31, 27);
            label9.Name = "label9";
            label9.Size = new Size(75, 15);
            label9.TabIndex = 4;
            label9.Text = "Entrez le titre";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 8F);
            label10.Location = new Point(275, 518);
            label10.Name = "label10";
            label10.Size = new Size(87, 13);
            label10.TabIndex = 22;
            label10.Text = "Previsualisation";
            // 
            // textTitreModifFilm
            // 
            textTitreModifFilm.Location = new Point(127, 27);
            textTitreModifFilm.Name = "textTitreModifFilm";
            textTitreModifFilm.Size = new Size(165, 23);
            textTitreModifFilm.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(229, 596);
            button1.Name = "button1";
            button1.Size = new Size(116, 48);
            button1.TabIndex = 15;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            // 
            // secondModifFilm
            // 
            secondModifFilm.Location = new Point(519, 142);
            secondModifFilm.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            secondModifFilm.Name = "secondModifFilm";
            secondModifFilm.Size = new Size(61, 23);
            secondModifFilm.TabIndex = 19;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.AppWorkspace;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(212, 361);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(214, 154);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(456, 144);
            label11.Name = "label11";
            label11.Size = new Size(57, 15);
            label11.TabIndex = 21;
            label11.Text = "Secondes";
            // 
            // button2
            // 
            button2.Location = new Point(40, 407);
            button2.Name = "button2";
            button2.Size = new Size(104, 23);
            button2.TabIndex = 12;
            button2.Text = "Choisir Image";
            button2.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(31, 76);
            label12.Name = "label12";
            label12.Size = new Size(154, 15);
            label12.TabIndex = 7;
            label12.Text = "Entrez l'annee de la creation";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(169, 208);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(320, 133);
            richTextBox2.TabIndex = 10;
            richTextBox2.Text = "";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(31, 211);
            label13.Name = "label13";
            label13.Size = new Size(113, 15);
            label13.TabIndex = 11;
            label13.Text = "Entrez la description";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(312, 144);
            label14.Name = "label14";
            label14.Size = new Size(50, 15);
            label14.TabIndex = 20;
            label14.Text = "Minutes";
            // 
            // minuteModifFilm
            // 
            minuteModifFilm.Location = new Point(381, 144);
            minuteModifFilm.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            minuteModifFilm.Name = "minuteModifFilm";
            minuteModifFilm.Size = new Size(58, 23);
            minuteModifFilm.TabIndex = 18;
            // 
            // textYearModifFilm
            // 
            textYearModifFilm.Location = new Point(229, 76);
            textYearModifFilm.Name = "textYearModifFilm";
            textYearModifFilm.Size = new Size(63, 23);
            textYearModifFilm.TabIndex = 6;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(31, 144);
            label15.Name = "label15";
            label15.Size = new Size(84, 15);
            label15.TabIndex = 8;
            label15.Text = "Entrez la duree";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(169, 144);
            label16.Name = "label16";
            label16.Size = new Size(44, 15);
            label16.TabIndex = 17;
            label16.Text = "Heures";
            // 
            // hourModifFilm
            // 
            hourModifFilm.Location = new Point(229, 144);
            hourModifFilm.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            hourModifFilm.Name = "hourModifFilm";
            hourModifFilm.Size = new Size(58, 23);
            hourModifFilm.TabIndex = 16;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(27, 35);
            label17.Name = "label17";
            label17.Size = new Size(33, 15);
            label17.TabIndex = 25;
            label17.Text = "Titre:";
            // 
            // panelFilm
            // 
            panelFilm.BorderStyle = BorderStyle.Fixed3D;
            panelFilm.Controls.Add(descFilm);
            panelFilm.Controls.Add(imageFilm);
            panelFilm.Controls.Add(label25);
            panelFilm.Controls.Add(label24);
            panelFilm.Controls.Add(timeFilm);
            panelFilm.Controls.Add(label21);
            panelFilm.Controls.Add(yearFilm);
            panelFilm.Controls.Add(label18);
            panelFilm.Controls.Add(titleFilm);
            panelFilm.Controls.Add(label17);
            panelFilm.Location = new Point(51, 448);
            panelFilm.Name = "panelFilm";
            panelFilm.Size = new Size(343, 505);
            panelFilm.TabIndex = 27;
            // 
            // descFilm
            // 
            descFilm.Location = new Point(109, 185);
            descFilm.Name = "descFilm";
            descFilm.Size = new Size(211, 128);
            descFilm.TabIndex = 36;
            descFilm.Text = "";
            // 
            // imageFilm
            // 
            imageFilm.BackColor = SystemColors.AppWorkspace;
            imageFilm.BorderStyle = BorderStyle.Fixed3D;
            imageFilm.Location = new Point(109, 333);
            imageFilm.Name = "imageFilm";
            imageFilm.Size = new Size(214, 154);
            imageFilm.SizeMode = PictureBoxSizeMode.StretchImage;
            imageFilm.TabIndex = 35;
            imageFilm.TabStop = false;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(31, 389);
            label25.Name = "label25";
            label25.Size = new Size(43, 15);
            label25.TabIndex = 34;
            label25.Text = "Poster:";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(27, 194);
            label24.Name = "label24";
            label24.Size = new Size(70, 15);
            label24.TabIndex = 33;
            label24.Text = "Description:";
            // 
            // timeFilm
            // 
            timeFilm.AutoSize = true;
            timeFilm.Location = new Point(91, 142);
            timeFilm.Name = "timeFilm";
            timeFilm.Size = new Size(37, 15);
            timeFilm.TabIndex = 31;
            timeFilm.Text = "duree";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(27, 142);
            label21.Name = "label21";
            label21.Size = new Size(41, 15);
            label21.TabIndex = 30;
            label21.Text = "Duree:";
            // 
            // yearFilm
            // 
            yearFilm.AutoSize = true;
            yearFilm.Location = new Point(89, 88);
            yearFilm.Name = "yearFilm";
            yearFilm.Size = new Size(39, 15);
            yearFilm.TabIndex = 29;
            yearFilm.Text = "annee";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(27, 88);
            label18.Name = "label18";
            label18.Size = new Size(44, 15);
            label18.TabIndex = 28;
            label18.Text = "Annee:";
            // 
            // titleFilm
            // 
            titleFilm.AutoSize = true;
            titleFilm.Location = new Point(89, 35);
            titleFilm.Name = "titleFilm";
            titleFilm.Size = new Size(28, 15);
            titleFilm.TabIndex = 27;
            titleFilm.Text = "titre";
            // 
            // mySqlCommandBuilder1
            // 
            mySqlCommandBuilder1.DataAdapter = null;
            mySqlCommandBuilder1.QuotePrefix = "`";
            mySqlCommandBuilder1.QuoteSuffix = "`";
            // 
            // FenetreFilms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1341, 1061);
            Controls.Add(panelFilm);
            Controls.Add(panelModifierFilm);
            Controls.Add(panelAjouterFilm);
            Controls.Add(SupprimerFilm);
            Controls.Add(ModifierFilm);
            Controls.Add(AjouterFilm);
            Controls.Add(tableFilms);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FenetreFilms";
            Text = "FenetreFilms";
            Load += FenetreFilms_Load;
            ((System.ComponentModel.ISupportInitialize)tableFilms).EndInit();
            ((System.ComponentModel.ISupportInitialize)filmBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)hourAjoutFilm).EndInit();
            ((System.ComponentModel.ISupportInitialize)minAjoutFilm).EndInit();
            ((System.ComponentModel.ISupportInitialize)secAjoutFilm).EndInit();
            ((System.ComponentModel.ISupportInitialize)filmBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)filmBindingSource2).EndInit();
            panelAjouterFilm.ResumeLayout(false);
            panelAjouterFilm.PerformLayout();
            panelModifierFilm.ResumeLayout(false);
            panelModifierFilm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)secondModifFilm).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)minuteModifFilm).EndInit();
            ((System.ComponentModel.ISupportInitialize)hourModifFilm).EndInit();
            panelFilm.ResumeLayout(false);
            panelFilm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imageFilm).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView tableFilms;
        private Button AjouterFilm;
        private Button ModifierFilm;
        private Button SupprimerFilm;
        private BindingSource filmBindingSource;
        private Label label1;
        private TextBox textTitreFilmAjouter;
        private TextBox textYearFilmAjouter;
        private Label label2;
        private Label label3;
        private RichTextBox descAjoutFilm;
        private Label label4;
        private Button insererImage;
        private PictureBox pictureBox;
        private Button validerAjouterFilme;
        private NumericUpDown hourAjoutFilm;
        private Label label6;
        private NumericUpDown minAjoutFilm;
        private NumericUpDown secAjoutFilm;
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
        private Panel panelModifierFilm;
        private Label label9;
        private Label label10;
        private TextBox textTitreModifFilm;
        private Button button1;
        private NumericUpDown secondModifFilm;
        private PictureBox pictureBox1;
        private Label label11;
        private Button button2;
        private Label label12;
        private RichTextBox richTextBox2;
        private Label label13;
        private Label label14;
        private NumericUpDown minuteModifFilm;
        private TextBox textYearModifFilm;
        private Label label15;
        private Label label16;
        private NumericUpDown hourModifFilm;
        private Label label17;
        private Panel panelFilm;
        private Label titleFilm;
        private Label label21;
        private Label yearFilm;
        private Label label18;
        private PictureBox imageFilm;
        private Label label25;
        private Label label24;
        private Label timeFilm;
        private MySqlConnector.MySqlCommandBuilder mySqlCommandBuilder1;
        private RichTextBox descFilm;
    }
}