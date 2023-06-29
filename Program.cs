using System.Reflection;
using System.Runtime.InteropServices.ObjectiveC;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World!");

            //  PurchaseList.Orders();
            // Swap_Position.swapping();
            //DuplicateLetters.Counts("aaaajay");
            //Chapters.FindChapters();
            Quiz.FindtheNumber();

            //----------------TO FETCH THE REFLECTION DATA-------------------
            Console.WriteLine();
            Type types = typeof(Quiz);
            Console.WriteLine("------------Constructors----------");
            ConstructorInfo[] constructors = types.GetConstructors();
            Console.WriteLine("Constructor Length : "+constructors.Length);
            foreach (ConstructorInfo data in constructors) { Console.WriteLine(data.Name); }
            Console.WriteLine("------------Methods----------------");
            MethodInfo[] methods = types.GetMethods();
            Console.WriteLine("Methods Length : " + methods.Length);
            foreach (MethodInfo data in methods) { Console.WriteLine(data.Name); }
            Console.WriteLine("-------------Properties-----------------");
            PropertyInfo[] properties = types.GetProperties();
            Console.WriteLine("Properties Length : " + properties.Length);
            foreach (PropertyInfo data in properties) { Console.WriteLine(data.Name); }

            //---------------create an object using default constructor

            object newobject = Activator.CreateInstance(types);

            types.GetMethod("FindtheNumber").Invoke(newobject, null);

            ConstructorInfo getdata = types.GetConstructor(new Type[] { typeof(int) });
            object[] parameterr = {45};
            object invoking = getdata.Invoke(parameterr);

            Quiz Class = (Quiz)invoking;

           // Class.FindEvenDigitNumber();


        }
    }
}