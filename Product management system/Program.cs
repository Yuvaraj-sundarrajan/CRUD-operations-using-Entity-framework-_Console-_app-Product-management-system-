﻿using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Ef_Productmanagement
{
    class Program
    {
        public static void Main(String[] args)
        {
            while (true)
            {
                Console.WriteLine("\t\t\tProduct Management System");
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine("1.Add Product \t 2.Show Product\t 3.Update Product\t 4.Remove Product\t 5.Exit app ");
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Create ob1 = new Create();
                        ob1.InsertData();
                        break;
                    case 2:
                        Read ob2 = new Read();
                        ob2.PrintData();
                        break;
                    case 3:
                        Update ob3 = new Update();
                        ob3.UpdateData();
                        break;
                    case 4:
                        Delete ob4 = new Delete();
                        ob4.RemoveData();
                        break;
                    case 5:
                     Console.WriteLine("Thank you Come again later");
                        Environment.Exit(0);
                        break;
                    default:
                     Console.WriteLine("Invalid choice. Please try again.");
                        Console.Clear();
                        break;
                }
            }
        }

    }

}
