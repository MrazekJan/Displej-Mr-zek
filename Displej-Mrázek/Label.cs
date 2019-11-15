using System;
using System.Collections.Generic;
using System.Text;

namespace Displej_Mrázek
{
    class Label
    {
        public int X { get; set; } //osa x
        public int Y { get; set; } // osa y

        public int Length { get; set; } ////nastaví délku řádku
        public int LengthX { get; set; } //nastaví šířka concole

        public int LengthY { get; set; } //nastaví výška console
        public object Text { get; set; } // nastaví text


        public Label(int length, int x, int y, string text) //konstruktor
        {
            X = x;
            Y = y;
            Length = length;
            Text = text;

        }

        public int SetLength()
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

        public object SetText() //metoda, díky který můžu psát
        {
            return Text;
        }
    }
}
