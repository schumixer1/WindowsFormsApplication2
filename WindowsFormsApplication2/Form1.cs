using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      //trackBar1.Scroll += trackBar1_Scroll;
    }

    private void label2_Click(object sender, EventArgs e)
    {
      
    }
    private void trackBar1_Scroll(object sender, EventArgs e)
    {
      textBox1.Text = String.Format("Текущее значение: {0}", trackBar1.Value);
    }
    private void trackBar1_MouseWheel(object sender, MouseEventArgs e)
    {
      ((HandledMouseEventArgs)e).Handled = true;//отключить заранее определенный trackBar1_MouseWheel
      if ((e.Delta >0) && (trackBar1.Value<trackBar1.Maximum))
        trackBar1.Value += 1;
      else if ((e.Delta <0) && (trackBar1.Value > trackBar1.Minimum))
        trackBar1.Value -= 1;
      textBox1.Text = String.Format("Текущее значение: {0}", trackBar1.Value);
    }
    //private void Foo(object sender, System.EventArgs e)
    //{
    //  foreach (var item in Controls)
    //  {
    //    Label currentLabel = item as Label;
    //    if(currentLabel!=null)
    //    {
    //      currentLabel.BackColor = Color.DarkGreen;
    //      currentLabel.Location=new Point(currentLabel.Location.X+2, currentLabel.Location.Y + 2);
    //      //Graphics g = currentLabel.CreateGraphics();
    //      //g.TranslateTransform(200, 5);
    //    }
    //  }
    //}
    private void Form1_Load(object sender, System.EventArgs e)
    {
      Field field = new Field(sender, Controls, trackBar1.Value);
      bool work=field.CheckPrimaryPosition();
      if(work==true)
      {
        Timer myTimer = new Timer();
        myTimer.Tick += new EventHandler(field.MoveTanks);
        myTimer.Interval = 1000;
        myTimer.Start();
        //Application.DoEvents();
      }
    }
    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void label6_Click(object sender, EventArgs e)
    {

    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void label3_Click(object sender, EventArgs e)
    {

    }

    private void label1_Click_1(object sender, EventArgs e)
    {

    }
  }
}
