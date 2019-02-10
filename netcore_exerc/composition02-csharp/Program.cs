using System;
using composition02_csharp.Entities;

namespace composition02_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("That is awesome");

            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to New Zealand",
                "I'm going to visit this wondeful country!",
                12);
            p1.AddCommnet(c1);
            p1.AddCommnet(c2);

            Comment c3 = new Comment("Good night");
            Comment c4 = new Comment("May the Force be with you");

            Post p2 = new Post(
                DateTime.Parse("28/07/2018 23:14:19"),
                "Good nightguys",
                "See you tomorrow",
                5);
            p2.AddCommnet(c3);
            p2.AddCommnet(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
