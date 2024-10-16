using System;
using System.Drawing;

public class Program
{
    private static int ageNumber;
    private static string? name;
    private static string? eyeColor;
    private static string? hairColor;
    private static string? shoeSize;
    private static string? movie;
    private static string? teacher;
    private static string? favoriteClass;
    private static string? holiday;
    private static string? season;
    private static string? job;
    private static string? sibling;
    private static string? color;




    static void Main(string[] args)
    {
        YourName();
        YourEye();
        YourAge();
        YourHair();
        YourShoe();
        YourColor();
        YourMovie();
        YourTeacher();
        YourClass();
        YourHoliday();
        YourSeason();
        YourJob();
        YourSiblings();
        theEnd();
    }
    public static void YourName()
    {
        Console.WriteLine("Hello! What is Your name?");
        name = Console.ReadLine();
    }
    public static void YourAge()
    {
        Console.WriteLine("what is Your age?");
        ageNumber = int.Parse(Console.ReadLine());
    }
    public static void YourEye()
    {
        Console.WriteLine("what is Your eye color?");
        eyeColor = Console.ReadLine();
    }
    public static void YourHair()
    {
        Console.WriteLine("what is Your hair color?");
        hairColor = Console.ReadLine();
    }
    public static void YourShoe()
    {
        Console.WriteLine("what is Your shoe size?");
        shoeSize = Console.ReadLine();
    }
    public static void YourColor()
    {
        Console.WriteLine("what is Your favorite color?");
        color = Console.ReadLine();

    }
    public static void YourMovie()
    {
        Console.WriteLine("What is Your favorite movie?");
        movie = Console.ReadLine();
    }
    public static void YourTeacher()
    {
        Console.WriteLine("what is Your favorite teacher?");
        teacher = Console.ReadLine();
    }
    public static void YourClass()
    {
        Console.WriteLine("what is Your favorite class?");
        favoriteClass = Console.ReadLine();
    }
    public static void YourHoliday()
    {
        Console.WriteLine("what is Your favorite holiday?");
        holiday = Console.ReadLine();

    }
    public static void YourSeason()
    {
        Console.WriteLine("what is Your favorite season?");
        season = Console.ReadLine();
    }
    public static void YourJob()
    {
        Console.WriteLine("what is Your dream job?");
        job = Console.ReadLine();
    }
    public static void YourSiblings()
    {
        Console.WriteLine("how many siblings do you have?");
        sibling = Console.ReadLine();
    }
    public static void theEnd()
    {
        Console.WriteLine("hello " + name + ". you have " + eyeColor + "eyes, " + hairColor + " hair, and Your shoe size is a "
     + shoeSize + ". Your favorite color is " + color + ", favorite movie " + movie + ", favorite teacher " + teacher
     + ", favorite class " + favoriteClass + ", favorite holiday " + holiday + ", favorite season " + season
     + ", and Your dream job is " + job + ". You have " + sibling + "sibling" + ", and you will be " + (ageNumber + 5) + " in five years.");

    }
}

