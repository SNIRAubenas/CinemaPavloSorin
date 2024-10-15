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
            this.labelModifDirecteur.Visible = false;
            this.textBoxModifDir.Visible = false;
            this.buttonModifDir.Visible = false;
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

        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            this.Ajouter.Enabled = false;
            this.Modifier.Enabled = false;
            this.Supprimer.Enabled = false;
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
            this.textBoxModifDir.Visible = true;
            this.labelModifDirecteur.Visible = true;
            this.buttonModifDir.Visible = true;
            this.buttonModifDir.Enabled = false;
            this.Modifier.Enabled = false;
            this.Ajouter.Enabled = false;
            this.Supprimer.Enabled = false;
        }

        private void buttonModifDir_Click(object sender, EventArgs e)
        {
            String nouveauNom = this.textBoxModifDir.Text;
            Director directeurAModifier = dbContext.Directors.Find(tableDirecteurs.SelectedRows[0].Cells[0].Value);
            if (directeurAModifier != null)
            {
                directeurAModifier.Name = nouveauNom;
                try
                {
                    dbContext.SaveChanges();
                    MessageBox.Show("Acteur modifié avec succès.");

                    tableDirecteurs.ClearSelection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la modification de l'acteur : " + ex.Message);
                }
            }
            this.Ajouter.Enabled = true;
            this.Modifier.Enabled = true;
            this.Supprimer.Enabled = true;
            this.textBoxModifDir.Visible = false;
            this.textBoxModifDir.Text = "";
            this.labelModifDirecteur.Visible = false;
            this.buttonModifDir.Visible = false;
        }

        private void textBoxModifDir_TextChanged(object sender, EventArgs e)
        {
            if (textBoxModifDir.Text.Length > 0)
            {
                this.buttonModifDir.Enabled = true;
            }
            else
            {
                this.buttonModifDir.Enabled = false;
            }
        }

        private void tableDirecteurs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Modifier.Enabled = true;
            this.Supprimer.Enabled = true;
        }
    }
}
