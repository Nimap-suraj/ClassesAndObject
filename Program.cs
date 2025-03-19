using System;
using System.Diagnostics;
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
                    
        }
    }
}

