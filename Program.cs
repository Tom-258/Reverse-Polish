using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Polish
{
    public class ReversePolish
    {
        private Stack<object> _myStack;

        public ReversePolish(Stack<object> stack)
        {
            _myStack = stack;
        }
        private int Multiply(int firstNum, int secondNum)
        {
            return firstNum * secondNum;
        }

        private int Add(int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }

        private int Subtract(int firstNum, int secondNum)
        {
            return firstNum - secondNum;
        }

        private int Divide(int firstNum, int secondNum)
        {
            return firstNum / secondNum;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Run();
        }
        private static void Run()
        {
            //Creates a new instance of the Stacks class
            var stack = new Stack<object>();
            
            while (true)
            {
                Console.WriteLine("Push, Pop or Exit?");
                //Takes an input from the user to decide what method to run from the stacks class
                var selector = Console.ReadLine();
                //A switch block allows for simple execution of Stacks internal methods and makes the code unbreakable
                switch (selector)
                {
                    case "Push":
                        stack = InputValue(stack); //Separated the inputting of a value to be pushed into a separate method so that the push method cannot be directly accessed. This also means that the switch block is not cluttered with code.
                        break;
                    case "Pop":
                        Console.WriteLine(stack.Pop());
                        break;
                    case "Exit":
                        throw new Exception("Program Terminated");
                    default: //This default block makes the code unbreakable
                        Console.WriteLine("Invalid Entry");
                        continue;
                }
            }
        }
        static Stack<object> InputValue(Stack<object> localStack)
        {
            while (true)
            {
                Console.WriteLine("Add an item to the stack: Leave null or whitespace to stop adding to the stack.");
                var input = Console.ReadLine();
                int number;
                if (string.IsNullOrWhiteSpace(input)) break;
                
                var catcher = int.TryParse(input, out number);
                if (catcher == true)
                    localStack.Push(Convert.ToInt32(input));
                else
                {
                    localStack.Push(input);
                }
            }

            return localStack;
        }
    }
}
