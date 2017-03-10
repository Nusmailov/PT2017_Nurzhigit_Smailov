using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Solution3
{
    class Program
    {
        static void Show()
        {
            DirectoryInfo directory = new DirectoryInfo(@"G:\KBTU\2semestr\PT\Polygon");
            FileInfo[] files = directory.GetFiles();
            // DirectoryInfo[] directories = directory.GetDirectories();
            foreach (FileInfo fil in files)
            {
                Console.WriteLine(fil.Name);
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Show();
            Polygon b = new Polygon();

            /*for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(b[i].x, body[i].y);
            }*/
            Console.ReadKey();
        }
        public void getPerimeter(int x, int y)
        {
            int P = 2 * (x + y);
        }
    }
}
