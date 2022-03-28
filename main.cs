// Created by: Aiden McLeod
// Created on: Mar 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        string streetName;
        int streetNumber;

        Console.WriteLine("This program gets a user's address.");
        Console.WriteLine("");

        Console.Write("Enter your streetname: ");
        streetName = Console.ReadLine();
        Console.Write("Enter your streetnumber: ");
        streetNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("");
        Console.WriteLine("Your info is: " + streetName + ", streetnumber " + streetNumber + ".");

        Console.WriteLine("\nDone.");
    }
}