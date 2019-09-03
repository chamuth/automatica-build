using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automatica
{
    public partial class Form1 : Form
    {
        KeyboardHook hook = new KeyboardHook();

        public Form1()
        {
            InitializeComponent();

            // register the event that is fired after the key press.
            hook.KeyPressed += new EventHandler<KeyPressedEventArgs>(hook_KeyPressed);
            // register the control + alt + F12 combination as hot key.
            hook.RegisterHotKey(global::ModifierKeys.Control, Keys.Tab);

        }

        private static void hook_KeyPressed(object sender, KeyPressedEventArgs e)
        {
            SendKeys.Send("%");
            Thread.Sleep(150);
            SendKeys.Send("T");
            Thread.Sleep(150);
            SendKeys.Send("{UP}");
            Thread.Sleep(150);
            SendKeys.Send("{ENTER}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
