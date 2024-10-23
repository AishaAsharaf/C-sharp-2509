using ConsoleAppInheritance;

public class Program
{
    public static void Main(string[] args)
    {   
        
        //for multilevel inheritance
        //Features feature = new Features("Toyota","Sam","Chennai");


        //Console.WriteLine(feature.Location);
        //Console.WriteLine("----------");
        //Console.WriteLine(feature.FirstName);
        //Console.WriteLine("----------");
        //Console.WriteLine(feature.Company);
        
        //feature.features();


        //Console.ReadLine();


        //For hierarchy inheritance
        //A_Hierarchial a = new A_Hierarchial();
        //a.A();
        //Console.WriteLine("----------");
        //B_Class b = new B_Class();
        //b.B();
        //Console.WriteLine("----------");
        //C_Class c = new C_Class();
        //c.C();


        //For interface
        //Class2 a = new Class2();
        //a.test();
        //B b = new B();
        //b.test();
        //Console.ReadLine();


        //Class2 example1 = new Class2();
        //Class2 example2 = new Class2();
        //Class2 example3 = new Class2("Pooh");
        //Console.WriteLine(example1);
        //Console.WriteLine("-----------");
        //Console.WriteLine(example2);
        //Console.WriteLine("-----------");
        //Console.WriteLine(example3);
        //Class2.Add(3 , 4);
        //Console.ReadLine();

        //OverLoading overLoading = new OverLoading();
        //overLoading.Details("Sam");
        //Console.WriteLine("------");
        //overLoading.Details("Sam",23);
        //Console.WriteLine("------");
        //overLoading.Details("Sam", "Delhi");

        //Console.WriteLine("------");
        //overLoading.Details("Sam",23,"Delhi");
        //Console.WriteLine("------");
        //Console.ReadLine();

        OperatorLoad load = new OperatorLoad(2,4);
        
        load = +load;
        load.Print();
        Console.ReadLine();




    }
}