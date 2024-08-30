using System;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using System.Drawing;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace AutoClicker
{
    public partial class Fo_Main : Form
    {
        private Thread keyListenerThread;
        private bool keepListening = true;
        private int KEY = 88; // X key
        bool rec = false;
        int firstKey;
        int secondKey;

        [DllImport("user32.dll")]
        public static extern int GetAsyncKeyState(Int32 i);

        public Fo_Main()
        {
            InitializeComponent();
        }

        private void Fo_Main_Load(object sender, EventArgs e)
        {
            firstKey = Properties.Settings.Default.firstKey;
            secondKey = Properties.Settings.Default.secondKey;
            if (firstKey > -1 && secondKey > -1) label2.Text = ((Keys)firstKey).ToString() + " + " + ((Keys)secondKey).ToString();
            else if (firstKey > -1) label2.Text = ((Keys)firstKey).ToString();
        }

        private void KeyListener()
        {
            while (keepListening)
            {
                Thread.Sleep(5);

                int keystate = GetAsyncKeyState(KEY);

                if (keystate == -32767 || keystate == -32768) // Key is pressed
                {

                }
                else
                {

                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //          label1.Text = ans;
        }

        private void Fo_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Stop the key listener thread before closing
            keepListening = false;
            if (keyListenerThread != null && keyListenerThread.IsAlive)
            {
                keyListenerThread.Join(); // Wait for the thread to finish
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //green yellow
            //red
            label2.Text = "";
            this.Focus();
            if (btn_rec.ForeColor == Color.GreenYellow)
            {
                firstKey = -1;
                secondKey = -1;
                btn_rec.ForeColor = Color.Red;

                rec = true;
            }
            else
            {
                btn_rec.ForeColor = Color.GreenYellow;
                rec = false;
            }
            if (firstKey > -1)
            {
                label2.Text = ((Keys)firstKey).ToString();
            }
            if (secondKey > -1)
            {
                label2.Text += " + " + ((Keys)secondKey).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btn_str.BackColor == Color.FromArgb(61, 137, 141))
            {
                btn_str.Text = "Stop";
                btn_str.BackColor = Color.Transparent;
                btn_str.ForeColor = Color.Red;
                btn_str.FlatAppearance.BorderColor = Color.Red;
                keyListenerThread = new Thread(KeyListener);
                keyListenerThread.IsBackground = true;
                keyListenerThread.Start();
                timer1.Start();
            }
            else
            {
                btn_str.Text = "Start";
                btn_str.BackColor = Color.FromArgb(61, 137, 141);
                btn_str.FlatAppearance.BorderColor = Color.FromArgb(61, 137, 141);
                btn_str.ForeColor = Color.White;
            }

        }

        private void button2_KeyDown(object sender, KeyEventArgs e)
        {
            if (!rec) return;
            if ((int)e.KeyCode == 32) return;

            if (firstKey == -1) firstKey = (int)e.KeyCode;
            else if (firstKey > -1 && secondKey == -1 && firstKey != (int)e.KeyCode) secondKey = (int)e.KeyCode;

            if (firstKey > -1 && secondKey > -1) btn_rec.PerformClick();
        }

        private void Fo_Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (!rec) return;
            if ((int)e.KeyCode == 32) return;

            if (firstKey == -1) firstKey = (int)e.KeyCode;
            else if (firstKey > -1 && secondKey == -1 && firstKey != (int)e.KeyCode) secondKey = (int)e.KeyCode;

            if (firstKey > -1 && secondKey > -1) btn_rec.PerformClick();
        }

        private void btn_str_KeyDown(object sender, KeyEventArgs e)
        {
            if (!rec) return;
            if ((int)e.KeyCode == 32) return;

            if (firstKey == -1) firstKey = (int)e.KeyCode;
            else if (firstKey > -1 && secondKey == -1 && firstKey != (int)e.KeyCode) secondKey = (int)e.KeyCode;

            if (firstKey > -1 && secondKey > -1) btn_rec.PerformClick();
        }
    }
}
