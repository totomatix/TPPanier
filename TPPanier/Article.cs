using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPPanier
{
    public class Article : IComparable
    {
        public Article(int reference, string designation, decimal prix)
        {
            Reference = reference;
            Designation = designation;
            Prix = prix;
        }

        public int Reference { get; private set; }
        public string Designation { get; set; }
        public decimal Prix { get; set; }

        public int CompareTo(object? obj)
        {
            if (obj is Article article)
            {
                return Reference.CompareTo(article.Reference);
            }
            else
            {
                return 100;
            }
        }

        public override bool Equals(object? obj)
        {
            return obj is Article article &&
                   Reference == article.Reference;
        }

        public override string? ToString()
        {
            return $"Designation : {Designation}, Prix: {Prix}€, Ref : {Reference}";
        }


    }
}
