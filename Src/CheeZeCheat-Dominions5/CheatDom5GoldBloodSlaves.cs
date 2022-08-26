using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dom5.Addresses;
using Memory;

namespace CheeZeCheat_Dominions5
{
    public partial class CheatDom5GoldBloodSlaves : Form
    {
        public PerlsHack perls = new PerlsHack();
        public GoldHackDominions5 g = new GoldHackDominions5();
        public Mem mem = new Mem();
        private void OpenProcessDom5()
        {
            mem.OpenProcess("Dominions5");
        }
        public CheatDom5GoldBloodSlaves()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            perls.ReadBloodSlavesPlr1();
            perls.WriteBloodSlavesPlr1(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            g.ReadMemGoldPlr1();
            g.WriteMemGoldPlr1(textBox3.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            perls.ReadBloodSlavesPlr2();
            perls.WriteBloodSlavesPlr2(textBox2.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            perls.ReadBloodSlavesPlr3();
            perls.WriteBloodSlavesPlr3(textBox5.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            g.ReadMemGoldPlr2();
            g.WriteMemGoldPlr2(textBox4.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            g.ReadMemGoldPlr3();
            g.WriteMemGoldPlr3(textBox6.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            perls.ReadBloodSlavesPlr4();
            perls.WriteBloodSlavesPlr4(textBox7.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            g.ReadMemGoldPlr4();
            g.WriteMemGoldPlr4(textBox8.Text);
        }
    }
}
