using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW2_WinAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();      
        }
        //Task1
        [DllImport("user32.dll")]        
        public static extern int MessageBox(IntPtr hWnd, string Text, string Caption, int Options);
        string name = string.Empty;
        string age = string.Empty;
        string profession = string.Empty;
        string location = string.Empty;

        private void btn_Info_Click(object sender, EventArgs e)
        {
            name = tb_Name.Text;
            age = tb_age.Text;
            profession = tb_profession.Text;
            location = tb_location.Text;

            MessageBox(IntPtr.Zero, name, "Ваше имя:", 0);
            MessageBox(IntPtr.Zero, age, "Ваш возвраст:", 0);
            MessageBox(IntPtr.Zero, profession, "Ваша профессия:", 0);
            MessageBox(IntPtr.Zero, location, "Ваше место проживание:", 0);
        }
        //Task2   
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]       
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        const uint WM_CLOSE = 0x0010;
        const uint WM_SETTEXT = 0x000C;
        string nameWindow = string.Empty;
        string newNameWindow = string.Empty;

        private void btn_NameWindow_Click(object sender, EventArgs e)
        {
            nameWindow = tb_NameWindow.Text;
            IntPtr windowHandle = FindWindow(null, nameWindow);

            if (windowHandle != IntPtr.Zero)
            {               
                MessageBox(IntPtr.Zero, nameWindow, "Успешно найдено окно: ", 0);
            }
            else
            {
               MessageBox(IntPtr.Zero, nameWindow, "Не найдено окно: ", 0);
            }
        }
        private void btn_NewNameWindow_Click(object sender, EventArgs e)
        {
            newNameWindow = tb_NewNameWindow.Text;
            IntPtr windowHandle = FindWindow(null, nameWindow);

            if (windowHandle != IntPtr.Zero)
            {
                SendMessage(windowHandle, WM_SETTEXT, IntPtr.Zero, Marshal.StringToBSTR(newNameWindow));
                MessageBox(IntPtr.Zero, newNameWindow, "Заголовок окна изменен на: ", 0);
            }
            else
            {
                MessageBox(IntPtr.Zero, "Окно не найдено", "Ошибка", 0);
            }
        }
        private void btn_CloseWindow_Click(object sender, EventArgs e)
        {
            IntPtr windowHandle = FindWindow(null, newNameWindow);

            if (windowHandle != IntPtr.Zero)
            {                               
                MessageBox(IntPtr.Zero, newNameWindow, "Закрываем окно: ", 0);
                SendMessage(windowHandle, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
            }
            else
            {
                MessageBox(IntPtr.Zero, "Окно не найдено", "Ошибка", 0);
            }
        }

        //Task3
        [DllImport("kernel32.dll")]
        public static extern bool Beep(int frequency, int duration);

        [DllImport("user32.dll")]
        public static extern bool MessageBeep(uint uType);

        private void btn_SoundSignal_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            MessageBeep((uint)0x00000030L);
            Thread.Sleep(1000);
            for (int i = 0; i < 10; i++)
            {
                Beep(random.Next(500, 2500), random.Next(10, 30) * 10);
            }
        }
    }
}
