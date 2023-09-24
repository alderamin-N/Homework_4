using System.ComponentModel;
using System.Data;
using System.Runtime.InteropServices;
using System.Security.Claims;

namespace Homework_4
{


    class Stack
    {
        private List<string> myVault;
        public int Size
        {
            get
            { 
                return myVault.Count;
            }
        }

        public string Top
        {
            get 
            { 
                return myVault.LastOrDefault(); 
            }
        }

        public Stack(params string[] parametrs)
        {
            myVault = new List<string>(parametrs);
        }

        public void Add(string value)
        {
            myVault.Add(value);
        }

        public string Pop()
        {
            string lastValue = myVault.LastOrDefault();
            if (lastValue == null)
            {
                throw new InvalidOperationException("Стек пустой!");
            }
            myVault.Remove(lastValue);
            return lastValue;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Stack myStack = new Stack("a", "b","c");
            // size = 3, Top = 'c'
            Console.WriteLine($"size = {myStack.Size}, Top = '{myStack.Top}'");
            var deleted = myStack.Pop();
            // Извлек верхний элемент 'c' Size = 2
            Console.WriteLine($"Извлек верхний элемент '{deleted}' Size = {myStack.Size}");
            myStack.Add("d");
            // size = 3, Top = 'd'
            Console.WriteLine($"size = {myStack.Size}, Top = '{myStack.Top}'");
            myStack.Pop();
            myStack.Pop();
            myStack.Pop();
            // size = 0, Top = null
            Console.WriteLine($"size = {myStack.Size}, Top = {(myStack.Top == null ? "null" : myStack.Top)}");
            myStack.Pop();




        }
    }
}