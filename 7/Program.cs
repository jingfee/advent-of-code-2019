﻿using System;
using System.IO;
using System.Linq;

namespace AoC._2019._7
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = GetInputFromFile();
        }

        static string[] GetInputFromFile()
        {
            var data = File.ReadAllLines("input.txt");
            return data;
        }
    }
}
