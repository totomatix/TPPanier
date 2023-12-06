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
            foreach (LignePanier ligne in Lignes)
            {
                if (ligne.Article.Equals(article))
                {
                    ligne.Quantite += quantite;
                    return; // on sort de la méthode car on a pas besoin de faire quoi que ce soit d'autres
                }
            }
            // 2eme cas : l'article n'est pas présent dans la liste
            // => création d'une ligne panier et ajout de cette dernière à la liste
            LignePanier NewLigne = new LignePanier(article, quantite);
            Lignes.Add(NewLigne);
        }

        public decimal Total()
        {
            // parcourir la liste de lignes et ajouter le montant de chacune d'entre elles
            decimal Total = 0;
            foreach (LignePanier ligne in Lignes)
            {
                Total += ligne.Montant();
            }
            return Total;
        }

        public int NombreArticles()
        {
            // parcourir la liste de ligne et ajouter les quantite
            int Somme = 0;
            foreach (LignePanier ligne in Lignes)
            {
                Somme += ligne.Quantite;
            }
            return Somme;
        }

        public int NombreArticlesDifferents()
        {
            // renvoyer le nombre de lignePanier
            return Lignes.Count;
        }

        public void Afficher()
        {
            // trier la liste
            Lignes.Sort();
            // afficher les lignes une par une
            foreach (LignePanier ligne in Lignes)
            {
                Console.WriteLine(ligne);
            }
        }

        public void SupprimerArticle(Article article)
        {
            // supprimer la lignePanier correspondante à l'article passé en paramètre
            LignePanier ligneASupprimer = null;
            foreach (LignePanier ligne in Lignes)
            {
                if (ligne.Article.Equals(article))
                {
                    ligneASupprimer = ligne;
                    break;
                }
            }
            if (ligneASupprimer != null)
            {
                Lignes.Remove(ligneASupprimer); 
            }
            // si l'article nest pas présent => ne rien faire
        }

        public void ViderPanier()
        {
            // vider la liste
            Lignes.Clear();
        }
    }
}
