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
        public FenetreActeur()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void FenetreActeur_Load(object sender, EventArgs e)
        {
            
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string textesaisie=textBox2.Text;
            if (string.IsNullOrEmpty(textesaisie) )
            {
                MessageBox.Show("Vous avez saisi" + textesaisie);


            }

        }
    }
}
