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
    }

    private void label2_Click(object sender, EventArgs e)
    {
      
    }

    private void Foo(object sender, System.EventArgs e)
    {
      foreach (var item in Controls)
      {
        Label currentLabel = item as Label;
        if(currentLabel!=null)
        {
          currentLabel.BackColor = Color.DarkGreen;
          currentLabel.Location=new Point(currentLabel.Location.X+2, currentLabel.Location.Y + 2);
          //Graphics g = currentLabel.CreateGraphics();
          //g.TranslateTransform(200, 5);
        }
      }
    }
    private void Form1_Load(object sender, System.EventArgs e)
    {
      Field field = new Field(Controls);
      bool work=field.CheckPrimaryPosition(sender);
      if(work==true)
      {
        Timer myTimer = new Timer();
        myTimer.Tick += new EventHandler(Foo);
        myTimer.Interval = 500;
        myTimer.Start();
        Application.DoEvents();
      }
    }
    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void label6_Click(object sender, EventArgs e)
    {

    }
  }
}
