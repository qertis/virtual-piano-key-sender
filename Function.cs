using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace KeySender
{
    class Function
    {
        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        //Находим сайт с Piano с открытой вкладкой с пианиной
        public bool FindSite()
        {
            foreach (var p in Process.GetProcesses())
                if (p.MainWindowTitle.Contains("Virtual Piano : The original app"))
                {
                    SetForegroundWindow(p.MainWindowHandle);
                    return true;
                }
            return false;
        }

        //Делаем нажатие клавиши
        public void SendKey(string key)
        {
            lock (key)
            {
                try
                {
                    SendKeys.Send(key);
                    SendKeys.Flush();
                    //or 
                    //SendKeys.SendWait(key);
                }
                //ИНОГДА ЗДЕСЬ ВОЗНИКАЕТ Эксепшион
                catch (Exception ex)
                {
                    return; //Несоответствие между числом групп и разделителей
                }
            }
        }
        
        public List<string> GetStr(string str)
        {
            var split = str.Split(' ', '\'', '-', '.', '|', ')');
            var temp = new List<string>();
            
            foreach (string s in split)
            {
                //Проверка на то, чтобы эти клавиши использовались именно как клавиши 
                //а не зарегистрированные виндой
                if (s == "^" || s == "%" || s == "*" || s == "/"
                    && s != "-" && s != "+")
                {
                    string tempStr = String.Format("{0}{1}{2}", "{", s, "}");
                    temp.Add(tempStr);
                }
                else
                {
                    temp.Add(s);
                    temp.Add(" ");     
                }
            }
            return temp;
        }
    }
}
