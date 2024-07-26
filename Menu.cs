using System;
namespace HospitalBillCalculator
{
	internal class Menu
	{
		public static void Show()
		{
			bool exit = false;
			
			while(!exit)
			{
				Console.WriteLine();
				Console.WriteLine("Hospital Bill Calculator");
				Console.WriteLine("Menu");
				Console.WriteLine();
                Console.WriteLine("1. Calculate the Room Charges");
                Console.WriteLine("2. Calculate the Medication Charges");
                Console.WriteLine("3. Calculate the Procedure Charges");
                Console.WriteLine("4. Display Total Bill");
                Console.WriteLine("5. Exit");
				
				Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
						Function.CalculateRoomCharges();
						Console.WriteLine();
                        break;
						
                    case 2:
						Function.CalculateMedicationCharges();
						Console.WriteLine();
                        break;
						
                    case 3:
						Function.ProcedureCharges();
						Console.WriteLine();
                        break;
						
                    case 4:
						Function.DisplayTotalBill();
						Console.WriteLine();
                        break;
						
                    case 5:
                        exit = true;
                        Console.WriteLine("Thank you for using the Hospital Bill Calculator.");
                        break;
						
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
	}
}

