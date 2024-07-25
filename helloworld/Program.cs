using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualBasic.FileIO;
using System.Text.RegularExpressions;
public static class Program
{

    public class Employee
    {
        // TODO : Ajoutez les propriétés nécessaires pour représenter un employé ( Nom, Prenom, Email, DateEntreeEntreprise, TempsTravailHebdomadaire )
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public DateTime DateEntreeEntreprise { get; set; }
        public double TempsTravailHebdomadaire { get; set; }
    }

    public static void Main()
    {
        string CsvPath = "./employees.csv";

        // TODO : Implémenter une fonction pour calculer une factorielle

        // TODO: Lire les employés depuis le fichier CSV et les stocker dans une liste
        List<Employee> employees = ReadEmployeesFromCsv(CsvPath);

        // TODO: Afficher les employés et vérifier si les emails sont valides
        foreach (Employee employee in employees)
        {
            Console.WriteLine($"Nom: {employee.Nom}, Prénom: {employee.Prenom}, Email: {employee.Email}, Date d'entrée: {employee.DateEntreeEntreprise}, Temps de travail hebdomadaire: {employee.TempsTravailHebdomadaire}");
            Console.WriteLine($"Email valide: {IsValidEmail(employee.Email)}");
        }

        // TODO: Trier les employés par date d'entrée dans l'entreprise
        SortEmployeesByDate(ref employees);

        // TODO: Afficher les employés triés par date d'entrée
        foreach (Employee employee in employees)
        {
            Console.WriteLine($"Nom: {employee.Nom}, Prénom: {employee.Prenom}, Email: {employee.Email}, Date d'entrée: {employee.DateEntreeEntreprise}, Temps de travail hebdomadaire: {employee.TempsTravailHebdomadaire}");
        }

        // TODO: Convertir le temps de travail hebdomadaire au format classique et afficher
        foreach (Employee employee in employees)
        {
            Console.WriteLine($"Temps de travail hebdomadaire: {ConvertToClassicFormat(employee.TempsTravailHebdomadaire)}");
        }
    }

    // Fonction pour calculer une factorielle
    private static int Factorial(int n)
    {
        if (n == 1)
        {
            return 1;
        }
        else
        {
            return n * Factorial(n - 1);
        }
    }




    // Fonction pour lire les employés depuis un fichier CSV
    private static List<Employee> ReadEmployeesFromCsv(string csvPath)
    {
        // TODO: Implémentez cette méthode pour lire les données d'employés depuis un fichier CSV et les retourner sous forme de liste d'objets Employee
        // Lis le fichier CSV passer en paramètre de la fonction et retourne une liste d'employés
        if (File.Exists(csvPath))
        {
            List<Employee> employees = new List<Employee>();
            using (TextFieldParser parser = new TextFieldParser(csvPath))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();
                    if (fields.Length == 5)
                    {
                        Employee employee = new Employee();
                        employee.Nom = fields[0];
                        employee.Prenom = fields[1];
                        employee.Email = fields[2];
                        employee.DateEntreeEntreprise = DateTime.Parse(fields[3]);
                        employee.TempsTravailHebdomadaire = double.Parse(fields[4]);
                        employees.Add(employee);
                    }
                }
            }
            return employees;
        }
        return new List<Employee>();
    }

    // Fonction pour trier les employés par date d'entrée dans l'entreprise
    private static void SortEmployeesByDate(ref List<Employee> employees)
    {
        // TODO: Implémentez cette méthode pour trier la liste des employés par leur date d'entrée dans l'entreprise
        employees.Sort((x, y) => x.DateEntreeEntreprise.CompareTo(y.DateEntreeEntreprise));
    }

    // Fonction pour convertir le temps de travail hebdomadaire au format classique (hh:mm)
    private static string ConvertToClassicFormat(double tempsTravailHebdomadaire)
    {
        // TODO: Implémentez cette méthode pour convertir un double représentant le temps de travail hebdomadaire en une chaîne de caractères au format hh:mm
        // Converti le temps de travail hebdomadaire passer en paramètre de la fonction en format hh:mm
        return TimeSpan.FromHours(tempsTravailHebdomadaire).ToString(@"hh\:mm");
    }

    // Fonction pour valider une adresse email en utilisant une expression régulière
    public static bool IsValidEmail(string email)
    {
        // TODO: Implémentez cette méthode pour valider une adresse email en utilisant une expression régulière et retourner vrai ou faux
        // Vérifie si l'adresse email passer en paramètre est valide et correspond au règle de validation d'une adresse email, qu'il comporte bien un @ et un .
        if (email != null)
        {
            string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }
        return false;
    }
}
