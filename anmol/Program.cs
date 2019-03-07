//Anmolpreet Singh
//C0726606
//Jaskaran Singh
//C0731667
//CSD3352 Section 2
//Assignment 2
//March 6, 2019

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anmol
{
    public class DelegateExercises
    {
        public delegate void MyDelgate();


        void Method1()
        {

            Console.WriteLine("Method1");
            Console.ReadLine();
        }
        public void Method2()
        {
            MyDelgate myDelgate = new MyDelgate(Method1);

            myDelgate();
        }


    
    
        
    }
}

    class Program
    {
        static void Main(string[] args)
        {
        }
    }

