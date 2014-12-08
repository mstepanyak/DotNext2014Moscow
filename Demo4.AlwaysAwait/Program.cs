﻿using System;
using System.Threading;
using System.Threading.Tasks;

namespace Demo4.AlwaysAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MainAsync().Wait();
            }
            catch (Exception e)
            {
                Console.WriteLine("An exception occured: " + e.ToString());
            }
        }

        private async static Task MainAsync()
        {
            Console.WriteLine("Started");
            try
            {
                DelayAndThrowAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine("An exception occured: " + e.Message);
            }
            Console.WriteLine("Finished");
        }

        private async static Task DelayAndThrowAsync()
        {
            await Task.Delay(100);
            throw new InvalidOperationException();
        }
    }
}