using System;
using System.Collections.Generic;
using System.Linq;


namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
          
            var videoGame = new List<string>() { "Halo", "GTA", "Sonic" };
            var sorted = videoGame.OrderBy(game => game).ToList();
            Console.WriteLine(videoGame);

        }
    }
}
