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


//int userInput = -1;
//int sum = 0;

//while(userInput != 0)
//{
//    Console.WriteLine("Enter a number : ");
//    userInput = Convert.ToInt32(Console.ReadLine());
//    if(userInput < 0)
//    {
//        continue;
//    }
//    else
//    {
//        sum += userInput;
//    }
//}

//Console.WriteLine($"Final sum : {sum}");

//int[] numbers = new int[5]; //[ - - - - -]
//numbers[0] = 10; //[ 10 - - - -]
//numbers[1] = 20; //[ 10 20 - - -]
//numbers[2] = 30; //[ 10 20 30 - -]
//numbers[3] = 40; //[ 10 20 30 40 -]
//numbers[4] = 50; //[ 10 20 30 40 50]
////numbers[5] = 60; //[ 10 20 30 40 50 60] // This will throw an error because the array size is 5 and we are trying to access index 5 which is out of bounds

//foreach(int number in numbers)
//{
//    Console.WriteLine(number);
//}


//int[] marks = new int[5];

//for(int i = 0; i < 5; i++)
//{
//    Console.WriteLine($"Enter marks for student {i + 1} : ");
//    marks[i] = Convert.ToInt32(Console.ReadLine());
//}

//int highest = marks[0];
//int sum = 0;


//foreach (int mark in marks)
//{
//    if(mark > highest)
//    {
//        highest = mark;
//    }
//    sum += mark;
//}

//Console.WriteLine($"Highest mark is {highest}");
//Console.WriteLine($"Average mark is {sum / marks.Length}");

//List<int> numbers = new List<int>([10,20,30]);
//numbers.Add(40); //[10,20,30,40]
//numbers.Add(50); //[10,20,30,40,50]
//numbers.Insert(4, 45); //[10,20,30,40,45,50]
//numbers.Remove(20); //[10,30,40,45,50]
//numbers.RemoveAt(3); //[10,30,40,50]

//foreach(int number in numbers)
//{
//    Console.WriteLine(number);
//}

List<string> names = new List<string>();
while (true)
{
    Console.WriteLine("Enter a name : ");
    string userInput = Console.ReadLine();
    if(userInput.ToLower().Equals("stop") || userInput.ToLower().Equals("done"))
    {
        break;
    }
    else
    {
        names.Add(userInput);
    }
}

Console.WriteLine("Names entered : ");

foreach (string name in names)
{
    Console.WriteLine(name);
}