using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      MessageBox.Show("Привет!");
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      label1.Text = "Начало работы";
      BackColor = Color.AntiqueWhite;
    }

    private void button1_Click_1(object sender, EventArgs e)
    {
      BackColor = Color.Red;
    }

    private void button2_Click(object sender, EventArgs e)
    {
      BackColor = Color.Green;
    }

    private void button3_Click(object sender, EventArgs e)
    {
      BackColor = Color.Blue;
    }

    private void button4_Click(object sender, EventArgs e)
    {
      BackColor = Color.Yellow;
    }

    private void button5_Click(object sender, EventArgs e)
    {
      label1.Text = "Привет";
    }

    private void button6_Click(object sender, EventArgs e)
    {
      label1.Text = "До свидания";
    }

    private void button8_Click(object sender, EventArgs e)
    {

    }

    private void button7_Click(object sender, EventArgs e)
    {
      textBox1.Visible = false;
    }

    private void button8_Click_1(object sender, EventArgs e)
    {
      textBox1.Visible = true;
    }

    private void button9_Click(object sender, EventArgs e)
    {
      textBox1.Clear();
    }
  }
}
