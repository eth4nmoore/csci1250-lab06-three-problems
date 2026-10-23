/*
* Name: Ethan Moore
* Course: CSCI 1250, Section 001
* Assignment: Lab 06, Three Short Problems
* Date: October 23, 2026
* Description: A menu that 
*/

using System.Runtime.ConstrainedExecution;

const int randomSeed = 4000;
const int scoreCount = 5;
const int passingScore = 60;
const int menuOptionCount = 5;
const int quitOption = 5;

Random rng = new Random(randomSeed);

int choice = 0;

// menu - choose 1 exercise, all three, or quit.
System.Console.WriteLine("=== CSCI 1250 Lab 06 ===");
System.Console.WriteLine("1. The Grade Checker");
System.Console.WriteLine("2. The Dice Table");
System.Console.WriteLine("3. The Score Report");
System.Console.WriteLine("4. All Three");
System.Console.WriteLine("5. Quit");

// user might need multiple attempts to enter a correct choice
while (choice < 1 || choice > menuOptionCount)
{
    System.Console.Write("Choose 1 through 5: ");
    choice = Convert.ToInt32(Console.ReadLine());

    if (choice < 1 || choice > menuOptionCount)
    {
        System.Console.WriteLine("Choose a number from 1 to 5.");

    }
}

//1 check score and report its letter grade
if (choice == 1 || choice == 4)
{
    System.Console.WriteLine();
    System.Console.WriteLine("=== Exercise 1: The Grade Checker ===");
}

//2 roll two dice and count rolls/wins
if (choice == 2 || choice == 4)
{
    System.Console.WriteLine();
    System.Console.WriteLine("=== Exercise 2: The Dice Table ===");
}

//3 collect scores and report summary
if (choice == 3 || choice == 4)
{
    System.Console.WriteLine();
    System.Console.WriteLine("=== Exercise 3: The Score Report ===");
}
