using System;
using System.Collections.Generic;
using System.Text;

namespace Displej_Mrázek
{
    class Element
    {
        public int X { get; set; } //osa x


        public int Y { get; set; } // osa y

        public int Length { get; set; } //nastaví délku řádku

        public string Forecolor { get; set; } //barva textu(foreground)
        public string Backcolor { get; set; } // barba pozadí(backgound)

        public object Object { get; set; } //nastaví text

        public Element(int length, int x, int y, object @object, string forecolor, string backcolor) //konstruktor
        {

            X = x;
            Y = y;
            Length = length;
            Forecolor = forecolor;
            Backcolor = backcolor;
            Object = @object;
        }



        public int SetLength() //metoda, díky který můžu nastavit délku řádku
        {
            return Length;
        }
        public int SetX() //metoda, díky který můžu nastavit pozici curzoru na x
        {
            return X;
        }

        public int SetY() //metoda, díky který můžu nastavit pozici curzoru na y
        {
            return Y;
        }

        public string SetForeColor() //metoda, díky který můžu nastavit barvu textu
        {
            return Forecolor;
        }

        public string SetBackColor() //metoda, díky který můžu nastavit barvu pozadí
        {
            return Backcolor;
        }

        public object SetObject() //metoda, díky který můžu psát
        {
            return Object;
        }
    }
}
