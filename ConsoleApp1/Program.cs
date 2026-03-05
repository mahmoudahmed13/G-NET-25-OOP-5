using System.Diagnostics.Metrics;
using System.IO;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 : Theoretical Questions

            #region Question01

            //Q1: What is an interface in C#?
            //=>> A contract that a class must follow.
            //Why do we use interfaces instead of depending on concrete classes directly?
            //when you need multiple inheritance behavior and loose coupling.
            //Mention at least three benefits of using interfaces.
            //loose coupling, easy to extend , easy to test.

            #endregion

            #region Question02
            //interface IEnglishSpeaker
            //{
            //    void Greet();
            //}

            //interface IArabicSpeaker
            //{
            //    void Greet();
            //}

            //class Translator : IEnglishSpeaker, IArabicSpeaker
            //{
            //    public void Greet()
            //    {
            //        Console.WriteLine("Hello / Ahlan");
            //    }
            //}

            //a) What is the problem with this design? => method name conflict
            //Both interfaces have a method called Greet() — how does the class handle it currently?
            //Use Explicit Interface Implementation
            //b) How would you fix this so IEnglishSpeaker.Greet() says "Hello" and IArabicSpeaker.Greet() says "Ahlan"? What is this technique called?
            //Explicit Interface Implementation
            //c) After applying your fix, can you call Greet() directly on a Translator object (e.g.translator.Greet())?
            //Why or why not? How do you call each version?
            //No,You must use interface reference only from its interface class to call explicit members

            #endregion

            #region Question03
            //Q3: Explain the difference between a shallow copy and a deep copy.When would you use each one?
            //What is the risk of using a shallow copy when the object has reference - type fields ?
            //Sallow Copy: copy object but copies inner reference vs Deep Copy: copy object with nested copies refrences.
            //Becuase Shallow Copy is immutable, no nested reference state. Shared
            #endregion

            #endregion
        }
    }
}
