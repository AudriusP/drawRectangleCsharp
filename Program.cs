using System;

namespace drawRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = 0;
            int heigth = 0;

            Console.WriteLine("Ener rectangle width: ");
            width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ener rectangle heigth: ");
            heigth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Width: " + width + " Heigth: " + heigth);

            for (int line = 1; line < heigth + 1; line++) {
                for (int column = 1; column < width + 1; column++) {
                    if(line == heigth || line == 1 || column == 1 || column == width) {
                        Console.Write("#");
                    } else {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
