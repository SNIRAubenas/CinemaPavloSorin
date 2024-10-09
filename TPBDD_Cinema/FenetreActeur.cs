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
            this.Modifier.Enabled = true;
            this.ajouterButton.Enabled = true;
            this.Supprimer.Enabled = true;
            this.textBoxNom.Visible = false;
            this.labelNom.Visible = false;
            this.okModifier.Visible = false;
            this.ajouterTextBox.Visible = false;
            this.ajouterLabel.Visible = false;
            this.ajouterActeurButton.Visible = false;
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
        }

        private void ajouterButton_Click(object sender, EventArgs e)
        {
            this.ajouterLabel.Visible = true;
            this.ajouterTextBox.Visible = true;
            this.ajouterActeurButton.Visible = true;
            this.ajouterButton.Enabled = false;
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
            this.Modifier.Enabled = false;
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
            this.Modifier.Enabled = false;
            this.Supprimer.Enabled = false;
            this.textBoxNom.Visible = false;
            this.textBoxNom.Text = "";
            this.labelNom.Visible = false;
            this.okModifier.Visible = false;

        }

        private void textBoxNom_TextChanged(object sender, EventArgs e)
        {
            if (this.textBoxNom.Text.Length > 0)
            {
                this.okModifier.Enabled = true;

            }
        }

        private void tableActeurs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Modifier.Enabled = true;
            this.Supprimer.Enabled = true;
        }

        private void ajouterActeurButton_Click(object sender, EventArgs e)
        {
            string nom = ajouterTextBox.Text;
            Actor actor = new Actor();
            actor.Name = nom;
            dbContext.Actors.Add(actor);
            dbContext.SaveChanges();
            dbContext.Actors.Load();
            if (tableActeurs.SelectedRows.Count > 0)
            {
                tableActeurs.SelectedRows[0].Selected = false;
            }
            this.ajouterLabel.Visible = false;
            this.ajouterTextBox.Visible = false;
            this.ajouterTextBox.Text = "";
            this.ajouterActeurButton.Visible = false;
            this.ajouterButton.Enabled = true;
        }

        private void ajouterTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ajouterTextBox.Text.Length > 0)
            {
                this.ajouterActeurButton.Enabled = true;
            }
        }
    }
}
