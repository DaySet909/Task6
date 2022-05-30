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
            int oneRaw = 3;
            int raws;
            int overPictures;

            raws = pictures / oneRaw;
            overPictures = pictures - raws * oneRaw;

            Console.WriteLine("Всего картинок: " + pictures);
            Console.WriteLine("Полностью заполненых рядов: " + raws);
            Console.WriteLine("Картинок сверх меры: " + overPictures);

        }
    }
}
