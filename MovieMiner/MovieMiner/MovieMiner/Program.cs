﻿using System;
using System.Diagnostics;
using MovieMiner.Console.Modules;

namespace MovieMiner.Console
{
    internal class Program
    {

        private static void Main(string[] args)
        {
            System.Console.WriteLine("Starting stopwatch...");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            DiscoverModules discoverModules = new DiscoverModules();
            discoverModules.Start();

            stopwatch.Stop();

            System.Console.WriteLine("Elapsed time - {0}:{1}:{2}.{3}", stopwatch.Elapsed.Hours,
                stopwatch.Elapsed.Minutes, stopwatch.Elapsed.Seconds, Environment.NewLine);
            System.Console.WriteLine("Press enter to quit...");
            System.Console.ReadLine();
        }

    }
}
