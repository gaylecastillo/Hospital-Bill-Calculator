using System;
namespace HospitalBillCalculator
{
	internal class Function
	{
		public static List<double> roomCharges = new List<double>();
		public static List<double> medicationCharges= new List<double>();
		public static List<double> procedureCharges= new List<double>();
	
		public static void CalculateRoomCharges()
		{
			Console.Write("Enter the number of days stayed in the room: ");
			if (int.TryParse(Console.ReadLine(), out int daysStayed))
			{
            double roomChargePerDay = 1000.0;
            double totalRoomCharge = daysStayed * roomChargePerDay;
            roomCharges.Add(totalRoomCharge);

            Console.WriteLine($"Total Room Charges: Php{totalRoomCharge}");
			}
			else
			{
            Console.WriteLine("Invalid input. Please enter a valid number of days.");
			}
		}
		
		public static void CalculateMedicationCharges()
		{
			Console.Write("Enter the total cost of medications used: Php");
			if (double.TryParse(Console.ReadLine(), out double medicationCost))
			{
            medicationCharges.Add(medicationCost);
            Console.WriteLine($"Total Medication Charges: Php{medicationCost}");
			}
			else
			{
            Console.WriteLine("Invalid input. Please enter a valid medication cost.");
			}
		}
		
		public static void ProcedureCharges()
		{
			Console.Write("Enter the total cost of procedures done: Php");
			if (double.TryParse(Console.ReadLine(), out double procedureCost))
			{
            procedureCharges.Add(procedureCost);
            Console.WriteLine($"Total Procedure Charges: Php{procedureCost}");
			}
			else
			{
            Console.WriteLine("Invalid input. Please enter a valid procedure cost.");
			}
		}
		
		public static void DisplayTotalBill()
		{
			double totalBill = CalculateTotalBill();
			Console.WriteLine($"Overall Total Charges: Php{totalBill}");
		}
		
		public static double CalculateTotalBill()
		{
			double totalBill = 0.0;

			foreach (var roomCharge in roomCharges)
			{
            totalBill += roomCharge;
			}

			foreach (var medicationCharge in medicationCharges)
			{
            totalBill += medicationCharge;
			}

			foreach (var procedureCharge in procedureCharges)
			{
            totalBill += procedureCharge;
			}

			return totalBill;
			}
	}
	
}
