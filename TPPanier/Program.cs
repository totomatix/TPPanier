using TPPanier;

Console.OutputEncoding = System.Text.Encoding.UTF8;

// Articles
Article A1 = new Article(456, "Article 1", 45);
Article A2 = new Article(367, "Article 2", 4);
Article A3 = new Article(7865, "Article 3", 98);
Article A4 = new Article(12, "Article 4", 12);


// Panier 1 :
Panier P1 = new Panier();
// Ajout des articles (cas où les articles ne sont pas déja présents)
Console.WriteLine("Test : ajout articles pas déjà présents :");
P1.AjouterArticle(A1, 3);
P1.AjouterArticle(A2, 4);
P1.AjouterArticle(A3, 2);
P1.AjouterArticle(A4);
// Affichage du panier
P1.Afficher();
// Test ajout articles déjà présent
Console.WriteLine("Test : ajout articles déjà présents :");
P1.AjouterArticle(A3, 2);
P1.AjouterArticle(A4);
// Affichage du panier
P1.Afficher();
// test nombres articles différents
Console.WriteLine("Nombre d'articles différents : " + P1.NombreArticlesDifferents());
// test nombres articles 
Console.WriteLine("Nombre d'articles : " + P1.NombreArticles());
// test total panier
Console.WriteLine("Total panier : " + P1.Total());
// test suppression article présent
Console.WriteLine("test suppression Article 1");
P1.SupprimerArticle(A1);
P1.Afficher();
// test suppression article absent
Console.WriteLine("test REsuppression Article 1");
P1.SupprimerArticle(A1);
P1.Afficher();
// test vider panier
Console.WriteLine("test vider panier");
P1.ViderPanier();
P1.Afficher();







