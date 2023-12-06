using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPPanier
{
    public class LignePanier : IComparable
    {
        public LignePanier(Article article)
        {
            Article = article;
            Quantite = 1;
        }

        public LignePanier(Article article, int quantite)
        {
            Article = article;
            Quantite = quantite;
        }

        public Article Article { get; private set; }
        public int Quantite { get; set; }

        public int CompareTo(object? obj)
        {
            if (obj is LignePanier ligne)
            {
                // comparer 2 lignePanier revient à comparer leur article
                return this.Article.CompareTo(ligne.Article);
            }
            else
            {
                return 100;
            }
        }

        public decimal Montant()
        {
            return Quantite * Article.Prix;
        }

        public override string? ToString()
        {
            return Article + $" Quantite : {Quantite}, Montant : {Montant()}";
        }
    }
}
