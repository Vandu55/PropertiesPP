using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyDemo
{
    public class PropertyDemo
    {
        private string _fristName = string.Empty;
        private string _lastName = string.Empty;
        private int _Age;
        private string country = "India";

        public string empfristName
        {
            set { _fristName = value; }
            get { return _fristName; }

        }
        

        public string CountryName
        {
            get { return country; }
        }
    }
        class Program
        {
            static void Main(string[] arg)
            {


                PropertyDemo obj = new PropertyDemo();
                obj.empfristName = "vandu";
                Console.WriteLine("My frist" + obj.empfristName);
            Console.WriteLine("my country" + obj.CountryName);
                Console.ReadLine();
            }
        }
    }

