using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            class1.CallClass();
            ExampleClass eclass = new ExampleClass("Egem");
            //eclass.Degisken1 = "Try";
            //Console.WriteLine(eclass.Degisken1);
            eclass.Id = 0;
            eclass.Add();
            eclass.Update();
        }
    }
    class ExampleClass : TryingClass, MyInterface, IMyInterface2
    {
        public ExampleClass(string name)
        {
            Degisken1 = name;
            
        }
        public string Degisken1 {  get; set; }

        public void Add()
        {
            Console.WriteLine("trying interface method");
        }

        public void Add2()
        {
            Console.WriteLine("Interface trying 2");
        }
    }

    public interface MyInterface
    {
        //Property ya da method tutuculardır
        void Add();
        
    }
    public interface IMyInterface2
    {
        void Add2();
    }

    class TryingClass
    {
        public int Id { get; set; }
        public void Update()
        {
            Console.WriteLine("update method is working.");
        }
    }
}
