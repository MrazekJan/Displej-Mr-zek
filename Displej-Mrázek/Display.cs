using System;
using System.Collections.Generic;
using System.Text;

namespace Displej_Mrázek
{
    class Display
    {
        protected Label[] _label = new Label[1]; //pole Label- prázdný
        protected Element[] _element = new Element[1]; //pole element- prázdný
        protected int elementX = 1;
        protected int labelX = 1;
        protected string radek = "";
        protected string radek2 = "";

        public Display() //když tohle dám pryč, tak se console chová hodně divně
        {

        }

        public void ClearScreen()
        {
            Console.Clear(); //vymaže celou obrazovku
        }

        public void RepaintScreen() // vykleslí Label a Element 
        {
            foreach (var a in _element)
            {
                Console.SetCursorPosition(a.X, a.Y);
                for (int i = 1; i < a.Length; i++)
                {
                    radek = radek + " ";
                }
                Console.Write(radek);
                Console.SetCursorPosition(a.X, a.Y);
                Console.Write(a.Object);


            }

            foreach (var a in _label)
            {

                Console.SetCursorPosition(a.X, a.Y);
                for (int i = 1; i < a.Length; i++)
                {
                    radek2 = radek2 + " ";
                }
                Console.Write(radek2);
                Console.SetCursorPosition(a.X, a.Y);
                Console.Write(a.Text);

            }


        }
        public void Clear() //vymaže obě pole
        {
            Array.Clear(_label, 0, _label.Length);
            Array.Clear(_element, 0, _element.Length);
        }

        public void AddElement(Element element) //funkce AddElement
        {

            if (elementX == 1)
            {
                _element[0] = element;
                elementX++;
            }

            else
            {

                Element[] _elpole = new Element[_element.Length + 1];
                for (int i = 0; i < _element.Length; i++)
                {
                    _elpole[i] = _element[i];
                }

                _elpole[_elpole.Length - 1] = element;
                _element = _elpole;


            }

            for (int b = 0; b < _element.Length; b++)
            {

                Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), _element[b].SetForeColor());
                Console.BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), _element[b].SetBackColor());

            }
        }

        public void AddLabel(Label label)
        {

            if (labelX == 1)
            {
                _label[0] = label;
                labelX++;
            }

            else
            {

                Label[] _lepole = new Label[_label.Length + 1];
                for (int i = 0; i < _label.Length; i++)
                {
                    _lepole[i] = _label[i];
                }

                _lepole[_lepole.Length - 1] = label;
                _label = _lepole;

            }
        }
     }
}
