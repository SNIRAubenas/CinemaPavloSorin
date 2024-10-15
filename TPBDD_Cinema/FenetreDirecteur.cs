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
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                var film = (Film)selectedItem.Tag;

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
