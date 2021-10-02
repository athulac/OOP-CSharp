using OOPLibrary;
using System;

namespace OOP
{
    class Program
    {
        public void MainFunction()
        {
            Console.WriteLine("Main class");
        }

        static void Main(string[] args)
        {
            try
            {
               // Polymorphism
                hrDepart obj1 = new hrDepart();
                itDepart obj2 = new itDepart();
                financeDepart obj3 = new financeDepart();

                obj1.LeaderName();
                obj2.LeaderName();
                obj3.LeaderName();


               // Interface
                testi obji = new testi();
                obji.methodA();
                obji.methodB();

                //Abstract Classes
                // class instance
                new test().displayData();

                //Hiding Methods
                // class instance
                new myDerivedh().VirtualMethod();
                Console.ReadKey();


                //Virtual Methods
                // class instance
                new myDerived().VirtualMethod();
                Console.ReadKey();

                //Constructor in Inheritance
                //Here Child object can access both class methods
                Child cObja = new Child();
                cObja.FatherMethod();
                cObja.ChildMethod();
                Console.ReadKey();
                Father fObja = new Father();
                fObja.FatherMethod();

                //Inheritance
                //Here Child object can access both class methods
                Child cObj = new Child();
                cObj.FatherMethod();
                cObj.ChildMethod();


                //Function Overloading
                funOverload objo = new funOverload();

                objo.setName("barack");
                objo.setName("barack ", " obama ");
                objo.setName("barack ", "hussian", "obama");


                //Destructors
                //instance created
                customerDestruct objdc = new customerDestruct();
                objdc.getData();

                

                //Constructor and Destructor
                // object instantiation
                student objs = new student("Barack", "Obama");
                //Method calling
                objs.AppendData();
                //Static Constructor
                teacher.getData();


                //Encapsulation
                //library class instance
                //Creating and accessing Class Component Library
                MathLib objl = new MathLib();

                //method populate
                objl.calculareSum(2, 5);
                objl.calculareSqrt(25);


                //Static classes
                //function calling directly
                staticDemo.calcute();

                //Partial classes
                //partial class instance
                partialclassDemo objp = new partialclassDemo();
                objp.method1();
                objp.method2();

                //main class instance
                Program objd = new Program();
                objd.MainFunction();

                //Multiple Class Declaration
                //other class instace
                demo dObjd = new demo();
                dObjd.addition();

                // object instantiation
                customer obj = new customer();

                //Method calling
                obj.displayData();

                //fields calling
                Console.WriteLine(obj.CustID);
                Console.WriteLine(obj.Name);
                Console.WriteLine(obj.Address);


                Console.WriteLine("Hello World!");
                Console.ReadKey();
            }
            catch (Exception ex)
            {

                throw;
            }
          
        }
    }

    //Polymorphism
    public abstract class Employee
    {
        public virtual void LeaderName()
        {
        }
    }

    public class hrDepart : Employee
    {
        public override void LeaderName()
        {
            Console.WriteLine("Mr. jone");
        }
    }
    public class itDepart : Employee
    {
        public override void LeaderName()
        {
            Console.WriteLine("Mr. Tom");
        }
    }

    public class financeDepart : Employee
    {
        public override void LeaderName()
        {
            Console.WriteLine("Mr. Linus");
        }
    }

    // interface
    public interface ixyz
    {
        void methodA();
        void methodB();
    }

    // interface method implementation
    class testi : ixyz
    {
        public void methodA()
        {
            Console.WriteLine("methodA");
        }
        public void methodB()
        {
            Console.WriteLine("methodB");
        }
    }


    //Sealed Classes
    sealed class SealedClass
    {
        void myfunv()
        {
            Console.Write("sealed class method");
        }
    }

    public class tests// : SealedClass //wrong. will give compilation error
    {
        SealedClass sealedClass = new SealedClass();
        //sealedClass.myfunv();
    }

    //abstract class
    public abstract class Employess
    {
        //abstract method with no implementation
        public abstract void displayData();
    }

    //derived class
    public class test : Employess
    {
        //abstract class method implementation
        public override void displayData()
        {
            Console.WriteLine("Abstract class method");
        }
    }

    //Hiding Methods
    class myBaseh
    {
        //virtual function
        public virtual void VirtualMethod()
        {
            Console.WriteLine("virtual method defined in the base class");
        }
    }

    class myDerivedh : myBaseh
    {
        // hiding the implementation of base class method
        public new void VirtualMethod()
        {
            Console.WriteLine("virtual method defined in the Derive class");

            //still access the base class method
            base.VirtualMethod();
        }
    }


    //Virtual Methods
    class myBase
    {
        //virtual function
        public virtual void VirtualMethod()
        {
            Console.WriteLine("virtual method defined in the base class");
        }
    }

    class myDerived : myBase
    {
        // redifing the implementation of base class method
        public override void VirtualMethod()
        {
            Console.WriteLine("virtual method defined in the Derive class");
        }
    }


    //Base Class
    public class Fathera
    {

        //constructor
        public Fathera()
        {
            Console.WriteLine("Father class constructor");
        }

        public void FatherMethod()
        {
            Console.WriteLine("this property belong to Father");
        }
    }

    //Derived class
    public class Childa : Fathera
    {
        public Childa() : base()
        {
            Console.WriteLine("child class constructor");
        }
        public void ChildMethod()
        {
            Console.WriteLine("this property belong to Child");
        }
    }

    //Inheritance
    //Constructor in Inheritance
    //Base Class
    public class Father
    {
        public void FatherMethod()
        {
            Console.WriteLine("this property belong to Father");
        }
    }

    //Derived class
    public class Child : Father
    {
        public void ChildMethod()
        {
            Console.WriteLine("this property belong to Child");
        }
    }


    //Function Overloading
    class funOverload
    {
        public string name;

        //overloaded functions
        public void setName(string last)
        {
            name = last;
        }

        public void setName(string first, string last)
        {
            name = first + "" + last;
        }

        public void setName(string first, string middle, string last)
        {
            name = first + "" + middle + "" + last;
        }

    }

    //Destructors
    class customerDestruct
    {
        // Member Variables
        public int x, y;
        //constuctor for  initializing fields
        public customerDestruct()
        {
            Console.WriteLine("Fields inititalized");
            x = 10;
        }
        //method for get field
        public void getData()
        {
            y = x * x;
            Console.WriteLine(y);
        }
        //method to release resource explicitly
        public void Dispose()
        {
            Console.WriteLine("Fields cleaned");
            x = 0;
            y = 0;
        }
        //destructor
        ~customerDestruct()
        {
            Dispose();
        }

    }

    //Static Constructor
    class teacher
    {
        // Member Variables
        static private int x;

        //constuctor for static initializing fields
        static teacher()
        {
            x = 10;
        }
        //method for get  static field
        static public void getData()
        {
            Console.WriteLine(x);
        }
    }
    //Constructor and Destructor
    class student
    {
        // Member Variables
        public string Name;

        //constuctor for initializing fields
        public student(string fname, string lname)
        {
            Name = fname + " " + lname;
        }
        //method for displaying customer records
        public void AppendData()
        {
            Console.WriteLine(Name);
        }

    }

    //Static classes
    static class staticDemo
    {
        //static fields
        static int x = 10, y;

        //static method
        public static void calcute()
        {
            y = x * x;
            Console.WriteLine(y);
        }
    }

    //Partial classes
    public partial class partialclassDemo
    {
        public void method2()
        {
            Console.WriteLine("method from part2 class");
        }
    }
    public partial class partialclassDemo
    {
        public void method1()
        {
            Console.WriteLine("method from part1 class");
        }
    }

    //Multiple Class Declaration
    class demo
    {
        int x = 10;
        int y = 20;
        int z;

        public void addition()
        {
            z = x + y;
            Console.WriteLine("other class in Namespace");
            Console.WriteLine(z);
        }
    }

    class customer
    {
        // Member Variables
        public int CustID;
        public string Name;
        public string Address;

        //constuctor for initializing fields       
        public customer()
        {
            CustID = 1101;
            Name = "Tom";
            Address = "USA";
        }

        //method for displaying customer records (functionality)
        public void displayData()
        {
            Console.WriteLine("Customer=" + CustID);
            Console.WriteLine("Name=" + Name);
            Console.WriteLine("Address=" + Address);
        }
        // Code for entry point
    }


}
