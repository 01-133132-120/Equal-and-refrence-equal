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
        public void Coalesce()//start function Coalesce
        {
            Console.WriteLine("IMPLEMENT COALESCE");
           int  ? num1=null;
           int num2 = 100;
           Console.WriteLine("output");
           Console.WriteLine(num1??num2);
           Console.WriteLine("IMPLEMENT SIZEOF");
           Console.WriteLine(sizeof(int));

        }//end function Coalesce
        public void check()
        {
            byte num =255 ;
            unchecked
            {
                Console.WriteLine("number"+ num++);
                
            }
        }
       

    }//end of child class
    enum info
    {
        hassan,
        khan
        
    };
    
        

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

           //Coalesce function call;
            
           obj1.Coalesce();

            //Enum
           //days names =days.name;
          /* string getname =((days)0).ToString();
            string getclass=((days)1).ToString();
            int getage=(int)((days)2);
            Console.WriteLine("enter name");
            getname = Console.ReadLine();
            Console.WriteLine("enter class");
            getclass = Console.ReadLine();
            Console.WriteLine("enter age");
            getage = Convert.ToInt32(Console.ReadLine());
            if (getname == "hassan")
            {
                Console.WriteLine("correct name entered");
            }
            else
            {
                Console.WriteLine("sorry");
            }
            if (getclass == "bse")
            {
                Console.WriteLine("correct class entered");
            }
            else
            {
                Console.WriteLine("sorry");
            }

            if (getage == 20)
            {
                Console.WriteLine("correct age entered");
            }
            else
            {
                Console.WriteLine("sorry");
            }*/

           Console.WriteLine("ENUM IMPLIMENTATION");
           info infoobj = info.hassan;
           info infoobj1 = info.khan;
            Console.Write( infoobj);
            Console.Write(infoobj1);
            Console.WriteLine();
            //check
            Console.WriteLine("UNCHECKED IMPLIMENTATION");
            obj1.check();
          
           Console.ReadLine();
        }
    }
}
