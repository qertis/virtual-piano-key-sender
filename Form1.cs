using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace KeySender
{
    public partial class Form1 : Form
    {
        private Function func;

        public Form1()
        {
            InitializeComponent();
            func = new Function();
        }

        private int _speed = 0;
        enum Speed
        {
            veryslow = 375,
            slow = 325,
            medium = 275,
            fast = 225,
            veryfast = 175
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox.Text.Trim().Length != 0)
                switch (listBoxSpeed.SelectedIndex)
                {
                    case 0:
                        _speed = (int)Speed.veryfast; break;
                    case 1:
                        _speed = (int)Speed.fast; break;
                    case 2:
                        _speed = (int)Speed.medium; break;
                    case 3:
                        _speed = (int)Speed.slow; break;
                    case 4:
                        _speed = (int)Speed.veryslow; break;
                }
            else
                _speed = (int)Speed.medium;

            if (func.FindSite())
                Start();
            else
                MessageBox.Show("Site not found");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            ActiveForm.Dispose();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabelUrl.LinkVisited = true;
            Process.Start("http://www.virtualpiano.net/");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox.Update();
        }

        private void richTextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            richTextBox.SelectAll(); 
            richTextBox.SelectionColor = Color.Black;
            richTextBox.DeselectAll();

            richTextBox.Refresh();
        }
        
        void Start()
        {
            //устанавливаем приоритет
            Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.High;

            var Strings = func.GetStr(richTextBox.Text.Trim());
            int index = 0;

            foreach (var var in Strings)
            {
                try
                {
                    richTextBox.SelectionColor = Color.Red;
                    richTextBox.Select(index, var.Length);

                    richTextBox.ScrollToCaret();
                }
                catch { break; }
                index += var.Length;

                if (var != " ")
                    func.SendKey(var);

                Thread.Sleep(_speed + new Random().Next(1, 15));
            }
        }
    }
}
