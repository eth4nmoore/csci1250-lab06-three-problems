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
do
{
    choice = 0;
    Console.WriteLine();


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

    Console.Write("Score: ");
    int score = Convert.ToInt32(Console.ReadLine());
    while (score < 0 || score > 100)
    {
        System.Console.WriteLine("A score must be between 0 and 100.");
        Console.Write("Score: ");
        score = Convert.ToInt32(Console.ReadLine());

    }

    string letterGrade;

    if (score >= 90)
    {
        letterGrade = "A";
    }
    else if (score >= 80)
    {
        letterGrade = "B";
    }
    else if (score >= 70)
    {
        letterGrade = "C";
    }
    else if (score >= passingScore)
    {
        letterGrade = "D";
    }
    else
    {
        letterGrade = "F";
    }

    System.Console.WriteLine($"{score} earns a {letterGrade}.");
}

//2 roll two dice and count rolls/wins
if (choice == 2 || choice == 4)
{
    System.Console.WriteLine();
    System.Console.WriteLine("=== Exercise 2: The Dice Table ===");

    int rollCount = 0;
    int winCount = 0;
    string rollAgain;

    do
    {
        int firstDie = rng.Next(1, 7);
        int secondDie = rng.Next(1, 7);
        int total = firstDie + secondDie;

        rollCount++;

        Console.Write(
            $"Roll {rollCount}: {firstDie} and {secondDie}, total {total}. ");
        
        if (firstDie == 1 && secondDie == 1)
        {
            Console.Write(" Snake eyes.");
        }
        else if (firstDie == secondDie)
        {
            Console.Write(" Doubles!");
        }
        else if (total == 7 || total == 11)
        {
            Console.Write(" A winner.");
            winCount++;
        }

        Console.WriteLine();

        Console.Write("Roll again (y/n): ");
        rollAgain = Console.ReadLine() ?? "";
    } while (rollAgain == "y");

    System.Console.WriteLine($"You rolled {rollCount} times and won {winCount}. ");

    
}

//3 collect scores and report summary
if (choice == 3 || choice == 4)
{
    System.Console.WriteLine();
    System.Console.WriteLine("=== Exercise 3: The Score Report ===");

    int[] scores = new int[scoreCount];

    for(int index = 0; index < scores.Length; index++)
    {
        Console.Write($"Score {index + 1}: ");
        scores[index] = Convert.ToInt32(Console.ReadLine());
    }

    int total = 0;
    int highest = scores[0];
    int passingCount = 0;

    foreach (int score in scores)
    {
        total += score;

        if (score > highest)
        {
            highest = score;
        }

        if (score >= passingScore)
        {
            passingCount++;
        }
    }

    double average = (double)total / scores.Length;

    System.Console.WriteLine();
    System.Console.WriteLine($"Scores entered: {scores.Length}");
    System.Console.WriteLine($"Total: {total}");
    System.Console.WriteLine($"Average: {average:F1}");
    System.Console.WriteLine($"Highest: {highest}");
    System.Console.WriteLine($"Passing: {passingCount} of {scores.Length}");
}
} while (choice != quitOption);

Console.WriteLine("Goodbye.");
