using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PackageButton;
using ButtonLight;
using LightDLL;

namespace Testeur
{
    class Testeur
    {
        public static void Main(string[] args)
        {
            Light1 light1 = new Light1();
            Console.WriteLine("Light1 " + light1);
            Button button1 = new Button(light1);
            button1.Press();
            Console.WriteLine("Light1 " + light1);
            button1.Press();
            Console.WriteLine("Light1 " + light1);
            Light l1 = new Light();
            Link link1 = new Link(l1);
            Button button2 = new Button(link1);//todo creer un link
            button2.Press();
            Console.WriteLine("link1 " + link1);
            button2.Press();
            Console.WriteLine("link1 " + link1);

            Console.ReadKey();
        }
    }
}
