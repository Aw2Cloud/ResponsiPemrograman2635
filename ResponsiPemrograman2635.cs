using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman
{
    class Karyawan
    {
    	//field
    	Privite int no { get; set;}
    	Private string nik { get; set;}
    	Private string nama { get; set;}
    	Private int gabu { get; set;}
    	
    	Public k(int no1, string nik1, string nama1, int gabu1){
    		no = no1;
    		nik = nik1;
    		nama = nama1;
    		
    		if(gabu1<0){
    			gabu=0;
    		}else if (gabu1>=0){
    			gabu=gabu1;
    		}
    		
    			
    		
    	}
    	
    	Public show(){
    		Console.WriteLine("{0}. {1} {2}\t{3}"no,nik,nama,gabu);
    		
    	}
    	Public naik(){
    		float gabu2;
    		gabu2=110/100*gabu;
    		gabu=int.Parse(Console.ReadLine(gabu2));
    		Console.WriteLine("{0}. {1} {2}\t{3}"no,nik,nama,gabu);
    	}
    }
}