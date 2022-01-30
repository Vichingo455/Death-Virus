using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace Death_Virus
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            checkBox1.Checked = false;
            string sound = @"C:\Windows\Media\Windows Exclamation.wav";
            if (File.Exists(sound))
            {
                SoundPlayer soundplayer = new SoundPlayer(sound);
                soundplayer.Play();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                button2.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            run_virus();
        }
        public void run_virus()
        {
            this.Hide();
            Death_Virus form = new Death_Virus();
            form.ShowDialog();
            this.Close();
        }
    }
}
