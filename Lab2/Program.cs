using System;

namespace Lab2 // LAB 2 TASK 2 
{class Rect
    {
       
    protected int edge;
      
    public Rect()
        {
            edge = 0;
        }
 
        public Rect(int e)
        {
            Console.WriteLine("Введите размер квадрата\n");
            while (!int.TryParse(Console.ReadLine(), out e))                
            {
                Console.WriteLine("Ошибка ввода! Введите число e");
            }
            edge = e;
        }
 
        public int Edge
        {
            get { return edge; }
            set { edge = value; }
        }
 
        public virtual string Info()
        {
            return string.Format("Квадрат {0}x{0}", edge); 
        }
 
        public virtual int Area()
        {
            return edge * edge;
        }
 
        public int Perimeter()
        {
            return 4 * edge;
        }
 
        public double Diagonal()
        {
            return Math.Sqrt(2*edge*edge);
        }
    };
 
    class Cube : Rect
    {
        public Cube() : base()
        {
        }
 
        public Cube(int e) 
        {
            Console.WriteLine("Введите высоту правильной квадратной призмы\n");
            
            while (!int.TryParse(Console.ReadLine(), out e))
            {
                Console.WriteLine("Ошибка ввода! Введите число e");
            }
            edge = e;
        }
 
        public override string Info()
        {
            return string.Format("Куб {0}x{0}x{0}", Edge);
        }
 
        public override int Area()
        {
            return base.Area()*edge;
        }
    }
 
    class Program
    {
        static void Main(string[] args)
        {
 
            Rect r1 = new Rect(10);
 
            Console.WriteLine(r1.Info());
            Console.WriteLine("Площадь {0}", r1.Area());
            Console.WriteLine("Периметр {0}", r1.Perimeter());
            Console.WriteLine("Диагональ {0}", r1.Diagonal());
 
            Cube cube = new Cube(5);
 
            Console.WriteLine(cube.Info());
            Console.WriteLine("Площадь {0}", cube.Area());
            Console.WriteLine("Периметр {0}", cube.Perimeter());
            Console.WriteLine("Диагональ {0}", cube.Diagonal());
 
            Console.ReadKey();
        }
    }
}
