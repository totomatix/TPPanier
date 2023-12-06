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
        //private List<LignePanier> Lignes { get; set; } = new List<LignePanier>();
        private SortedDictionary<Article, LignePanier> Lignes = new SortedDictionary<Article, LignePanier>();

        private static int CompteurPaniers { get; set; }

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

            if (Lignes.ContainsKey(article))
            {
                Lignes[article].Quantite += quantite;
                return; // on sort de la méthode car on a pas besoin de faire quoi que ce soit d'autres
            }

            // 2eme cas : l'article n'est pas présent dans la liste
            // => création d'une ligne panier et ajout de cette dernière à la liste
            Lignes.Add(article, new LignePanier(article, quantite));
        }

        public decimal Total()
        {
            // parcourir la liste de lignes et ajouter le montant de chacune d'entre elles
            decimal Total = 0;
            foreach (LignePanier ligne in Lignes.Values)
            {
                Total += ligne.Montant();
            }
            return Total;
        }

        public int NombreArticles()
        {
            // parcourir la liste de ligne et ajouter les quantite
            int Somme = 0;
            foreach (KeyValuePair<Article,LignePanier> kvp in Lignes)
            {
                Somme += kvp.Value.Quantite;
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
            // afficher les lignes une par une
            foreach (KeyValuePair<Article, LignePanier> kvp in Lignes)
            {
                Console.WriteLine(kvp.Value);
            }
        }

        public void SupprimerArticle(Article article)
        {
            // supprimer la lignePanier correspondante à l'article passé en paramètre
            // si l'article nest pas présent => ne rien faire
            Lignes.Remove(article);
        }

        public void ViderPanier()
        {
            // vider la liste
            Lignes.Clear();
        }
    }
}
