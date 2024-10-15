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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            dbContext = new DirectorfilmactorContext(); 
        }

        private void FenetreDirecteur_Load(object sender, EventArgs e)
        {
            ChargerElementsDansLalistWiew(); 
        }

        private void ChargerElementsDansLalistWiew()
        {
           
            tableDirecteurs.Items.Clear();
            var films = dbContext.Films.ToList();

            foreach (var film in films)
            {
                ListViewItem item = new ListViewItem(film.Nom);
                item.Tag = film; 
                listView1.Items.Add(item);
            }
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                var film = (Film)selectedItem.Tag;

                DialogResult result = MessageBox.Show($"Êtes-vous sûr de vouloir supprimer le film '{film.Nom}' ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        dbContext.Films.Remove(film);
                        dbContext.SaveChanges();

                        listView1.Items.Remove(selectedItem);
                        MessageBox.Show("Film supprimé avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erreur lors de la suppression : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
