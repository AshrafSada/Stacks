using static System.Console;

namespace Stacks.AsDataStructures
{
    public static class Program
    {
        // Stack Data Structure
        private static void Main()
        {
            // Initialize a Stack
            Stack<string> myStack = new Stack<string>();
            Dump(myStack);

            // Push data to my stack
            myStack.Push("Hello");
            myStack.Push("World");
            myStack.Push("!");

            // display stack items
            Dump(myStack);

            // pop (last item by default)
            myStack.Pop();
            Dump(myStack);
           
        }

        private static void Dump(IEnumerable<string> stringCollection)
        {
            WriteLine("------------------");
            WriteLine("What's in the stack?:");
            foreach (var item in stringCollection) {
                Write("             {0}", item);
            }
            WriteLine("");
            WriteLine("------------------");
        }
    }
}
