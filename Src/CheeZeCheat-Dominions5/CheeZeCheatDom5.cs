using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Toolkit.Uwp.Notifications;
using CheeZeCheat_Dominions5.Properties;
using System.IO;
using System.Media;
using System.Diagnostics;
using Memory;
using Dom5.Addresses;

namespace CheeZeCheat_Dominions5
{
    public partial class CheeZeCheatDom5 : Form
    {
        public bool opened = false;
        public Dom5MemoriesAddresses dom = new Dom5MemoriesAddresses();
        public Dom5StringNameProc game = new Dom5StringNameProc();
        public Mem mems = new Mem();
        public PerlsHack p = new PerlsHack();
        public string AstralGemPlayer1 = "0x25D73DA";
        public string AstralGemPlayer2 = "0x25D7C16";
        public string AstralGemPlayer3 = "0x25D8452";
        public string AstralGemPlayer4 = "0x25D8C8E";
        public void Notification(string text)
        {
            new ToastContentBuilder().AddText(text).Show();
        }
        public void NotificationWithImage(string txt, Uri uri)
        {
            new ToastContentBuilder().AddText(txt).AddInlineImage(uri).Show();
        }
        public void OpenProcDom5()
        {
            mems.OpenProcess("Dominions5.exe");
        }
        public void StreamMusic(Stream stream)
        {
            bool f = false;
            SoundPlayer plr;
            plr = new SoundPlayer(stream);
            plr.PlayLooping();
            f = true;
        }
        public void StopStreamMusic(Stream str)
        {
            bool x = false;
            SoundPlayer plrr;
            plrr = new SoundPlayer(str);
            plrr.Stop();
            x = true;
        }
        public CheeZeCheatDom5()
        {
            this.Visible = false;
            Process[] dom5 = Process.GetProcessesByName("Dominions5");
            if(dom5.Length == 1)
            {
                foreach (Process xin5 in dom5)
                {
                    try
                    {
                        opened = true;
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message);
                        Environment.Exit(432);
                    }
                    new ToastContentBuilder().AddText($"Founded Dominions5... Process ID of Game: {xin5.Id.ToString()}").Show();
                }
            }
            else
            {
                MessageBox.Show("Dominions 5 Not Founded!!!");
                Environment.Exit(531);
            }
            InitializeComponent();
            this.Visible = true;
            StreamMusic(Resources.Nuclear);
        }

        private void CheeZeCheatDom5_Load(object sender, EventArgs e)
        {
            new ToastContentBuilder().AddText("Welcome to CheeZeCheat Dominions 5... Enjoy :D").Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            StopStreamMusic(Resources.Nuclear);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenProcDom5();
            mems.Read2Byte($"{game.gameproc}+{AstralGemPlayer1}");
            mems.WriteMemory($"{game.gameproc}+{AstralGemPlayer1}", "int", textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenProcDom5();
            mems.FreezeValue($"{game.gameproc}+{AstralGemPlayer1}", "int", textBox1.Text);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            var m = new CheatDom5GoldBloodSlaves();
            m.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenProcDom5();
            mems.Read2Byte($"{game.gameproc}+{AstralGemPlayer2}");
            mems.WriteMemory($"{game.gameproc}+{AstralGemPlayer2}", "int", textBox3.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenProcDom5();
            mems.Read2Byte($"{game.gameproc}+{AstralGemPlayer3}");
            mems.WriteMemory($"{game.gameproc}+{AstralGemPlayer3}", "int", textBox5.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OpenProcDom5();
            mems.Read2Byte($"{game.gameproc}+{AstralGemPlayer4}");
            mems.WriteMemory($"{game.gameproc}+{AstralGemPlayer4}", "int", textBox7.Text);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            p.ReadOtherPerlsPlr1();
            p.WriteOtherPerlsPlr1(textBox2.Text);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            p.ReadOtherPerlsPlr2();
            p.WriteOtherPerlsPlr2(textBox4.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            p.ReadOtherPerlsPlr3();
            p.WriteOtherPerlsPlr3(textBox6.Text);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            p.ReadOtherPerlsPlr4();
            p.WriteOtherPerlsPlr4(textBox8.Text);
        }
    }
}
