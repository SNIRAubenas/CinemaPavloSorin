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

            textBox2.Text = "Entrer ici le nom de l'acteur";
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de l'ajout de l'acteur : " + ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //methode supprimer
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //modification bouton

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
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string textesaisie = textBox2.Text;
            if (string.IsNullOrEmpty(textesaisie))
            {
                MessageBox.Show("Vous avez saisi" + textesaisie);


            }
        }

        private void tableActeurs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Modifier.Enabled = true;
            this.Supprimer.Enabled = true;
        }
    }
}