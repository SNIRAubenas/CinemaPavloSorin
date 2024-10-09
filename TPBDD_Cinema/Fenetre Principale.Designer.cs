namespace TPBDD_Cinema
{
    partial class fenetrePrincipale
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fenetrePrincipale));
            GestionActors = new Button();
            GestionFilms = new Button();
            GestionDirectors = new Button();
            SuspendLayout();
            // 
            // GestionActors
            // 
            GestionActors.Location = new Point(115, 271);
            GestionActors.Name = "GestionActors";
            GestionActors.Size = new Size(122, 23);
            GestionActors.TabIndex = 0;
            GestionActors.Text = "Gestion Actors";
            GestionActors.UseVisualStyleBackColor = true;
            GestionActors.Click += GestionActors_Click;
            // 
            // GestionFilms
            // 
            GestionFilms.Location = new Point(115, 342);
            GestionFilms.Name = "GestionFilms";
            GestionFilms.Size = new Size(121, 23);
            GestionFilms.TabIndex = 1;
            GestionFilms.Text = "Gestion Films";
            GestionFilms.UseVisualStyleBackColor = true;
            GestionFilms.Click += GestionFilms_Click;
            // 
            // GestionDirectors
            // 
            GestionDirectors.Location = new Point(115, 412);
            GestionDirectors.Name = "GestionDirectors";
            GestionDirectors.Size = new Size(121, 23);
            GestionDirectors.TabIndex = 2;
            GestionDirectors.Text = "Gestion Directors";
            GestionDirectors.UseVisualStyleBackColor = true;
            GestionDirectors.Click += GestionDirectors_Click;
            // 
            // fenetrePrincipale
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(349, 608);
            Controls.Add(GestionDirectors);
            Controls.Add(GestionFilms);
            Controls.Add(GestionActors);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "fenetrePrincipale";
            Text = "Fenetre Principale";
            ResumeLayout(false);
        }

        #endregion

        private Button GestionActors;
        private Button GestionFilms;
        private Button GestionDirectors;
    }
}
