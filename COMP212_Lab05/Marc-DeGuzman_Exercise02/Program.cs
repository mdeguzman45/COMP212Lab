using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marc_DeGuzman_Exercise02
{
    public class Program
    {
        private static BooksEntities bookContext = new BooksEntities();

        public static void Main(string[] args)
        {
            // get list of all the titles and the authors who wrote them
            var allTitlesAndAuthor = from book in bookContext.Titles
                            from author in book.Authors 
                            orderby book.Title1 
                            select new { author.FirstName, author.LastName, book.Title1 };

            Console.WriteLine("List of all the titles and the authors who wrote them:");
            foreach (var aBook in allTitlesAndAuthor)
            {
                Console.WriteLine($"\r\t{aBook.FirstName,-10} {aBook.LastName,-10} {aBook.Title1}");
            }
            Console.WriteLine("-------------------------------------------------------------------------");

            // get list of all the titles and the authors who wrote them
            // each title sort the authors alphabetically by last name then first name
            Console.WriteLine("List of all the titles and the authors who wrote them sort authors alphabetically:");
            var allTitlesSortedAuthors = from book in bookContext.Titles
                                         from author in book.Authors
                                         orderby book.Title1, author.LastName, author.FirstName 
                                         select new { author.FirstName, author.LastName, book.Title1 };

            // display titles with their authors sorted
            foreach (var aBook in allTitlesSortedAuthors)
            {
                Console.WriteLine($"\r\t{aBook.FirstName,-10} {aBook.LastName,-10} {aBook.Title1}");
            }
            Console.WriteLine("-------------------------------------------------------------------------");

            // get list of all the authors grouped by title, sorted by title
            var allAuthorsGroupedByTitle = from book in bookContext.Titles
                                         orderby book.Title1 ascending
                                         select new
                                         {
                                             book.Title1,
                                             Authors = from author in book.Authors
                                                       orderby author.LastName, author.FirstName select author
                                         };

            Console.WriteLine("List of Authors grouped by title:");
            // display authors grouped by title
            foreach (var aBook in allAuthorsGroupedByTitle)
            {
                Console.WriteLine($"\r\t{aBook.Title1}");
                Console.WriteLine($"\r\tAuthor/s:");
                // list the authors of the book
                foreach (var anAuthor in aBook.Authors)
                {
                    Console.WriteLine($"\r\t\t{anAuthor.FirstName} {anAuthor.LastName}");
                }
            }
        }
    }
}
