﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQActors
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = @"[
			[""Harrison Ford"", 4871.7, 41, 118.8, ""Star Wars: The Force Awakens"", 936.7],
			[""Samuel L. Jackson"", 4772.8, 69, 69.2, ""The Avengers"", 623.4],
			[""Morgan Freeman"", 4468.3, 61, 73.3, ""The Dark Knight"", 534.9],
			[""Tom Hanks"", 4340.8, 44, 98.7, ""Toy Story 3"", 415],
			[""Robert Downey Jr."", 3947.3, 53, 74.5, ""The Avengers"", 623.4],
			[""Eddie Murphy"", 3810.4, 38, 100.3, ""Shrek 2"", 441.2],
			[""Tom Cruise"", 3587.2, 36, 99.6, ""War of the Worlds"", 234.3],
			[""Johnny Depp"", 3368.6, 45, 74.9, ""Dead Man's Chest"", 423.3],
			[""Michael Caine"", 3351.5, 58, 57.8, ""The Dark Knight"", 534.9],
			[""Scarlett Johansson"", 3341.2, 37, 90.3, ""The Avengers"", 623.4],
			[""Gary Oldman"", 3294, 38, 86.7, ""The Dark Knight"", 534.9],
			[""Robin Williams"", 3279.3, 49, 66.9, ""Night at the Museum"", 250.9],
			[""Bruce Willis"", 3189.4, 60, 53.2, ""Sixth Sense"", 293.5],
			[""Stellan Skarsgard"", 3175, 43, 73.8, ""The Avengers"", 623.4],
			[""Anthony Daniels"", 3162.9, 7, 451.8, ""Star Wars: The Force Awakens"", 936.7],
			[""Ian McKellen"", 3150.4, 31, 101.6, ""Return of the King"", 377.8],
			[""Will Smith"", 3149.1, 24, 131.2, ""Independence Day"", 306.2],
			[""Stanley Tucci"", 3123.9, 50, 62.5, ""Catching Fire"", 424.7],
			[""Matt Damon"", 3107.3, 39, 79.7, ""The Martian"", 228.4],
			[""Robert DeNiro"", 3081.3, 79, 39, ""Meet the Fockers"", 279.3],
			[""Cameron Diaz"", 3031.7, 34, 89.2, ""Shrek 2"", 441.2],
			[""Liam Neeson"", 2942.7, 63, 46.7, ""The Phantom Menace"", 474.5],
			[""Andy Serkis"", 2890.6, 23, 125.7, ""Star Wars: The Force Awakens"", 936.7],
			[""Don Cheadle"", 2885.4, 34, 84.9, ""Avengers: Age of Ultron"", 459],
			[""Ben Stiller"", 2827, 37, 76.4, ""Meet the Fockers"", 279.3],
			[""Helena Bonham Carter"", 2822, 36, 78.4, ""Harry Potter / Deathly Hallows(P2)"", 381],
			[""Orlando Bloom"", 2815.8, 17, 165.6, ""Dead Man's Chest"", 423.3],
			[""Woody Harrelson"", 2815.8, 50, 56.3, ""Catching Fire"", 424.7],
			[""Cate Blanchett"", 2802.6, 39, 71.9, ""Return of the King"", 377.8],
			[""Julia Roberts"", 2735.3, 42, 65.1, ""Ocean's Eleven"", 183.4],
			[""Elizabeth Banks"", 2726.3, 35, 77.9, ""Catching Fire"", 424.7],
			[""Ralph Fiennes"", 2715.3, 36, 75.4, ""Harry Potter / Deathly Hallows(P2)"", 381],
			[""Emma Watson"", 2681.9, 17, 157.8, ""Harry Potter / Deathly Hallows(P2)"", 381],
			[""Tommy Lee Jones"", 2681.3, 46, 58.3, ""Men in Black"", 250.7],
			[""Brad Pitt"", 2680.9, 40, 67, ""World War Z"", 202.4],
			[""Adam Sandler"", 2661, 32, 83.2, ""Hotel Transylvania 2"", 169.7],
			[""Daniel Radcliffe"", 2634.4, 17, 155, ""Harry Potter / Deathly Hallows(P2)"", 381],
			[""Jonah Hill"", 2605.1, 29, 89.8, ""The LEGO Movie"", 257.8],
			[""Owen Wilson"", 2602.3, 39, 66.7, ""Night at the Museum"", 250.9],
			[""Idris Elba"", 2580.6, 26, 99.3, ""Avengers: Age of Ultron"", 459],
			[""Bradley Cooper"", 2557.7, 25, 102.3, ""American Sniper"", 350.1],
			[""Mark Wahlberg"", 2549.8, 36, 70.8, ""Transformers 4"", 245.4],
			[""Jim Carrey"", 2545.2, 27, 94.3, ""The Grinch"", 260],
			[""Dustin Hoffman"", 2522.1, 43, 58.7, ""Meet the Fockers"", 279.3],
			[""Leonardo DiCaprio"", 2518.3, 25, 100.7, ""Titanic"", 658.7],
			[""Jeremy Renner"", 2500.3, 21, 119.1, ""The Avengers"", 623.4],
			[""Philip Seymour Hoffman"", 2463.7, 40, 61.6, ""Catching Fire"", 424.7],
			[""Sandra Bullock"", 2462.6, 35, 70.4, ""Minions"", 336],
			[""Chris Evans"", 2457.8, 23, 106.9, ""The Avengers"", 623.4],
			[""Anne Hathaway"", 2416.5, 25, 96.7, ""The Dark Knight Rises"", 448.1]
		]";
            List<Actor> actorList = new List<Actor>();

            JArray a = JArray.Parse(data);
            foreach (var item in a)
            {
                Actor actor = new Actor
                {
                    Name = (string)item[0],
                    TotalGross = (decimal)item[1],
                    MovieCount = (int)item[2],
                    AveragePerMovie = (decimal)item[3],
                    TopMovie = (string)item[4],
                    TopMovieGross = (decimal)item[5]
                };
                actorList.Add(actor);

            }
            Console.WriteLine("Actors count: " + actorList.Count);
            foreach (var item in actorList)
            {
                Console.WriteLine(item.ToString());
            }
            List<Actor> richActors = new List<Actor>();
            foreach (var item in actorList)
            {
                if (item.TotalGross > 4000)
                {
                    richActors.Add(item);
                }
            }
            Console.WriteLine("Rich actors that earned more than $400 million");

            //Console.WriteLine(printlist(richActors));
            printlist(richActors);




            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Now use LINQ for the same results\n");
            Console.ResetColor();

            var richlistLinq = from rich in actorList
                               where rich.TotalGross > 4000
                               select rich;

            printlist(richlistLinq);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Now use Lamda for the same results(with where and select)\n");
            Console.ResetColor();

            var richlistLambda = actorList.Where(z => z.TotalGross > 4000);

            printlist(richlistLambda);


            var actorsWithEvenNumber = new List<Actor>();
            foreach (var item in actorList)
            {
                if (item.MovieCount % 2 == 0)
                {
                    actorsWithEvenNumber.Add(new Actor
                    {
                        Name = item.Name,
                        MovieCount = item.MovieCount
                    });

                }
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Show actors in even number of movies\n");
            Console.ResetColor();
            printlist(actorsWithEvenNumber);


            var actorswithEvenNumberLinq = from actor in actorList
                                           where actor.MovieCount % 2 == 0
                                           select new Actor
                                           {
                                               Name = actor.Name,
                                               MovieCount = actor.MovieCount
                                           };


            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Show actors in even number of movies by Linq\n");
            Console.ResetColor();
            printlist(actorswithEvenNumberLinq);

            var actorwithEvenNumberLambda = actorList.Where(s => s.MovieCount % 2 == 0)
                .Select(x => new Actor
                {
                    Name = x.Name,
                    MovieCount = x.MovieCount
                });

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Show actors in even number of movies by Lambda\n");
            Console.ResetColor();
            printlist(actorwithEvenNumberLambda);


            //  Star Wars Actors




            var starwarsActors = new List<Actor>();
            foreach (var item in actorList)
            {
                if (item.TopMovie.Contains("Star Wars: The Force Awakens"))
                {
                    starwarsActors.Add(new Actor
                    {
                        Name = item.Name,
                        TopMovie = item.TopMovie
                    });

                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Star Wars Actors\n");
            Console.ResetColor();
            printlist(starwarsActors);

            var starwarsActorsLinq = from actor in starwarsActors
                                     where actor.TopMovie.Contains("Star Wars: The Force Awakens")
                                     select new Actor
                                     {
                                         Name = actor.Name,
                                         TopMovie = actor.TopMovie
                                     };

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Star Wars Actors by Linq\n");
            Console.ResetColor();
            printlist(starwarsActorsLinq);

            var starwarsActorsLambda = starwarsActors.Where(x => x.TopMovie.Contains("Star Wars: The Force Awakens"))
            .Select(x => new Actor
            {
                Name = x.Name,
                TopMovie = x.TopMovie
            });

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Star Wars Actors by lambda\n");
            Console.ResetColor();
            printlist(starwarsActorsLambda);


            // Grouping
            var groupbyMovies = from actor in actorList
                                group actor by actor.TopMovie into newGroup
                                orderby newGroup.Key
                                from actoringroup in newGroup
                                select new Actor
                                {
                                    Name = actoringroup.Name,
                                    TopMovie = actoringroup.TopMovie
                                };

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Grouped by movie Linq\n");
            Console.ResetColor();
            printlist(groupbyMovies);


            // Grouping StarWars people
            var groupbyPeople = from movie in actorList
                                where movie.TopMovie.Contains("Star Wars")
                                group movie by movie.TopMovie into newGroup
                                orderby newGroup.Key
                                from moviegroup in newGroup
                                select new Actor
                                {
                                    Name = moviegroup.Name,
                                    TopMovie = moviegroup.TopMovie
                                };

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Grouped by StarWars Actors Linq\n");
            Console.ResetColor();
            printlist(groupbyPeople);

            // Grouping StarWars people with lambda

            var groupbyPeopleLambda = actorList.GroupBy(z => z.TopMovie)
                .OrderBy(b => b.Key)
                .SelectMany(c => c)
                .Select(d => new Actor
                {
                    Name = d.Name,
                    TopMovie = d.TopMovie
                });

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Grouped by Movies Lambda\n");
            Console.ResetColor();
            printlist(groupbyPeopleLambda);





        }





        //private static bool printlist(List<Actor> richActors)
        //{
        //    foreach (var item in richActors)
        //    {
        //        Console.WriteLine(item);
        //    }
        //    return true;
        //}
        private static bool printlist(IEnumerable<Actor> richActors)
        {
            foreach (var item in richActors)
            {
                Console.WriteLine(item);
            }
            return true;
        }
    }
}