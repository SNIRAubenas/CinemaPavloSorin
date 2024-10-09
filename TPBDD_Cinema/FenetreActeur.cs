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
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

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
                dbContext.SaveChanges();
                dbContext.Actors.Load();
                tableActeurs.SelectedRows[0].Selected = false;
            }
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
    }
}