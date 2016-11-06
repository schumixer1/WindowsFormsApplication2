using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
  class Tank : Elements
  {
    private int myVelocity;
    private Point vector;
    public int Velocity
    {
      get { return myVelocity; }
      set
      {
        if (value >= 0 || value <= 20)
          myVelocity = value;
        else
        {
          MessageBox.Show(String.Format("Wrong velocity: {0}", value));
          System.Environment.Exit(1);
        }
      }
    }
    public Tank():base(){}
    public Tank(Label label,Random rand) : base(label)
    {
      Velocity = 5;
      //Random rand = new Random();
      do
      {
        vector = new Point(rand.Next(-1, 2), rand.Next(-1, 2));
      } while (vector.X == 0 && vector.Y == 0);
     // rand = null;
    }

    public void CheckBorder(Tank item, ref bool work, ref Form myForm)
    {
      //MessageBox.Show(String.Format("{0} {1}", item.Location.X + item.Size.Width, myForm.Location.X + myForm.Size.Width));
      bool flag = true;
          if ((item.Element.Location.Y<0) ||
             (item.Element.Location.X + item.Element.Size.Width >  myForm.ClientSize.Width)  ||
             (item.Element.Location.Y + item.Element.Size.Height >  myForm.ClientSize.Height) ||
             (item.Element.Location.X<0))
          {
        //MessageBox.Show(String.Format("{0} {1}",item.Location.X + item.Size.Width, myForm.Size.Width));
        flag = false;
            item.Element.BackColor = Color.Red;
            MessageBox.Show(String.Format("Wrong tank coordintates: {0} {1}", item.Element.Location.X, item.Element.Location.Y));
          }
      if (flag == false)
        work = false;

}
      
    public void Move(Form myForm, int speed, Elements newElement)
    {
      Velocity = speed;
      //Point center = new Point(Element.Location.X + (Element.Width / 2),
      //                         Element.Location.Y + (Element.Height / 2));
      Element.Location = new Point(Element.Location.X + Velocity * vector.X,
                                   Element.Location.Y + Velocity * vector.Y);
      if (Element.Location.X <= 0 ||
          Element.Location.X + Element.Width >= myForm.ClientSize.Width)
        vector.X = -vector.X;
      if (Element.Location.Y <= 0 ||
          Element.Location.Y + Element.Height >= myForm.ClientSize.Height)
        vector.Y = -vector.Y;



    }
    

  }
}

