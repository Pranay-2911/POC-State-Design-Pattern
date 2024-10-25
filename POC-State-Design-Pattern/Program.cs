using POC_State_Design_Pattern.Models;

namespace POC_State_Design_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("============= POC For State Design Pattern ============= \n");

            Console.WriteLine($"The State Design Pattern allows an object to change its behavior\n" +
                $"Whenever there is object which change its Behavior we use the State Design Pattern\n" +
                $"Let Take An example of Gaming Character\n");

            Console.WriteLine("------------------------------------------------------------------------");
            Character character = new Character();
            character.GetState();
            Console.WriteLine();

            character.HandleInput("walk"); 
            character.GetState(); 
            Console.WriteLine();

            character.HandleInput("run"); 
            character.GetState();
            Console.WriteLine();

            character.HandleInput("attack"); 
            character.GetState();
            Console.WriteLine();

            character.HandleInput("idle"); 
            character.GetState();
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------");

            Console.WriteLine($"In this example the Character's actions (Idle, Walk, Run, Attack) \n" +
                $"Where its depend on its current state, and each state defines specific behavior\n\n" +
                $"Where to use this design pattern :- Whenever there is an object behavior depends on its state\n\n" +
                $"Adavantages\n" +
                $"Simplifies state-based behavior by encapsulating each state in a separate class\n" +
                $"Makes it easy to add new states without modifying existing code\n\n" +
                $"Disadvantages\n" +
                $"May increase the number of classes, as each state is a separate class\n") ;




        }
    }
}
