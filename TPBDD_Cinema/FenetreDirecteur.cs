using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPBDD_Cinema.Models;

namespace TPBDD_Cinema
{
    public partial class FenetreDirecteur : Form
    {
        DirectorfilmactorContext dbContext;

        public FenetreDirecteur()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.labelDirecteur.Visible = false;
            this.textBoxDirecteur.Visible = false;
            this.ajouterButtonDirecteur.Visible = false;
        }

        private void FenetreDirecteur_Load(object sender, EventArgs e)
        {
            dbContext = new DirectorfilmactorContext();
            if (dbContext.Database.CanConnect())
            {
                dbContext.Directors.Load();
                directorBindingSource.DataSource = dbContext.Directors.Local.ToBindingList();
            }
            else
            {
                MessageBox.Show($"Erreur de chargement de la base de donnée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            if (tableDirecteurs.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = tableDirecteurs.SelectedRows[0];
                var director = (Director)selectedRow.DataBoundItem; 


                DialogResult result = MessageBox.Show($"Êtes-vous sûr de vouloir supprimer le réalisateur '{director.Name}' ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {

                        dbContext.Directors.Remove(director);
                        dbContext.SaveChanges();


                        dbContext.Directors.Load();
                        directorBindingSource.DataSource = dbContext.Directors.Local.ToBindingList();

                        MessageBox.Show("Réalisateur supprimé avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erreur lors de la suppression : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un réalisateur à supprimer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void Ajouter_Click(object sender, EventArgs e)
        {
            Ajouter.Enabled = true;
            this.labelDirecteur.Visible = true;
            this.textBoxDirecteur.Visible = true;
            this.ajouterButtonDirecteur.Visible = true;
            this.ajouterButtonDirecteur.Enabled = false;
        }

        private void ajouterButtonDirecteur_Click(object sender, EventArgs e)
        {
            string nom = textBoxDirecteur.Text;
            Director director = new Director();
            director.Name = nom;
            dbContext.Directors.Add(director);
            dbContext.SaveChanges();
            dbContext.Directors.Load();

            if (tableDirecteurs.SelectedRows.Count > 0)
            {
                tableDirecteurs.SelectedRows[0].Selected = false;
            }

            this.labelDirecteur.Visible = false;
            this.textBoxDirecteur.Visible = false;
            this.textBoxDirecteur.Text = "";
            this.ajouterButtonDirecteur.Visible = false;
            this.Ajouter.Enabled = true;
        }

        private void textBoxDirecteur_TextChanged(object sender, EventArgs e)
        {
            if (textBoxDirecteur.Text.Length > 0)
            {
                this.ajouterButtonDirecteur.Enabled = true;
            }
            else
            {
                this.ajouterButtonDirecteur.Enabled = false;
            }
        }

        private void Modifier_Click(object sender, EventArgs e)
        {

        }

        private void buttonModifDir_Click(object sender, EventArgs e)
        {

            

        }

        private void textBoxModifDir_TextChanged(object sender, EventArgs e)
        {
            if (textBoxModifDir.Text.Length > 0)
            {
                this.buttonModifDir.Enabled = true;
            } else
            {
                this.buttonModifDir.Enabled = false;
            }
        }
    }
}
