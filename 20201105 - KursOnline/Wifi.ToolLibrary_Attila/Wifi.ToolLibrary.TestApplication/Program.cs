﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Wifi.ToolLibrary.ConsoleIo;

namespace Wifi.ToolLibrary.TestApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //ConsoleTools.DisplayColoredMessage("Dies ist ein Test..", ConsoleColor.Red);

            //double val1 = ConsoleTools.GetDouble("Bitte Wert eingeben: ");

            //Console.WriteLine($"Der Wert war: {val1}");

            //ConsoleTools.DisplayColoredMessage("Test", ConsoleColor.Yellow);

            //ConsoleTools.DisplayColoredMessage("Hallo");

            //Console.ReadLine();

            Console.WriteLine("Use STD Random");
            Random rnd = new Random();
            Console.WriteLine($" Zufällg zahl (1-10) {rnd.Next(1,10)}");
            Console.WriteLine($" Zufällg zahl (1-10) {rnd.Next(1, 10)}");
            Console.WriteLine($" Zufällg zahl (1-10) {rnd.Next(1, 10)}");
            Console.WriteLine($" Zufällg zahl (1-10) {rnd.Next(1, 10)}");

            Console.WriteLine("Use RandomAdv");
            RandomAdv rndAdv = new RandomAdv();
            Console.WriteLine($" Zufällg zahl (1-10) {rndAdv.Next(1, 10)}");
            Console.WriteLine($" Zufällg zahl (1-10) {rndAdv.Next(1, 10)}");
            Console.WriteLine($" Zufällg zahl (1-10) {rndAdv.Next(1, 10)}");

            Console.WriteLine("Use RandomAdv whit NextString ");
            Console.WriteLine($" Zufällg zahl (1-10) {rndAdv.NextString(25)}");
            Console.WriteLine($" Zufällg zahl (1-10) {rndAdv.NextString(50)}");
            Console.WriteLine($" Zufällg zahl (1-10) {rndAdv.NextString(75)}");

        }

    }
}
