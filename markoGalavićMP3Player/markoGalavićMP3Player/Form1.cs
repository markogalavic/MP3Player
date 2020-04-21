using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace markoGalavićMP3Player
{
    public partial class Form1 : Form
    {
        private mp3player mp3Player = new mp3player();
        public Form1()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void folder_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd= new OpenFileDialog())
            {
                ofd.Filter = "Mp3 Files|*.mp3";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    mp3Player.open(ofd.FileName);
                }
            }

        }

        private void play_Click(object sender, EventArgs e)
        {
            mp3Player.play();
        }

        private void stop_Click(object sender, EventArgs e)
        {
            mp3Player.stop();
        }
    }
}
