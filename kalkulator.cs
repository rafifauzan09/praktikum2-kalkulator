using System;

	class Program
	{
		static void Main(string[] arg)
		{
			Console.Title = "Aplikasi Calculator";
			
			Console.WriteLine("1. Penambahan");
			Console.WriteLine("2. Pengurangan");
			Console.WriteLine("3. Perkalian");
			Console.WriteLine("4. Pembagian");
			Console.WriteLine("Pilih Menu (1 - 4): ");
			int pilih = int.Parse(Console.ReadLine());
			Console.WriteLine();
			
			
			Console.Write("Inputkan nilai a = ");
			int a = int.Parse(Console.ReadLine());
			
			Console.Write("Inputkan nilai b = ");
			int b = Convert.ToInt32(Console.ReadLine());
	   
		    Console.WriteLine();
			if (pilih == 1){
			Console.WriteLine ("Hasil Penambahan :  {0} - {1} = {2}" ,a,b,Penambahan(a,b));
			}
			if (pilih == 2){
			Console.WriteLine ("Hasil Pengurangan : {0} - {1} = {2}" ,a,b,Pengurangan(a,b));
			}
			if (pilih == 3){
			Console.WriteLine ("Hasil Perkalian :  {0} - {1} = {2}" ,a,b,Perkalian(a,b));
			}
			if (pilih == 4){
			Console.WriteLine ("Hasil Pembagian :  {0} - {1} = {2}" ,a,b,Pembagian(a,b));
			}
			
			Console.WriteLine ("\nTekan sembarang key untuk keluar");
			Console.ReadKey();
		}

		static int Penambahan(int a, int b)
		{	
			return a + b;
		}
		
		static int Pengurangan(int a, int b)
		{	
			return a - b;	
		}
		
		static int Perkalian(int a, int b)
		{	
			return a * b;	
		}
		
		static int Pembagian(int a, int b)
		{	
			return a / b;	
		}
	}
