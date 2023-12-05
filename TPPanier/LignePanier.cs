using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPPanier
{
    public class LignePanier
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
