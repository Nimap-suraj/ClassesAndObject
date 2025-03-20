using System;
using System.Diagnostics;
using System.IO.Pipes;
using System.Runtime;
using System.Threading;
using System.Collections.Generic;
namespace NttsClassAndObject
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to CLass and Non Primitive Classed");

            //Person person = new Person();
            //person.Name = "Suraj Shah";
            ////person.Introduce();
            //Calculator calculator = new Calculator();
            //Console.WriteLine(calculator.Add(1, 23));


            // if we use Static in Class then
            // we don't hacve to Create a Object
            // of that class we can use Class DIreclty
            //Person.Name = "Suraj Shah";
            //Person.Introduce();
            //Console.WriteLine(Calculator.Add(7, 23));
            //Console.WriteLine(Calculator.Add(100, 23));


            //Employee emp;
            //emp.Id = 1;
            //emp.Name = "Test";
            //emp.age = 30;
            //Console.WriteLine("Hello My Name is " + emp.Name  + " i am  " + emp.age + " years old ");

            //int[] arr = new int[3] { 1, 2, 3 };
            //arr[0] = 1; 
            //arr[1] = 2;     
            //arr[2] = 3;
            //Console.WriteLine(" Array Length is  " +arr.Length);
            //Console.WriteLine("Value at index 0 =>  " + arr[0]);
            //Console.WriteLine("Value at index 1 => " + arr[1]);
            //Console.WriteLine("Value at index 2 => " + arr[2]);


            //string name = "suraj shah";
            //string collegeName = "Walchand Institute of Technology Solapur";
            //Console.WriteLine("My Name is "+ name + " and I am Persuing Btech in "+ collegeName);

            //var list = string.Join(",", arr);
            //Console.WriteLine("I haved Joind the array Element " + list);

            //string format
            //String FirstName = "suraj";
            //String LastName = "shah";
            //Console.WriteLine(string.Format("{0} {1}",FirstName,LastName));
            //verbatim string
            //var path = @"surajshah
            //            is living in
            //            mumbai for Job(Nimap Infotech)
            //            ";
            //Console.WriteLine(path);
            //    Reference Type and Value
            //int i = 10;
            //int j = i;
            //j++;
            //Console.WriteLine(string.Format("Before change: {0} After Change: {1}",i,j));
            //int[] newArr = arr;
            //newArr[0] = 100;
            //Console.WriteLine(string.Format("Before change arr: {0} After Change arr: {1}", arr[0], newArr[0]));
            // Enum 
            //Enum to Int
            //var method = ShippingMethod.Express;
            //var methodId = (int)method;
            //Console.WriteLine("Method Id is "+methodId);
            // int to Enum
            //var methodStringValue = (ShippingMethod)methodId;
            //var enumValue = methodStringValue;
            //Console.WriteLine("Method Id is " + enumValue);
            // Enum to String
            //var methodString = ShippingMethod.Regular;
            //Console.WriteLine(methodString.ToString());

            // String to Enum
            //var methodName = method.ToString();
            //var methodValue = Enum.Parse(typeof(ShippingMethod),methodName);
            //Console.WriteLine(methodValue);

            //Conditional Statements
            //int hours = 10;
            //if (hours > 0 && hours < 12)
            //{
            //    Console.WriteLine("it's Morning");
            //}
            //else if (hours >= 12 && hours <= 18)
            //{
            //    Console.WriteLine("it's afternoon");
            //}
            //else
            //{
            //    Console.WriteLine("it's Evening");
            //}
            // Ternary Operator
            //int age = 21;
            //var isValid = (age > 18) ? "u can vote" : "u cannot vote";
            //Console.WriteLine(isValid);

            //  SWITCH CASES
            //var season = Season.rainy;
            //switch (season)
            //{
            //    case Season.summer:
            //        Console.WriteLine("it's summer");
            //        break;
            //    case Season.winter:
            //        Console.WriteLine("it winter");
            //        break;
            //    case Season.rainy:
            //        Console.WriteLine("it pavsala");
            //        break;


            // Exercises 
            // Question 1
            //Console.WriteLine("Enter a Valid Number: ");
            //var number = Convert.ToInt32(Console.ReadLine());
            //if (number >= 0 && number <= 10)
            //{
            //    Console.WriteLine("Valid Input");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Input");
            //}
            // Question 2
            //Console.WriteLine("Enter a Height: ");
            //var Heigth = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter a Width: ");
            //var Width = Convert.ToInt32(Console.ReadLine());

            //if (Heigth == 9 || Width == 16)
            //{
            //    Console.WriteLine("Landscape");
            //}
            //else
            //{
            //    Console.WriteLine("Portrait");
            //}
            // Question 3
            //Console.WriteLine("Enter a Speed Limit: ");
            //var speedLimit = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter a speed of car: ");
            //var speedCar = Convert.ToInt32(Console.ReadLine());
            //int count = 0;
            //if (speedCar < speedLimit)
            //{
            //    Console.WriteLine("OK");
            //}
            //else
            //{
            //   var differenceSpeed=  speedCar - speedLimit;
            //    count = differenceSpeed / 5;
            //    if(count > 12)
            //    {
            //        Console.WriteLine("Your Licence Get Banned");
            //    }
            //    else
            //    {
            //        Console.WriteLine("DemeritPoints: " + count);
            //    }
            //}

            // Iteration
            //int[] arr = new int[9] {10,20,30,40,50,60,70,80,90};
            //foreach (int i in arr)
            //{
            //    Console.WriteLine(i);
            //}



            //string name = "suraj,sandeep,shah"; // String with commas
            //string[] parts = name.Split('.'); // Split by comma

            //// Print each part
            //Console.WriteLine("Splitting by comma:");
            //foreach (string part in parts)
            //{
            //    Console.WriteLine(part);
            //}


            // Random CLass

            //var random = new Random();
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(random.Next(1, 11));
            //}

            // Example 1 Loops
            // int cnt = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    if(i %3 == 0)
            //    {
            //        cnt++;
            //    }
            //}
            //Console.WriteLine(cnt);

            // Question 2
            // sum is declare outside 0 becaze every time when we enter  a number then we need to add it not resatrt it
            //int sum = 0;
            //while (true)
            //{
            //    Console.WriteLine("Enter a Number : ");
            //    var number = Console.ReadLine();
            //    if(number.ToLower()== "ok")
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        sum += Convert.ToInt32(number);
            //    }
            //    Console.WriteLine(sum);

            //}



            // Factorial of Number 
            //Console.WriteLine("Enter a Number: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int factorial = 1;
            //for (int i = 1; i <= num; i++)
            //{
            //    factorial *= i;   
            //}
            //Console.WriteLine("Factorial of number is " + factorial);

            //int NumberOfChance = 4;
            //Random random = new Random();
            //int secretNumber = random.Next(1, 11);
            //int flag = 0;
            //while (NumberOfChance > 0)
            //{
            //    Console.WriteLine("Enter a Number: ");
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    if (num == secretNumber)
            //    {
            //        Console.WriteLine("You Won!!!");
            //        flag = 1;
            //        break;
            //    }
            //    else if(num < secretNumber)
            //    {
            //        Console.WriteLine("guessed Number is too less");
            //        NumberOfChance--;
            //        Console.WriteLine("Number of Chances Left " + NumberOfChance);
            //    }
            //    else if (num > secretNumber)
            //    {

            //        Console.WriteLine("guessed Number is too High");
            //        NumberOfChance--;
            //        Console.WriteLine("Number of Chances Left " + NumberOfChance);
            //    }

            //}
            //if (flag == 0)

            //{ Console.WriteLine("GAME OVER Wait 2 Sec u will get the Answer of what was the Secrete Number !!!!! hehehe");

            //}
            //Thread.Sleep(2000);
            //Console.WriteLine("Secret number is " + secretNumber);


            //5, 3, 8, 1, 4 -> 8
            //Console.WriteLine("Enter a Number Separated by comma ");
            //var input = Console.ReadLine();
            ////Console.WriteLine(input.GetType());
            //var numbers = input.Split(','); // 1,3,4
            ////Console.WriteLine(numbers);

            //var max = Convert.ToInt32(numbers[0]); //1
            //foreach (var num in numbers)
            //{
            //    int n = Convert.ToInt32(num);  
            //    if(n > max)
            //    {
            //        max = n;
            //    }
            //}
            //Console.WriteLine("The Maximum Value of these numbers are : "+max);



            //var array = new int[4, 4] { { 100, 2, 4, 5 }, { 1, 4, 5, 6 }, { 5, 5, 6, 8 }, { 1,5,6,7} };
            //int element = array[0,0];
            //Console.WriteLine("Element Present at index 0 is "+element);

            //Jagged Array
            // Methods -> Length Clear copy IndexOf Reverse Sort
            // Syntax
            //var jaggedArray = new int[2][];
            //var RectanglularArray = new int[2,4];

            // Length
            //var arr = new[]{1, 2, 3,4,5 };
            //Console.WriteLine("Length of an Array is "+ arr.Length);
            //foreach(int i in arr) Console.Write(i +"  ");

            // Copy
            //
            //var another = new int[3];
            //Array.Copy(arr,another,3);

            // clear
            //Array.Clear(another, 0, 3);
            //foreach(int i in another) Console.WriteLine(i);

            //   int search=  Array.IndexOf(arr, 5);
            //Console.WriteLine("Search Index : "+ search);


            //var numbers = new[] { 5, 4, 3 };
            //Array.Sort(numbers);
            //foreach (int i in numbers) 
            //    Console.WriteLine(i);

            //var numbers = new[] {1,2, 5, 4, 3 };
            //Array.Reverse(numbers);
            //foreach (int i in numbers)
            //    Console.WriteLine(i);

            // msdn visit
            // List
            var numbers = new List<int>() { 1,2,3,4};
            //numbers.Add(1);
            // add done
            numbers.AddRange(new int[] {5,6,7});
            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("Index at " +  numbers.IndexOf(1));

            //Console.WriteLine("number of elemnets are present" + numbers.Count);

            //foreach (var item in numbers)
            //{
            //    if(item == 1)
            //    {
            //        numbers.Remove(item);
            //    }
            //}

            for(var num = 0; num < numbers.Count; num++)
            {
                if (numbers[num] == 1)
                {
                    numbers.Remove(numbers[num]);
                }
            }
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
            //Console.WriteLine(numbers);






        }
    }
}


