using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prak5
{
    public class Numbers
    {
        int hasilmin;
        int hasilmax;

        // Method perbandingan number 1 dan number 2
        public int FindMinimum(int number1, int number2)
        {
            hasilmin = number1;             // Angka terkecil = number 1
            if (hasilmin > number2)         // Jika hasilmin lebih dari number 2, hasilmin = number 2 
                hasilmin = number2;
            return hasilmin;                // Mengembalikan nilai hasilmin
        }
        // Method perbandingan number 1, number 2 dan number 3
        public int FindMinimum(int number1, int number2, float number3)
        {
            hasilmin = number1;             // Angka terkecil = number 1
            if (hasilmin > number2)         // Jika hasilmin lebih dari number 2, hasilmin = number 2
                hasilmin = number2;
            if (hasilmin > (int)number3)    // Jika hasilmin lebih dari number 3, hasilmin = number 3
                hasilmin = (int)number3;
            return hasilmin;                // Mengembalikan nilai hasilmin
        }
        // Method perbandingan number 1 dan number 2
        public int FindMaximum(int number1, int number2)
        {
            hasilmax = number1;             // Angka terbesar = number 1
            if (hasilmax < number2)         // Jika hasilmax kurang dari number 2, hasilmax = number 2 
                hasilmax = number2;
            return hasilmax;                // Mengembalikan nilai hasilmax
        }
        // Method perbandingan number 1, number 2 dan number 3
        public int FindMaximum(int number1, int number2, float number3)
        {
            hasilmin = number1;             // Angka terbesar = number 1
            if (hasilmax < number2)         // Jika hasilmax kurang dari number 2, hasilmax = number 2
                hasilmax = number2;
            if (hasilmax < (int)number3)    // Jika hasilmax kurang dari number 3, hasilmax = number 3
                hasilmax = (int)number3;
            return hasilmax;                // Mengembalikan nilai hasilmax
        }
    }
}