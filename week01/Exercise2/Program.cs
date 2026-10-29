using System;
using System.Runtime.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string gradePercentage =  Console.ReadLine();
        float grade = float.Parse(gradePercentage);

        string letter =""; 

        if (grade >= 93)
        {
            letter = "A";
        }

        else if (grade >=90)
        {
             letter = "A-";
   
        }
        else if (grade >=87)
        {
             letter = "B+";
   
        }
        else if (grade >=83)
        {
             letter = "B";
   
        }
        else if (grade >=80)
        {
             letter = "B-";
   
        }
        else if (grade >=77)
        {
             letter = "C+";
   
        }
        else if (grade >=73)
        {
             letter = "C";
   
        }
        else if (grade >=70)
        {
             letter = "C-";
   
        }
        else if (grade >=67)
        {
             letter = "D+";
   
        }

        else if (grade >=63)
        {
             letter = "D";
   
        }
        else if (grade >=60)
        {
             letter = "D-";
        }
        else 
        {
             letter = "F";
   
        }


        Console.WriteLine ($"Your grade is : {letter}");

        if (grade >=70)
        {
            Console.WriteLine("Great Job, Keep Moving Forward");
        }
        else
        {
            Console.WriteLine("Try again next semester");
        }



    }
}