using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Undervisning3
{
    public class Person
    {
        //Egenskaper som beskriver objektet
        //Ting objektet kan inneholde/ eie
        public string Name { get; set; }
        public int Age { get; set; }
        public string HairColor { get; set; }

        public string[] BodyParts { get; set; }

        public Person()
        {

        }
        public Person(string name,int age)
        {
            Name = name;
            Age = age;
        }

        public Person(string name, int age, string hairColor)
        {
            Name = name;
            Age = age;
            HairColor = hairColor;
        }

        //Hva kan objektet gjøre? 
        public void IntroduceSelf()
        {
            Console.WriteLine($"Hi, my name is {Name}, and i am {Age} years old");
        }
        public void Run(string pace = "slow")
        {
            Console.WriteLine($"I am running {pace}");
        }
        public void Complain()
        {

        }

    }
}
