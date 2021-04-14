using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgrammingOOP
{
	class Menu : Program
	{

		public void menu()
		{
			Console.WriteLine("Menu");
			Console.WriteLine("1. Body Mas Index");
			Console.WriteLine("2. Reprint Name");
			Console.WriteLine("3. Prints Even's Character");
			Console.WriteLine("4. Sum the inputted array");
			Console.WriteLine("Masukkan Pilihan Anda :");
		}
	}

	class Hitung : Menu
	{
		public void BMI(int berat, int tinggi)
		{
			float tinggi1 = (float)tinggi / 100;
			float BMI = (float)berat / (tinggi1 * tinggi1);

			if (BMI > 28.1)
			{
				Console.WriteLine("Skor BMI > 28.1, Kamu Obesitas dan Skor BMI kamu adalah " + BMI);
			}
			else if (BMI > 23.1)
			{
				Console.WriteLine("Skor BMI antara 23.2 - 28.1, Kamu Overweight dan Skor BMI kamu adalah " + BMI);
			}
			else if (BMI > 18.1)
			{
				Console.WriteLine("Skor BMI antara 18.1 - 23.1, Kamu Normal dan Skor BMI kamu adalah " + BMI);
			}
			else
			{
				Console.WriteLine("Skor BMI < 18.1, Kamu Underweight dan Skor BMI kamu adalah " + BMI);
			}
		}

		public void reprint(string nama)
		{
			int lenght = nama.Length;
			string[] explode = new string[100];
			for (int i = 0; i < lenght; i++)
			{
				explode[i] = nama.Substring(i, 1);
			}

			for (int i = 0; i < lenght; i++)
			{
				Console.WriteLine("Huruf ke-" + (i + 1) + " : " + explode[i]);
			}
		}

		public void overloading(string nama)
		{
			int lenght = nama.Length;
			string[] explode = new string[100];

			for (int i = 0; i < lenght; i++)
			{
				explode[i] = nama.Substring(i, 1);
			}

			for (int i = 1; i <= lenght; i++)
			{
				Console.WriteLine(explode[i]);
				i += 1;
			}
		}

		public void overloading(int angka)
		{
			int[] deret = new int[100];
			int total = 0;
			for (int i = 0; i < angka; i++)
			{
				Console.Write("masukkan angka ke " + (i + 1) + "\n");
				string dex = Console.ReadLine();
				deret[i] = Convert.ToInt32(dex);
			}

			for (int i = 0; i < angka; i++)
			{
				total += deret[i];
			}

			for (int i = 0; i < angka; i++)
			{
				if (i == (angka - 1))
				{
					Console.Write(deret[i] + " ]");
				}
				else if (i == 0)
				{
					Console.Write("[ " + deret[i] + " , ");
				}
				else
				{
					Console.Write(deret[i] + " , ");
				}
			}
			Console.WriteLine("\nPanjang Array adalah " + angka);
			Console.WriteLine("Total dari penjumlahan dari isi deret angka adalah " + total);
		}
	}


	class Program
	{
		static void Main(string[] args)
		{
			Menu obj1 = new Menu();
			Hitung obj2 = new Hitung();
			obj1.menu();

		menu:
			string input = Console.ReadLine();

			if (input == "1")
			{
				Console.WriteLine("Masukkan Berat Badan Anda(Kg) :");
				string val = Console.ReadLine();
				int berat = Convert.ToInt32(val);
				Console.WriteLine("Masukkan Tinggi Badan Anda(Cm) :");
				string val1 = Console.ReadLine();
				int tinggi = Convert.ToInt32(val1);
				obj2.BMI(berat, tinggi);

				Console.WriteLine("Input Yes untuk kembali ke menu awal !!!");
				string res = (Console.ReadLine()).ToLower();
				if (res == "yes")
				{
					Console.Clear();
					obj1.menu();
					goto menu;
				}
				else
				{
					Console.Clear();
				}

			}
			else if (input == "2")
			{
				Console.WriteLine("Masukkan Nama Anda");
				string nama = Console.ReadLine();
				obj2.reprint(nama);

				Console.WriteLine("Input Yes untuk kembali ke menu awal !!!");
				string res = Console.ReadLine();
				if ("yes".Equals(res, StringComparison.CurrentCultureIgnoreCase))
				{
					Console.Clear();
					obj1.menu();
					goto menu;
				}
				else
				{
					Console.Clear();
				}

			}
			else if (input == "3")
			{
				Console.WriteLine("Masukkan Nama Anda");
				string nama = Console.ReadLine();
				obj2.overloading(nama);

				Console.WriteLine("Input Yes untuk kembali ke menu awal !!!");
				string res = (Console.ReadLine()).ToUpper();
				if (res == "YES")
				{
					Console.Clear();
					obj1.menu();
					goto menu;
				}
				else
				{
					Console.Clear();
				}

			}
			else if (input == "4")
			{
				Console.WriteLine("Masukkan Panjang Array :");
				string val = Console.ReadLine();
				int angka = Convert.ToInt32(val);
				obj2.overloading(angka);

				Console.WriteLine("Input Yes untuk kembali ke menu awal !!!");
				string res = Console.ReadLine();
				string res1 = res.ToLower();
				if (res1 == "yes")
				{
					Console.Clear();
					obj1.menu();
					goto menu;
				}
				else
				{
					Console.Clear();
				}
			}
			else
			{
				Console.WriteLine("Harap input antara 1-4");
				obj1.menu();
				goto menu;
			}
		}
	}
}
