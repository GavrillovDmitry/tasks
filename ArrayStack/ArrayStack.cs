using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayStack
{
    public class Stack<S>
    {
        public S[] array;
        public int count { get; set; }
        const int n = 1;
        public Stack()
        {
            array = new S[n];
        }
        public Stack(int length)
        {
            array = new S[length];
        }
        public bool IsEmpty()
        {
            return count == 0; 
        }
        public int Count
        {
            get { return count; }
        }

        public void Push(S item)
        {
            // увеличиваем стек
            if (count == array.Length)
                Resize(array.Length + 10);

            array[count++] = item;
        }
        public S Pop()
        {
            // если стек пуст, выбрасываем исключение
            if (IsEmpty())
                throw new StackException("Стек пуст");
            S item = array[--count];
            array[count] = default(S); // сбрасываем ссылку

            if (count > 0 && count < array.Length - 10)
                Resize(array.Length - 10);

            return item;
        }
        public void Show()
        {
            if (IsEmpty())  
                throw new StackException("Стек пуст");

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    
        public S Peek()
        {
            return array[count - 1];
        }

        private void Resize(int max)
        {
            S[] tempArray = new S[max];
            for (int i = 0; i < count; i++)
                tempArray[i] = array[i];
            array = tempArray;
        }

    }
}
