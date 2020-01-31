using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndStructure
{
    class PersonClass
    {
        public string Name { get; set; }

        public long Age { get; set; }

        public Decimal Rec { get; set; }

        public string Print()
        {
            return $" {Name}-{Age}.";
        }

    }

    struct PersonStruct
    {
        public string Name { get; set; }

        public long Age { get; set; }

        public Decimal Rec { get; set; }

        public string Print()
        {
            return $" {Name}-{Age}.";
        }

    }

    
    class Program
    {
        static void Main(string[] args)
        {

            var perClass1 = new PersonClass();
            var perClass2 = new PersonClass();

            var perStruct1 = new PersonStruct();
            var perStruct2 = new PersonStruct();

            perClass1.Age = 1;
            perClass1.Name = "Class1";
            perClass2 = perClass1;
            perClass2.Age = 2;
            perClass2.Name = "Class2";

            perStruct1.Age = 11;
            perStruct1.Name = "Struct1";
            perStruct1.Rec = 12121;
            perStruct2 = perStruct1;
            perStruct2.Age = 12;
            perStruct2.Name = "Struct2";
            perStruct1.Rec = 12123;

            const long COUNT = 70000000;
            PersonStruct[] personStructs = new PersonStruct[COUNT];
            for (long i = 0; i < COUNT; i++)
            {
                personStructs[i] = perStruct1;
                personStructs[i].Rec=i;
            }

            PersonClass[] personClasses = new PersonClass[COUNT];
            for (long i = 0; i < COUNT; i++)
            {
                personClasses[i] = perClass1;
                personClasses[i].Rec = i; 

            }

            Console.WriteLine($"Class1 -- {perClass1.Print()}");
            Console.WriteLine($"Class2 -- {perClass2.Print()}");
            Console.WriteLine($"Struct1 -- {perStruct1.Print()}");
            Console.WriteLine($"Struct2 -- {perStruct2.Print()}");

            Console.ReadKey();
        }
    }
}
