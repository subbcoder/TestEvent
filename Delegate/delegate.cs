using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{    
    
    delegate void Message(int x, string text);



    public class delegate1
    {        

        enum Method
        {
            Select,
            Bubble,
            Insertion
        }

        enum DayTime
        {
            Morning,
            Afternoon,
            Evening,
            Night
        }

        public static void Hello(int x, string text) => Console.WriteLine($"Static method | Hello  x = {x} : text = {text}");
        public static void HowAreYou(int x, string text) => Console.WriteLine($"Static method | How are you? x = {x} : text = {text}");


        public void Hello2(int x, string text) => Console.WriteLine($"Hello x = {x} : text = {text}");
        public void HowAreYou2(int x, string text) => Console.WriteLine($"How are you? x = {x} : text = {text}");

        const Method method = Method.Bubble;

    }
}
