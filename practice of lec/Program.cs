using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_of_lec
{
    class person
    {//Strat of person class
        public String getname(String name)
        {//Start of get name fuction
           
            return name;

        }//end of get name function
        public int getage(int age)
        {//Start of get age function
           
            return age;
        }//end of getage function
    }//End of person class
    class child
    {//start of child class
        public String getname(String name)
        {//Start of get name fuction

            return name;

        }//end of get name function
        public int getage(int age)
        {//Start of get age function

            return age;
        }//end of getage function

    }//end of child class
    class Program
    {
        static void Main(string[] args)
        {
            person obj = new person();
            child obj1=new child();
           String name=  obj.getname("hassan");
           int age = obj.getage(22);
           String nameChild = obj1.getname("khan");
           
           int ageChild = obj1.getage(22);
           Console.WriteLine("comparing Names");
           Console.WriteLine(name.Equals(nameChild));
           //name = nameChild;
          Console.WriteLine( "Output of refrence equals : " + ReferenceEquals(name, nameChild));
          name = nameChild;
          Console.WriteLine("Output of refrence equals after  : " + ReferenceEquals(name, nameChild));
           Console.WriteLine("comparing Ages");
           Console.WriteLine(age.Equals(ageChild));
           int age1 = obj.getage(21);
           Console.WriteLine("When Ages are not equal  "+age1.Equals(ageChild));
           Console.ReadLine();
        }
    }
}
