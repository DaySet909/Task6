using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            int pictures = 52;
            int picturesInRow = 3;
            int fullRows;
            int overPictures;

            fullRows = pictures / picturesInRow;
            overPictures = pictures % picturesInRow;

            Console.WriteLine("Всего картинок: " + pictures);
            Console.WriteLine("Полностью заполненых рядов: " + fullRows);
            Console.WriteLine("Картинок сверх меры: " + overPictures);

        }
    }
}
