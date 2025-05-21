using System;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {

        Fractions f1 = new Fractions(); //1/1
        Fractions f2 = new Fractions(6);
        Fractions f3 = new Fractions(6, 7);
        Fractions f4 = new Fractions(3, 4);

        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());

        
        //    Public void Fractions()
        //    {
        //        Fractions(wholeNumber: int)
        //        {
        //
        //        }
        //        Fractions(int _top, int _bottom)
        //        {
        //
        //        }
        //    }
        //
        //    Public void GetTop()
        //    {
        //        private SetTop(int _top)
        //        {
        //
        //        }
        //        private GetBottom()
        //        {
        //
        //        }
        //        private SetBotoom(int _bottom)
        //        {
        //
        //        }
        //
        //    }
        //
        //    Public string GetfractionString(string)
        //    {
        //
        //    }

        //
        //    
        //    
        //
        //}
    }
}