using Lab10;
using System;
using System.Collections.Generic;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            Movies allMovies = new Movies();
           
           List<Movies> movieList = new List<Movies>();
            
            Movies TheTerminator = new Movies("The Terminator", "Action/Scifi", "R");
            Movies Terminator2JudgementDay = new Movies("Terminator 2: Judgement Day", "Action/Scifi", "R");
            Movies Predator = new Movies("Predator", "Action/Scifi", "R");
            Movies LoTR = new Movies("The Lord of the Rings: The Fellowship of the Ring", "Fantasy", "PG-13");
            Movies Deadpool = new Movies("Deadpool", "Action", "R");
            Movies AStarIsBorn = new Movies("A Star is Born", "Drama", "R");
            Movies Chicago = new Movies("Chicago", "Musical", "PG-13");
            Movies Jaws = new Movies("Jaws", "Thriller", "PG");
            Movies Alien = new Movies("Alien", "Horror", "R");
            Movies TheThing = new Movies("The Thing", "Horror", "R");

            movieList = new List<Movies> { TheTerminator, Terminator2JudgementDay, Predator, LoTR, Deadpool, Alien, AStarIsBorn, Chicago, Jaws, TheThing };
            
            Console.WriteLine("Welcome to the Movie List Application!");
            Console.WriteLine($"\nThere are {movieList.Count} movies in this list.");
            
            string yes = "y";
            while (yes=="y") 
            {
                string movieInput = "".ToLower();
                while (movieInput!="action"&&movieInput!="action/scifi"&&movieInput!="musical"&&movieInput!="horror"&&movieInput!="thriller") 
                {
                    Console.WriteLine("\nWhat category are you interested in (Action/Scifi, Action, Musical, Horror, Thriller)?");
                    Console.WriteLine("Please choose a selection from the list");
                    movieInput = Console.ReadLine().ToLower();
                    
                }
                    foreach (Movies movie in movieList)
                    {
                        if (movie.Category.ToLower() == movieInput)
                        {
                            movie.PrintOff();
                        }
                    }
                string no = "n".ToLower();
                while (yes != "y" || yes != "n")
                {
                    Console.WriteLine("Would you likd to find another movie? (y/n)");
                    yes = Console.ReadLine();
                    if (yes == no || yes == "y")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please select y or n");
                    }
                } 
            }
        }
    }
}
