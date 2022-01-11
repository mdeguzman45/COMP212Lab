using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marc_DeGuzman_Exercise01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // create the list of countries
            List<Country> countries = Country.GetCountries();

            Console.WriteLine("Countries original order:");
            foreach (Country country in countries)
            {
                // Console.WriteLine($"{country.ToString()}");
                Console.WriteLine($"{country.Name}");
            }
            Console.WriteLine("----------------------------------------");

            // 1.1 List the names of the countries in alphabetical order
            var countriesOrderByNameAsc = from country in countries orderby country.Name ascending select country;
            Console.WriteLine("Countries order by name ascending:");
            foreach (Country country in countriesOrderByNameAsc)
            {
                Console.WriteLine($"{country.Name}");
            }
            Console.WriteLine("----------------------------------------");

            // 1.2 List the names of the countries in descending order by number of resources
            var countriesOrderByResourcesDesc = from country in countries orderby country.Resources.Count descending select country;
            Console.WriteLine("Countries ordered by number of resources in descending order:");
            foreach (Country country in countriesOrderByResourcesDesc)
            {
                Console.WriteLine($"{country.Name} - Resources: {string.Join(", ", country.Resources)}");
            }
            Console.WriteLine("----------------------------------------");

            // 1.3 List the names of the countries that shares a border with Argentina
            var countriesWithArgentinaBorders = from country in countries
                                                let border = "Argentina"
                                                where country.Borders.Contains(border)
                                                orderby country.Name ascending
                                                select country;
            Console.WriteLine("Countries that shares a border with Argentina:");
            foreach (Country country in countriesWithArgentinaBorders)
            {
                Console.WriteLine($"{country.Name} - Borders: {string.Join(", ", country.Borders)}");
            }
            Console.WriteLine("----------------------------------------");

            // 1.4 List the names of the countries that has more than 10,000,000 population 
            var countriesWith10MPopulation = from country in countries where country.Population > 10000000 orderby country.Name ascending select country;
            Console.WriteLine("Countries that has more than 10,000,000 population:");
            foreach (Country country in countriesWith10MPopulation)
            {
                Console.WriteLine($"{country.Name} - Population: {country.Population}");
            }
            Console.WriteLine("----------------------------------------");

            // 1.5 List the country with highest population
            Console.WriteLine("Countries order by population descending:");
            var countriesWithHighestPopulation = (from country in countries orderby country.Population descending select country);
            foreach (Country country in countriesWithHighestPopulation)
            {
                Console.WriteLine($"{country.Name} - Population: {country.Population}");
            }

            var countryWithHighestPopulation = (from country in countries orderby country.Population descending select country).First();
            Console.WriteLine($"Country with highest  population: {countryWithHighestPopulation.Name} - {countryWithHighestPopulation.Population}");

            Console.WriteLine("----------------------------------------");

            // 1.6 List all the religion in south America in dictionary order
            //var sortedReligions = countries.SelectMany(x => x.Religions).Distinct().ToList();
            //sortedReligions.Sort();
            //Console.WriteLine("South America Religions:");
            //foreach (var religion in sortedReligions)
            //{
            //    Console.WriteLine($"{religion}");
            //}
            //Console.WriteLine("----------------------------------------");

            var sortedReligion1 = (from country in countries from religions in country.Religions orderby religions select religions).Distinct();
            Console.WriteLine("South America Religions:");
            foreach (var religion in sortedReligion1)
            {
                Console.WriteLine($"{religion}");
            }
            Console.WriteLine("----------------------------------------");
        }
    }
}
