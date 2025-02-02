using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SP_DZ1
{
    internal class Program
    {
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);

        static void Main(string[] args)
        {
            
            string name = "Васильев Игорь";
            string occupation = "Разработчик ПО";
            string hobby = "Программирование, чтение, спорт";

            // Отображение информации в нескольких MessageBox
            MessageBox(IntPtr.Zero, $"Имя: {name}", "Информация о вас", 0);
            MessageBox(IntPtr.Zero, $"Род занятий: {occupation}", "Информация о вас", 0);
            MessageBox(IntPtr.Zero, $"Увлечения: {hobby}", "Информация о вас", 0);
        }
    }
}
