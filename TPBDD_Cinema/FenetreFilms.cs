using Microsoft.EntityFrameworkCore;
using System;
using System.Drawing;
using System.Windows.Forms;
using TPBDD_Cinema.Models;

namespace TPBDD_Cinema
{
    public partial class FenetreFilms : Form
    {
        DirectorfilmactorContext dbContext;

        public FenetreFilms()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            dbContext = new DirectorfilmactorContext();

            // Au début, le panel est caché
            panelAjouterFilm.Visible = false;
        }

        private void FenetreFilms_Load(object sender, EventArgs e)
        {
            dbContext = new DirectorfilmactorContext();
            if (dbContext.Database.CanConnect())
            {
                dbContext.Films.Load();
                filmBindingSource.DataSource = dbContext.Films.Local.ToBindingList();
            }
            else
            {
                MessageBox.Show("Erreur de connexion à la base de données", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Bouton Ajouter pour rendre visible/invisible le panel d'ajout de film
        private void AjouterFilm_Click(object sender, EventArgs e)
        {
            // Inverse l'état de visibilité du panel à chaque clic
            panelAjouterFilm.Visible = !panelAjouterFilm.Visible;
        }

        // Bouton OK pour ajouter le film dans la base de données
        private void OkButton_Click(object sender, EventArgs e)
        {
            string titre = textBox1.Text;
            int annee = (int)numericUpDown2.Value;
            TimeSpan longueur = TimeSpan.FromMinutes((int)numericUpDown1.Value);
            string resume = richTextBox1.Text;

            if (string.IsNullOrWhiteSpace(titre) || pictureBox.Image == null)
            {
                MessageBox.Show("Veuillez remplir tous les champs et sélectionner une image.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                byte[] imageBytes;
                using (var ms = new System.IO.MemoryStream())
                {
                    pictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    imageBytes = ms.ToArray();
                }

                Film nouveauFilm = new Film
                {
                    Title = titre,
                    Year = annee,
                    Length = longueur,
                    Summary = resume,
                    Poster = imageBytes
                };

                dbContext.Films.Add(nouveauFilm);
                dbContext.SaveChanges();

                MessageBox.Show("Film ajouté avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Réinitialiser les champs et cacher le panel après ajout
                textBox1.Clear();
                numericUpDown1.Value = 0;
                numericUpDown2.Value = 0;
                richTextBox1.Clear();
                pictureBox.Image = null;
                panelAjouterFilm.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'ajout du film : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void insererImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox.Image = Image.FromFile(openFileDialog.FileName);
                }
                else
                {
                    MessageBox.Show("Aucune image sélectionnée.");
                }
            }
        }
    }
}
