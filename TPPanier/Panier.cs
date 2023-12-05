using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPPanier
{
    public class Panier
    {
        public int Numero { get; private set; }
        public DateTime DateCreation { get; private set; } = DateTime.Now;
        private List<LignePanier> Lignes { get; set; } = new List<LignePanier>();

        private static int CompteurPaniers {get;set;}

        public Panier()
        {
            CompteurPaniers++;
            Numero = CompteurPaniers;
        }

        public void AjouterArticle(Article article, int quantite = 1)
        {
            // 2 cas

            // 1er cas : l'article est déja présent dans le panier 
            // => on cumule les quantité

            // 2eme cas : l'article n'est pas présent dans la liste
            // => création d'une ligne panier et ajout de cette dernière à la liste
        }

        public decimal Total()
        {
            // parcourir la liste de lignes et ajouter le montant de chacune d'entre elles
        }

        public int NombreArticles()
        {
            // parcourir la liste de ligne et ajouter les quantite
        }

        public int NombreArticlesDifferents()
        {
            // renvoyer le nombre de lignePanier
        }

        public void Afficher()
        {
            // trier la liste
            // afficher les lignes une par une
        }

        public void SupprimerArticle(Article article)
        {
            // supprimer la lignePanier correspondante à l'article passé en paramètre

            // si l'article nest pas présent => ne rien faire
        }

        public void ViderPanier()
        {
            // vider la liste
        }
    }
}
