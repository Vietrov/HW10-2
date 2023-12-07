using System;
using System.Collections.Generic;

class Country
{
    
    private string countryName;
    private string continentName;
    private int population;
    private string phoneCode;
    private string capitalName;
    private List<string> cities;

   
    public Country(string countryName, string continentName, int population, string phoneCode, string capitalName, List<string> cities)
    {
        this.countryName = countryName;
        this.continentName = continentName;
        this.population = population;
        this.phoneCode = phoneCode;
        this.capitalName = capitalName;
        this.cities = cities;
    }

    
    public void DisplayCountryInfo()
    {
        Console.WriteLine("Название страны: " + countryName);
        Console.WriteLine("Название континента: " + continentName);
        Console.WriteLine("Количество жителей: " + population);
        Console.WriteLine("Телефонный код: " + phoneCode);
        Console.WriteLine("Столица: " + capitalName);
        Console.WriteLine("Города:");
        foreach (var city in cities)
        {
            Console.WriteLine("- " + city);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        List<string> citiesList = new List<string>();
        citiesList.Add("Киев");
        citiesList.Add("Чернигов");
        citiesList.Add("Харьков");

        
        Country country = new Country("Украина", "Евразия", 146171015, "+8093", "Киев", citiesList);
        country.DisplayCountryInfo();
    }
}