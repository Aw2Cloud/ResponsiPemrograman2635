using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman
{
    class Program
    {
        static Void Main (string[] args){
		
			Karyawan k1 = new k(1, 190302123, Paijo, 3000000);
			Karyawan k2 = new k(2, 190302124, Jono, 2000000);
			
			Console.WriteLine("No  Nik/Nama\t\tGaji Bulanan");
			Console.WriteLine(------------------------------------------------);
			k1.show();
			k2.show();
			Console.WriteLine("\n\n Asiqq Naik Gaji Nih\n\n");
			Console.WriteLine("No  Nik/Nama\t\tGaji Bulanan");
			Console.WriteLine(------------------------------------------------);
			k1.naik();
			k2.naik();
			Console.ReadKey();
		}
    }
}