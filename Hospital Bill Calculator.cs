using System;

class HospitalBillCalculator
{
  internal class Program
  {
    static void Main(string[] args)
    {
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Hospital Bill Calculator Menu");
            Console.WriteLine("1. Calculate the Room Charges");
            Console.WriteLine("2. Calculate the Medication Charges");
            Console.WriteLine("3. Calculate the Procedure Charges");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CalculateRoomCharges();
                    break;
                case 2:
                    CalculateMedicationCharges();
                    break;
                case 3:
                    CalculateProcedureCharges();
                    break;
                case 4:
                    exit = true;
                    Console.WriteLine("Thank you for using the Hospital Bill Calculator.");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void CalculateRoomCharges()
    {
        Console.Write("Enter the number of days stayed in the room: ");
        int daysStayed = Convert.ToInt32(Console.ReadLine());

        double roomChargePerDay = 1000.0;
        double totalRoomCharges = daysStayed * roomChargePerDay;

        Console.WriteLine($"Total Room Charges: ${totalRoomCharges}");
    }

    static void CalculateMedicationCharges()
    {
        Console.Write("Enter the total cost of medications used: $");
        double medicationCost = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Total Medication Charges: ${medicationCost}");
    }

    static void CalculateProcedureCharges()
    {
        Console.Write("Enter the total cost of procedures done: $");
        double procedureCost = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Total Procedure Charges: ${procedureCost}");
    }
  }
}