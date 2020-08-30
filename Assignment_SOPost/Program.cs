using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_SOPost
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("--------Assignment No 2 (Post)--------\n");
            Console.ResetColor();

            Console.WriteLine("Current Votes Count is: 0" );

            var soPost = new Post();

            soPost.Title = "What is the { get; set; } syntax in C#?";
            soPost.Description = "I am learning ASP.NET MVC and I can read English documents, " +
                "but I don't really understand what is happening in this code:";
            soPost.CreatedTime = new DateTime(2011, 02, 23);

            Console.WriteLine("Pressing 4 Votes UP ...");
            soPost.VoteUp();
            soPost.VoteUp();
            soPost.VoteUp();
            soPost.VoteUp();
            soPost.Print();

            Console.WriteLine("Pressing 2 Votes Down...");
            soPost.VoteDown();
            soPost.VoteDown();
            soPost.Print();
        }

        class Post
        {
            public string Title { get; set; }
            public string Description { get; set; }
            public DateTime CreatedTime { get; set; }
            public int Votes { get; private set; }

            public void VoteUp()
            {
                Votes++;
            }
            public void VoteDown()
            {
                Votes--;
            }

            public void Print()
            {
                Console.WriteLine("Title: " + Title);
                Console.WriteLine("Description: " + Description);
                Console.WriteLine("Date Posted: " + CreatedTime.ToLongDateString());
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nTotal Votes Count: " + Votes);
                Console.ResetColor();
                Console.ReadLine();
            }

        }
    }
}
