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

        private void AjouterFilm_Click(object sender, EventArgs e)
        {

            panelAjouterFilm.Visible = !panelAjouterFilm.Visible;
        }


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


                textBox1.Clear();
                numericUpDown1.Value = 0;
                numericUpDown2.Value = 0;
                richTextBox1.Clear();
                pictureBox.Image = null;
                panelAjouterFilm.Visible = false;


                dbContext.Films.Load();
                dataGridView1.DataSource = dbContext.Films.Local.ToBindingList();
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

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) 
            {
                
                int filmId = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
               

                DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer ce film ?",
                                                      "Confirmation", MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        
                        Film filmASupprimer = dbContext.Films.FirstOrDefault(f => f.Id == filmId);

                        if (filmASupprimer != null)
                        {
                            
                            dbContext.Films.Remove(filmASupprimer);
                            dbContext.SaveChanges();

                            
                            dbContext.Films.Load();
                            dataGridView1.DataSource = dbContext.Films.Local.ToBindingList();

                            MessageBox.Show("Film supprimé avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erreur lors de la suppression du film : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un film à supprimer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
    }

