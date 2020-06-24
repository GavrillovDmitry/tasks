using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ArrayStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> s = new Stack<int>();
            bool f = true;
            Console.WriteLine("Выберите действия: \n\t0-вывести наш стек \n\t1-добавить в стек, \n\t2-извлечь из стека, \n\t3-закончить работу");
            while (f)
            {
                int c, x;
                c = Convert.ToInt32(Console.ReadLine());
                switch (c)
                {
                    case 0:
                        s.Show();
                        break;
                    case 1:
                        Console.WriteLine("Введите добавляемое значение ");
                        x = Convert.ToInt32(Console.ReadLine());

                        s.Push(x);
                        Console.WriteLine("Добавлено значение " + x);

                        break;
                    case 2:
                        if (s.IsEmpty())
                            Console.WriteLine("Стек пуст");
                        else
                            Console.WriteLine("Удалено значение " + s.Pop());

                        break;
                    case 3:
                        f = false;
                        break;
                }
            }
        }
    }
}

