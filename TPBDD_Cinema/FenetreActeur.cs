using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using TPBDD_Cinema.Models;

namespace TPBDD_Cinema
{
    public partial class FenetreActeur : Form
    {
        DirectorfilmactorContext dbContext;

        public FenetreActeur()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Modifier.Enabled = false;
            this.Ajouter.Enabled = true;
            this.Supprimer.Enabled = false;
            this.textBoxNom.Visible = false;
            this.labelNom.Visible = false;
            this.okModifier.Visible = false;
        }

        private void FenetreActeur_Load(object sender, EventArgs e)
        {
            dbContext = new DirectorfilmactorContext();
            if (dbContext.Database.CanConnect())
            {
                dbContext.Actors.Load();
                actorBindingSource.DataSource = dbContext.Actors.Local.ToBindingList();
            }
            else
            {
                MessageBox.Show($"Erreur de chargement de la base de donnée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            textBox2.Text = "Entrer ici le nom de l'acteur";

            
            if (tableActeurs.Rows.Count > 0)
            {
                tableActeurs.Rows[0].Selected = true; 
                tableActeurs_CellClick(null, new DataGridViewCellEventArgs(0, 0));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nom = textBox2.Text;
            if (string.IsNullOrEmpty(nom) || nom == "Entrer ici le nom de l'acteur")
            {
                MessageBox.Show("Veuillez entrer un nom d'acteur.");
                return;
            }

            using (var context = new DirectorfilmactorContext())
            {
                var acteur = new Actor
                {
                    Name = nom,
                };

                context.Actors.Add(acteur);

                try
                {
                    context.SaveChanges();
                    MessageBox.Show("Acteur ajouté avec succès.");
                    textBox2.Clear();
                    ReloadActors();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de l'ajout de l'acteur : " + ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tableActeurs.SelectedRows.Count > 0)
            {
                DialogResult resultat = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet acteur ?",
                                                "Confirmation de suppression",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Warning);
                if (resultat == DialogResult.Yes)
                {
                    int actorId = (int)tableActeurs.SelectedRows[0].Cells[0].Value;

                    var acteurASupprimer = dbContext.Actors.Find(actorId);
                    if (acteurASupprimer != null)
                    {
                        dbContext.Actors.Remove(acteurASupprimer);

                        try
                        {
                            dbContext.SaveChanges();
                            MessageBox.Show("Acteur supprimé avec succès.");
                            ReloadActors();
                            this.Modifier.Enabled = false;
                            this.Supprimer.Enabled = false;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erreur lors de la suppression de l'acteur : " + ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Acteur non trouvé.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un acteur à supprimer.");
            }
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            this.textBoxNom.Visible = true;
            this.labelNom.Visible = true;
            this.okModifier.Visible = true;
            this.okModifier.Enabled = false;
        }

        private void okModifier_Click(object sender, EventArgs e)
        {
            String nouveauNom = this.textBoxNom.Text;
            Actor actorAModifier = dbContext.Actors.Find(tableActeurs.SelectedRows[0].Cells[0].Value);
            if (actorAModifier != null)
            {
                actorAModifier.Name = nouveauNom;
                try
                {
                    dbContext.SaveChanges();
                    MessageBox.Show("Acteur modifié avec succès.");
                    ReloadActors();
                    tableActeurs.ClearSelection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la modification de l'acteur : " + ex.Message);
                }
            }
        }

        private void textBoxNom_TextChanged(object sender, EventArgs e)
        {
            this.okModifier.Enabled = !string.IsNullOrEmpty(this.textBoxNom.Text); 
        }

        private void tableActeurs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.Modifier.Enabled = true; 
                this.Supprimer.Enabled = true; 
            }
        }

        private void ReloadActors()
        {
            dbContext.Actors.Load();
            actorBindingSource.DataSource = dbContext.Actors.Local.ToBindingList(); // Maj la table
        }
    }
}
