using System;
using DemoStringBuilder.Entities;

namespace DemoStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *  O programa simula um post de rede social com comentários, curtidas e interações
             * com a postagem.
             */

            Comment c1 = new Comment("Have a nice trip!");
            Comment c2 = new Comment("Wow, that's awesome!");
            Comment c3 = new Comment("Enjoy the trip, Gustavo! That's a wonderful place");
            Post p1 = new Post(
                DateTime.Now,
                "Traveling to the New Zealand",
                "I'm going to visit this wonderful country!",
                12
                ) ;
            p1.AddComment(c1);
            p1.AddComment(c2);
            p1.AddComment(c3);

            Comment c4 = new Comment("May the Force be with you");
            Comment c5 = new Comment("I hope to see you tomorrow, hunf!");
            Comment c6 = new Comment("See you tomorrow, Gustavo! Have a nice dreams!!");
            Comment c7 = new Comment("Have a nice dream with me, my boy! Ass.. Nathalia!");
            Post p2 = new Post(
                    DateTime.Now,
                    "Good night guys",
                    "See you tomorrow",
                    5);
            p2.AddComment(c4);
            p2.AddComment(c5);
            p2.AddComment(c6);
            p2.AddComment(c7);

            Console.WriteLine(p1);
            Console.WriteLine();
            Console.WriteLine(p2);
        }
    }
}
