using System;

namespace HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i <= 12; i++)
            //{
            //    for (int j = 1; j <= 10; j++)
            //    {
            //        Console.WriteLine($"{i} x {j} = {i * j}");
            //    }
            //    Console.WriteLine();
            //}


            //for (int i = 1; i <= 12; i++)
            //{
            //    int j = 1;
            //    while (j <= 10)
            //    {
            //        Console.WriteLine($"{i} x {j} = {i * j}");
            //        j++;
            //    }
            //    Console.WriteLine();
            //}


            //int i = 1;
            //while (i <= 12)
            //{
            //    int j = 1;
            //    while (j <= 10)
            //    {
            //        Console.WriteLine($"{i} x {j} = {i * j}");
            //        j++;
            //    }
            //    Console.WriteLine();
            //    i++;
            //}


            //double x1, y1, x2, y2, x3, y3, x4, y4;
            //double area;
            //Console.Write("x1 = ");
            //x1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("y1 = ");
            //y1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("x2 = ");
            //x2 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("y2 = ");
            //y2 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("x3 = ");
            //x3 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("y3 = ");
            //y3 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("x4 = ");
            //x4 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("y4 = ");
            //y4 = Convert.ToDouble(Console.ReadLine());

            //area = ((x1 - x2) * (y1 + y2)) / 2;
            //area += ((x2 - x3) * (y2 + y3)) / 2;
            //area += ((x3 - x4) * (y3 + y4)) / 2;
            //area += ((x4 - x1) * (y4 + y1)) / 2;
            //area = Math.Abs(area);

            //Console.WriteLine($"The area is {area}.");


            double x1, y1, x2, y2, firstx, firsty;
            double area = 0;
            int vertices;

            Console.WriteLine("How many vertices does the polygon have?");
            vertices = Int32.Parse(Console.ReadLine());
            
            if (vertices >= 3)
            {
                Console.Write($"x1 = ");
                x1 = Convert.ToDouble(Console.ReadLine());
                Console.Write($"y1 = ");
                y1 = Convert.ToDouble(Console.ReadLine());

                firstx = x1;
                firsty = y1;

                for (int i = 2; i <= vertices; i++)
                {
                    Console.Write($"x{i} = ");
                    x2 = Convert.ToDouble(Console.ReadLine());
                    Console.Write($"y{i} = ");
                    y2 = Convert.ToDouble(Console.ReadLine());
                    area += ((x1 - x2) * (y1 + y2)) / 2;

                    x1 = x2;
                    y1 = y2;
                }

                x2 = firstx;
                y2 = firsty;
                area += ((x1 - x2) * (y1 + y2)) / 2;

                area = Math.Abs(area);
                Console.WriteLine($"The area is {area}.");
            }
            else
            {
                Console.WriteLine("This is not enough vertices for a polygon.");
                return;
            }

        }
    }
}
