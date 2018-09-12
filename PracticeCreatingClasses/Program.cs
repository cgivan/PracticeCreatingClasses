using System;

namespace Treehouse.MediaLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var album1 = new Album("Ten", "Pearl Jam");
                var album2 = new Album("The Wall", "Pink Floyd");
                var album3 = new Album("Ride The Lightning", "Metallica");
                var book = new Book("Animal Farm", "George Orwell");
                var movie = new Movie("Back to School", "Alan Metter");

                DetectMediaType(album1);
                DetectMediaType(album2);
                DetectMediaType(album3);
                DetectMediaType(book);
                DetectMediaType(movie);

                Console.WriteLine(album1.GetDisplayText());
                Console.WriteLine(album2.GetDisplayText());
                Console.WriteLine(album3.GetDisplayText());
                Console.WriteLine(book.GetDisplayText());
                Console.WriteLine(movie.GetDisplayText());

                album1.Loan("Joe Smith");
                album2.Loan();
                book.Loan();
                movie.Loan();

                Console.WriteLine(album1.GetDisplayText());
                Console.WriteLine(album2.GetDisplayText());
                Console.WriteLine(book.GetDisplayText());
                Console.WriteLine(movie.GetDisplayText());

                album1.Return();
                album2.Return();
                book.Return();
                movie.Return();

                Console.WriteLine(album1.GetDisplayText());
                Console.WriteLine(album2.GetDisplayText());
                Console.WriteLine(book.GetDisplayText());
                Console.WriteLine(movie.GetDisplayText());

                //var book = new Book("Animal Farm", "George Orwell");
                //var movie = new Movie("Back to School", "Alan Metter");

                //Console.WriteLine("Book: " + book.Title + " by " + book.Author);
                //Console.WriteLine("Movie: " + movie.Title + " by " + movie.Director);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex);
                Console.ReadLine();
            }

        }

        static void DetectMediaType(MediaType item)
        {
            if (item is Album)
            {
                Console.WriteLine(item.Title + " is an album!");
            }
            else if (item is Book)
            {
                Console.WriteLine(item.Title + " is an book!");
            }
            else if (item is Movie)
            {
                Console.WriteLine(item.Title + " is an movie!");
            }
            else
            {
                throw new Exception("Unexpected media subtype encountered.");
            }
        }
    }
}
