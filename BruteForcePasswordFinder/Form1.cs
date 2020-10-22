using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BruteForcePasswordFinder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string BruteForce()
        {
            string password = PasswordTextbox.Text;
            string charset = "abcdefghijklmnopqrstuvwxyz";
            string charset1 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string charset2 = "0123456789";
            string charset3 = "!@#$%^&*(~[-+:=;'{<>_?/,.|¿¡}'])";
            string result = "";
            TerminalTextbox.Text = "[+][+] Starting BruteForce Decoding..." + System.Environment.NewLine;

            password.Split(new[] { ',' }).ToList<string>();
            for(int x = 0; x <= password.Length - 1; x++)
            {
                string newChar = Convert.ToString(password[x]);
                if (charset.Contains(newChar))
                {
                    Check(newChar, charset);
                    result += newChar;
                }
                else if (charset1.Contains(newChar))
                {
                    Check(newChar, charset1);
                    result += newChar;
                }
                else if (charset2.Contains(newChar))
                {
                    Check(newChar, charset2);
                    result += newChar;
                }
                else
                {
                    Check(newChar, charset3);
                    result += newChar;
                }
            }
            return result;
        }

        void Check(string newChar, string charset)
        {
            charset.Split(new[] { ',' }).ToList<string>();
            foreach(char ch in charset)
            {
                string charString = Convert.ToString(ch);
                if(charString == newChar)
                {
                    TerminalTextbox.Text = TerminalTextbox.Text + " \n Trying.. [ " + ch + " ]" + System.Environment.NewLine;

                    TerminalTextbox.Text = TerminalTextbox.Text + " \n ###### Matched [ " + ch + " ] ######" + System.Environment.NewLine;
                    break;
                }
                else
                {
                    TerminalTextbox.Text = TerminalTextbox.Text + " \n Trying.. [ " + ch + " ]" + System.Environment.NewLine;
                }
            }
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            ResultTextbox.Text = "Password found ===>" + BruteForce();
        }
    }
}
