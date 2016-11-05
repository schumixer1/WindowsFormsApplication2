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
    //private List<Button> tanks = new List<Button>();
    //private List<Label> hindrance = new List<Label>();
    private void Form1_Load(object sender, System.EventArgs e)
    {
      Field field = new Field(Controls);
      field.CheckPrimaryPosition(sender);

    }
    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void label6_Click(object sender, EventArgs e)
    {

    }
  }
}
