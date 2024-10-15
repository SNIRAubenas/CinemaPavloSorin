using TPBDD_Cinema.Models;

namespace TPBDD_Cinema
{
    public partial class fenetrePrincipale : Form
    {
        DirectorfilmactorContext dbContext;

        public fenetrePrincipale()
        {
            InitializeComponent();
        }

        private void GestionActors_Click(object sender, EventArgs e)
        {
            FenetreActeur fenetreActeur = new FenetreActeur();
            fenetreActeur.ShowDialog();
        }

        private void GestionFilms_Click(object sender, EventArgs e)
        {
            FenetreFilms fenetreFilms = new FenetreFilms();
            fenetreFilms.ShowDialog();
        }

        private void GestionDirectors_Click(object sender, EventArgs e)
        {
            FenetreDirecteur fenetreDirecteur = new FenetreDirecteur();
            fenetreDirecteur.ShowDialog();
        }
    }
}
