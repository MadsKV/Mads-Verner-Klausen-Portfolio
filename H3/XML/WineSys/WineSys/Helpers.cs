using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WineSys
{
    class Helpers
    {
        public static String ReadPassword()
        {
            String m_result = "";
            ConsoleKeyInfo m_keyinfo;
            do
            {
                m_keyinfo = Console.ReadKey(true);
                if (m_keyinfo.Key == ConsoleKey.Backspace)
                {
                    if (m_result != "")
                    {
                        m_result = m_result.Remove(m_result.Length - 1);
                        Console.CursorLeft = Console.CursorLeft - 1;
                        Console.Write(" ");
                        Console.CursorLeft = Console.CursorLeft - 1;
                    }
                } else if (m_keyinfo.Key != ConsoleKey.Enter && m_keyinfo.Key != ConsoleKey.Escape)
                {
                    Console.Write("*");
                    m_result = m_result + m_keyinfo.KeyChar;
                }
            } while (m_keyinfo.Key != ConsoleKey.Enter && m_keyinfo.Key != ConsoleKey.Escape);
            if (m_keyinfo.Key == ConsoleKey.Escape)
                m_result = "";
            Console.WriteLine();
            return m_result;
        }
    }
}
