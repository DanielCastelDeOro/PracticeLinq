using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;


namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            //(Using Method Syntax)
           //Create a list of video game names..Order the list of games by length of the game name.
           //Use the lambda expression in this exercise as well.

            var videoGame = new List<string>() { "Halo", "GTA", "Sonic" };
            var sorted = videoGame.OrderBy(g => g); // Im stuck and dont know how to check to see if im correct?!!?
            Console.WriteLine(videoGame); // videoGame or sorted wont print for me?

        }
    }
}
