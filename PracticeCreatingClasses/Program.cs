using System;

namespace Treehouse.MediaLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var mediaLibrary = new MediaLibrary(new MediaType[]
                {
                    new Album("Ten", "Pearl Jam"),
                    new Album("The Wall", "Pink Floyd"),
                    new Album("Ride The Lightning", "Metallica"),
                    new Book("Animal Farm", "George Orwell"),
                    new Movie("Back to School", "Alan Metter")
                });

                Console.Write("Search library: ");
                string searchFor = Console.ReadLine();
                var item = mediaLibrary.FindItem(searchFor);

                if(item != null)
                {
                    MediaLibrary.DisplayItem(item);
                }
                else
                {
                    Console.WriteLine(searchFor + ": Item not found!");
                }

                //Console.WriteLine("# of items: " + mediaLibrary.NumberOfItems);

                //mediaLibrary.DisplayItems();

                //DetectMediaType(album1);
                //DetectMediaType(album2);
                //DetectMediaType(album3);
                //DetectMediaType(book);
                //DetectMediaType(movie);

                //Console.WriteLine(album1.GetDisplayText());
                //Console.WriteLine(album2.GetDisplayText());
                //Console.WriteLine(album3.GetDisplayText());
                //Console.WriteLine(book.GetDisplayText());
                //Console.WriteLine(movie.GetDisplayText());

                //album1.Loan("Joe Smith");
                //album2.Loan();
                //book.Loan();
                //movie.Loan();

                //Console.WriteLine(album1.GetDisplayText());
                //Console.WriteLine(album2.GetDisplayText());
                //Console.WriteLine(book.GetDisplayText());
                //Console.WriteLine(movie.GetDisplayText());

                //album1.Return();
                //album2.Return();
                //book.Return();
                //movie.Return();

                //Console.WriteLine(album1.GetDisplayText());
                //Console.WriteLine(album2.GetDisplayText());
                //Console.WriteLine(book.GetDisplayText());
                //Console.WriteLine(movie.GetDisplayText());

                Console.WriteLine("\nPress any key to quit.");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
                Console.ReadLine();
            }

        }

        static void DetectMediaType(MediaType item)
        {
            if (item == null)
            {
                return;
            }
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
