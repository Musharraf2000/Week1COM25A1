// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Console.WriteLine("Musharraf");

//string name = "Musharraf";
//name = "Musharraf Azhar";
//int age = 25;
//bool isAlive = true;
//double valueOfPi = 3.14159;

//Console.WriteLine($"My name is {name}");

//Console.WriteLine("Enter your name: ");
//string name = Console.ReadLine();
//Console.WriteLine($"Your name is {name}");

//Console.WriteLine("Enter your age: ");
//int age = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"Your age is {age}");

//Console.WriteLine("Enter number 1 :");
//int num1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter number 2 :");
//int num2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"Sum is {num1 + num2}");

//for(int i = 0; i < 5; i++)
//{
//    Console.WriteLine($"Value of I : {i}");
//}

//int x = 3;

//while(x < 10)
//{
//    Console.WriteLine($"Value of X : {x}");
//    if(x % 2 == 0)
//    {
//        Console.WriteLine($"{x} is an even number");
//    }
//    else
//    {
//        Console.WriteLine(x + " is an odd number");
//    }
//        x++;
//}


int userInput = -1;
int sum = 0;

while(userInput != 0)
{
    Console.WriteLine("Enter a number : ");
    userInput = Convert.ToInt32(Console.ReadLine());
    if(userInput < 0)
    {
        continue;
    }
    else
    {
        sum += userInput;
    }
}

Console.WriteLine($"Final sum : {sum}");