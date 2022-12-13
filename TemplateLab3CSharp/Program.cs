// See https://aka.ms/new-console-template for more information
using MyTask;

/// <summary>
///  Top-level statements 
///  Код програми (оператори)  вищого рівня
/// </summary>
/// 
Console.WriteLine("Hello, World!");
//
//  Приклад коду
//

Animal[] animals = new Animal[4];
animals[0] = new Animal();
animals[0].Name = "Bizon"; animals[0].WWeight=100;
Console.WriteLine(" my animal " + animals[0].ToString());
animals[1] = new Animal(100,10,"Cow");
animals[2] = new Animal(102, 12, "Cow Big");
animals[3] = new Animal(100, 10, "Zebra");

for(int i = 0; i < 4; i++)
{
    Console.WriteLine("  animal " + i + " " + animals[i].ToString());
}

Big b = new Big();
Console.WriteLine(" Big" + b +"   "+ b.ToString() + "  " + b.Name);

Console.WriteLine(" Task 2");
Task2.Run();
     

/// <summary>
///  Закічення  іструкцій верхнього рівня
/// Top-level statements must precede namespace and type declarations.
/// Оператори верхнього рівня мають передувати оголошенням простору імен і типу.
///   
/// </summary>
class Big
{
    private string name =" First init";
    public Big()
    {
        name = "NoName";
    }
    public Big(string name)
    {
        this.name = name;
        
    }
    public string Name { 
        get { return name; } 
        set { name = value; }
    }

};
namespace MyTask
{
    static class Task2
        {
       public  static void Run()
        {
            Drv d = new Drv("RRR");
            Console.WriteLine(" rrr  " + d.ToString());
        }
        }
    class Base
    {
        string NameBase;
        protected string any_Inform;
        int type = 0;
        public int numobj = 0;
        public Base() {
            NameBase = "Base";
            any_Inform = "";

        }
        public void Show()
        {
            Console.WriteLine(" Show Base " + NameBase);
        }
    };

    class Drv :  Base
    {
        Drv()
        {
            numobj = 10;
        }
       public Drv(string any_Inform)
        {
            numobj = 11;
            this.any_Inform = any_Inform;
        }
    }
}