﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CountFileDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Directories = Directory.GetDirectories(@"D:\Pritesh\DOTNET PRACTICAL\DOTNET");
            foreach (string dir in Directories)
            {
                Console.WriteLine(dir);
            }
            string[] Files = Directory.GetFiles(@"D:\Pritesh\DOTNET PRACTICAL\DOTNET");
            foreach (string f in Files)
            {
                Console.WriteLine(f);
            }
            Console.ReadKey();


        }
    }
}
