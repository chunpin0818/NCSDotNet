//WAP to implement DLL Import Attribute – Unmanaged dll(user32.dll) to populate a message box  
//[DLLImport("user32.dll", EntryPoint = "MessageBox")]
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Q9.DDL_Import_Attribute
{
    class messageBox
    {
        // Import DLL Attribute with Message Box
        [DllImport("user32.dll", EntryPoint = "MessageBox")]
        public static extern int MessageBox(IntPtr hWnd, String text, String caption, uint type);

        static void Main()
        {
            MessageBox(new IntPtr(0), "Hello ! My name is JB :)", "Welcome", 0);
            Console.ReadKey();
        }
    }
}
