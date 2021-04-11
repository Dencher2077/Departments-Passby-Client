using System;
using DepartmentsPassby;

namespace DepartmentsPassbyClient
{
    class Program
    {
        static void Main(string[] args)
        {
            PassbyResult result = new Passby("config.json").Start("Department 3");

            Console.WriteLine("Seals snapshots:");
            foreach (var sealsSnapshot in result.SealsSnapshots)
            {
                foreach (var seal in sealsSnapshot)
                {
                    Console.Write(seal + " ");
                }

                Console.WriteLine();
            }
            

            Console.WriteLine("\nMessages:");
            foreach (var msg in result.Messages)
            {
                Console.WriteLine(msg);
            }
        }
    }
}