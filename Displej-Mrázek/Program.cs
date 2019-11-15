using System;

namespace Displej_Mrázek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowHeight = 50;
            Console.WindowWidth = 150;
            Display display = new Display();
            Label label = new Label(6, 65, 1, "Nadpis");
            Label label2 = new Label(6, 62, 9, "Nadpis číslo 2");
            Element element = new Element(9, 2, 4, "Druhý", "Black", "Blue");
            Element element2 = new Element(2, 2, 2, "První", "Black", "Blue");
            display.AddLabel(label);
            display.AddLabel(label2);
            display.AddElement(element);
            display.AddElement(element2);
            display.RepaintScreen();
            //display.ClearScreen();
            //display.Clear();
        }
    }
}
