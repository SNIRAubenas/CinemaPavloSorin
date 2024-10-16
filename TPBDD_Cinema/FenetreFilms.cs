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
                MessageBox.Show($"Erreur de chargement de la base de donnée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void AjouterFilm_Click(object sender, EventArgs e)
        {
            string titre = textBox1.Text;
            int annee = (int)numericUpDown2.Value; 
            TimeSpan longueur = TimeSpan.FromMinutes((int)numericUpDown1.Value); 
            string resume = richTextBox1.Text;

            
            if (string.IsNullOrWhiteSpace(titre) || pictureBox.Image == null)
            {
                MessageBox.Show("Veuillez remplir tous les champs obligatoires et sélectionner une image.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                
                textBox1.Clear();
                numericUpDown1.Value = 0;
                numericUpDown2.Value = 0;
                richTextBox1.Clear();
                pictureBox.Image = null; 

                MessageBox.Show("Film ajouté avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'ajout du film : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FenetreFilms_Load(object sender, EventArgs e)
        {
            dbContext = new DirectorfilmactorContext();
            
        }

        
    }
}
