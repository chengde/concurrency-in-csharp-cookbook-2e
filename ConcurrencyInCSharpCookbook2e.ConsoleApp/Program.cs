﻿using System;
using System.Threading.Tasks;

namespace ConcurrencyInCSharpCookbook2e.ConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
 //               await new ch01_console().Execute();
 //               await new ch02_console().Execute();
                await new ch03r04C().Test();

//                await new ch12_console().Execute();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
