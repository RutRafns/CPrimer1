// See https://aka.ms/new-console-template for more information

// Challenge 1

// Write a program that asks the user for a number (Console.ReadLine()),
// over and over again, forever, until he stops giving a number (just presses enter).
// Store every number in a List. At the end of the program, print out the largest and
// the smallest value the user entered.




class Program
    {
        static void Main(string[] args)
        {
         List  <int> numberList = new List<int>();
       while (true)
        {
            Console.WriteLine("Input a number or press enter to stop");
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
                break;
            if (int.TryParse(input, out int number))
            { numberList.Add(number); }
        }

        int smallest = numberList[0];
        int largest = numberList[0];

        foreach (int number in numberList)
        {
             if (number < smallest)
                    smallest = number;
            if (number > largest)
                largest = number;
        }

        Console.WriteLine($"Smallest number entered: {smallest}");
        Console.WriteLine($"Largest number entered: {largest}");
    }
    }


    