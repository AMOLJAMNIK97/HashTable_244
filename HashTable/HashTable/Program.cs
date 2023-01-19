using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hash Table ");

            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            hash.Add("0", "To");
            hash.Add("1", "be");
            hash.Add("2", "or");
            hash.Add("3", "Not");
            hash.Add("4", "To");
            hash.Add("5", "be");
            string hash5=hash.Get("5");
            string hash2=hash.Get("2");
            string hash4=hash.Get("4");
            string hash3=hash.Get("3");
            string hash1=hash.Get("1");
            string hash0=hash.Get("0");
             
             
            Console.WriteLine("5th index value: "+ hash5);
            Console.WriteLine("2th index value: "+ hash2);
            Console.WriteLine("4th index value: "+ hash4);
            Console.WriteLine("3th index value: "+ hash3);
            Console.WriteLine("1th index value: "+ hash1);
            Console.WriteLine("0th index value: "+ hash0);

        }
    }
}