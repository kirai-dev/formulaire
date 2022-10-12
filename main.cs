
using System;


  class Program
  {
    static void Main(string[] args)
    {

string name;


        Console.WriteLine("Quel est ton nom?");    
       string firstName = Console.ReadLine();
        


          Console.WriteLine("Quel est ton nom de famille?");    
       string lastName = Console.ReadLine();
      
name = char.ToUpper(firstName[0]) + firstName.Substring(1) + " " + char.ToUpper(lastName[0]) + lastName.Substring(1);

      Console.WriteLine("Ton nom est " + name);
      Console.WriteLine("Voulez vous continuer le formulaire? Dites oui ou non...");
      string continuer = Console.ReadLine();

      if(continuer.Contains("oui")) {


Console.WriteLine("Quel age avez vous?");
string age = Console.ReadLine();

Console.WriteLine("Quel est votre origine?");
string or = Console.ReadLine();
Console.WriteLine("Vous habitez dans quel pays actuellement?");
string nat = Console.ReadLine();

Console.WriteLine("Etes-vous celibataire?");
string celibataire = Console.ReadLine();
if(celibataire.Contains("oui")) {
  celibataire = "Celibataire";
} else if(celibataire.Contains("non")) {
  celibataire = "En Couple";
}
else {
  celibataire = "Je ne sais pas";
}


Console.WriteLine("Quel est votre passion dans la vie?");
string occupation = Console.ReadLine();

Console.WriteLine("Etes-vous etudiant?");
string student = Console.ReadLine();



Console.WriteLine("Etes-vous employer?");
string work = Console.ReadLine();

if(work.Contains("oui") ){
Console.WriteLine("Quel est votre travaille?");
work = Console.ReadLine();
} else {
  work = "Aucun";
}


Console.Clear();
Console.WriteLine("Information sur vous :");
Console.WriteLine("Nom Complet : " + name);
Console.WriteLine("Initial : " + char.ToUpper(firstName[0]) + (". ") + char.ToUpper(lastName[0]));
Console.WriteLine("Statue : " + celibataire);
Console.WriteLine("Age : " + age + " ans");
Console.WriteLine("Pays : " + char.ToUpper(nat[0]) + nat.Substring(1));
Console.WriteLine("Origine: " + char.ToUpper(or[0]) + or.Substring(1));
Console.WriteLine("Passion : " + char.ToUpper(occupation[0]) + occupation.Substring(1));
Console.WriteLine("Etudiant : " + student);
Console.WriteLine("Travaille : " + char.ToUpper(work[0]) + work.Substring(1));
Console.WriteLine(" ");
Console.WriteLine("Ecrivez n'importe quoi pour quitter...");
Console.ReadLine();

      } else 
      if(continuer.Contains("non")) {
        Console.Clear();
Console.WriteLine("Fermeture du programme");
      } else {
        Console.WriteLine("Incorrect (1)");
          Console.WriteLine("Voulez vous continuer le formulaire? Dites oui ou non...");
           continuer = Console.ReadLine();
                 if(continuer.Contains("oui")) {

Console.WriteLine("Quel age avez vous?");
string age = Console.ReadLine();

Console.WriteLine("Quel est votre origine?");
string or = Console.ReadLine();
Console.WriteLine("Vous habitez dans quel pays actuellement?");
string nat = Console.ReadLine();

Console.WriteLine("Etes-vous celibataire?");
string celibataire = Console.ReadLine();
if(celibataire.Contains("oui")) {
  celibataire = "Celibataire";
} else if(celibataire.Contains("non")) {
  celibataire = "En Couple";
}
else {
  celibataire = "Je ne sais pas";
}


Console.WriteLine("Quel est votre passion dans la vie?");
string occupation = Console.ReadLine();

Console.WriteLine("Etes-vous etudiant?");
string student = Console.ReadLine();



Console.WriteLine("Etes-vous employer?");
string work = Console.ReadLine();

if(work.Contains("oui") ){
Console.WriteLine("Quel est votre travaille?");
work = Console.ReadLine();
} else {
  work = "Aucun";
}


Console.Clear();
Console.WriteLine("Information sur vous :");
Console.WriteLine("Nom Complet : " + name);
Console.WriteLine("Initial : " + char.ToUpper(firstName[0]) + (". ") + char.ToUpper(lastName[0]));
Console.WriteLine("Statue : " + celibataire);
Console.WriteLine("Age : " + age + " ans");
Console.WriteLine("Pays : " + char.ToUpper(nat[0]) + nat.Substring(1));
Console.WriteLine("Origine: " + char.ToUpper(or[0]) + or.Substring(1));
Console.WriteLine("Passion : " + char.ToUpper(occupation[0]) + occupation.Substring(1));
Console.WriteLine("Etudiant : " + student);
Console.WriteLine("Travaille : " + char.ToUpper(work[0]) + work.Substring(1));
Console.WriteLine(" ");
Console.WriteLine("Ecrivez n'importe quoi pour quitter...");
Console.ReadLine();


      } else 
      if(continuer.Contains("non")) {
        Console.Clear();
Console.WriteLine("Fermeture du programme");
      } else {
        Console.WriteLine("Incorrect (2)");
            Console.WriteLine("Voulez vous continuer le formulaire? Dites oui ou non...");
           continuer = Console.ReadLine();
      }
      
            if(continuer.Contains("oui")) {

Console.WriteLine("Quel age avez vous?");
string age = Console.ReadLine();

Console.WriteLine("Quel est votre origine?");
string or = Console.ReadLine();
Console.WriteLine("Vous habitez dans quel pays actuellement?");
string nat = Console.ReadLine();

Console.WriteLine("Etes-vous celibataire?");
string celibataire = Console.ReadLine();
if(celibataire.Contains("oui")) {
  celibataire = "Celibataire";
} else if(celibataire.Contains("non")) {
  celibataire = "En Couple";
}
else {
  celibataire = "Je ne sais pas";
}


Console.WriteLine("Quel est votre passion dans la vie?");
string occupation = Console.ReadLine();

Console.WriteLine("Etes-vous etudiant?");
string student = Console.ReadLine();



Console.WriteLine("Etes-vous employer?");
string work = Console.ReadLine();

if(work.Contains("oui") ){
Console.WriteLine("Quel est votre travaille?");
work = Console.ReadLine();
} else {
  work = "Aucun";
}


Console.Clear();

Console.WriteLine("Information sur vous :");
Console.WriteLine("Nom Complet : " + name);
Console.WriteLine("Initial : " + char.ToUpper(firstName[0]) + (". ") + char.ToUpper(lastName[0]));
Console.WriteLine("Statue : " + celibataire);
Console.WriteLine("Age : " + age + " ans");
Console.WriteLine("Pays : " + char.ToUpper(nat[0]) + nat.Substring(1));
Console.WriteLine("Origine: " + char.ToUpper(or[0]) + or.Substring(1));
Console.WriteLine("Passion : " + char.ToUpper(occupation[0]) + occupation.Substring(1));
Console.WriteLine("Etudiant : " + student);
Console.WriteLine("Travaille : " + char.ToUpper(work[0]) + work.Substring(1));
Console.WriteLine(" ");
Console.WriteLine("Ecrivez n'importe quoi pour quitter...");
Console.ReadLine();



      } else 
      if(continuer.Contains("non")) {
        Console.Clear();
Console.WriteLine("Fermeture du programme");
      } else {
        Console.WriteLine("Incorrect (3)");
            Console.Clear();
          Console.WriteLine("Veuillez reesayer plus tard !");
         
      }
      
      
      
      
      
      
        }
      
      
      
      
        }
      }
      
      
      
      
      
      
  