using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_First_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "Tapsy";
            this.label1.Text = "this is my first project";

            //This is comment line. The program will ignore this line when compiling
            // Console.Title = "Stop";
            //Console.BackgroundColor = ConsoleColor.Green;
            this.Text = "Gerry";
            Console.WriteLine("This is the console that we want to use - Taps");




        }
    }
}
