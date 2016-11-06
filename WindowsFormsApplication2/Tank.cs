using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
  class Tank : Elements
  {
    private int myVelocity;
    private System.Drawing.Point vector;
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
        vector = new System.Drawing.Point(rand.Next(-1, 2), rand.Next(-1, 2));
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
    public void CheckMovingElement(Elements newElement)
    {

      //elements
      Rect newRectangle = new Rect(newElement.Element.Location.X,
                              newElement.Element.Location.Y,
                              newElement.Element.Size.Width,
                              newElement.Element.Size.Height);
      if (((Element.Location.Y <= newElement.Element.Location.Y+ newElement.Element.Height) &&
          (rect.IntersectsWith(newRectangle)))||
           ((Element.Location.Y+Element.Height >= newElement.Element.Location.Y) &&
           (rect.IntersectsWith(newRectangle))))
        vector.Y *= -1;
      if (((Element.Location.X <= newElement.Element.Location.X + newElement.Element.Width) &&
          (rect.IntersectsWith(newRectangle))) ||
           ((Element.Location.X + Element.Width >= newElement.Element.Location.X) &&
           (rect.IntersectsWith(newRectangle))))
        vector.X *= -1;



      //Element.Location.X + Element.Width >= myForm.ClientSize.Width)
      //  vector.X *= -1;
      //if (Element.Location.Y <= 0 ||
      //    Element.Location.Y + Element.Height >= myForm.ClientSize.Height)
      //  vector.Y *= -1;


      //if (Math.Abs(Center.X - newElement.Center.X) <= Element.Width/2 + newElement.Element.Width / 2 ||
      //    Math.Abs(Center.Y - newElement.Center.Y) <= Element.Height / 2 + newElement.Element.Height / 2)
      //{
      //  vector.X = -vector.X;
      //  vector.Y = -vector.Y;
      //  if (newElement is Tank)
      //  {
      //    ((Tank)newElement).vector.X *= -1;
      //    ((Tank)newElement).vector.Y *= -1;
      //  }
      //}
      //if (Math.Abs(Center.Y - newElement.Center.Y) <= Element.Height / 2 + newElement.Element.Height / 2)
      //{
      //  vector.Y = -vector.Y;
      //  if (newElement is Tank)
      //    ((Tank)newElement).vector.Y *= -1;
      //}
    }
    public void CheckMovingBorder(Form myForm)
    {
      //Border
      if (Element.Location.X <= 0 ||
          Element.Location.X + Element.Width >= myForm.ClientSize.Width)
        vector.X *= -1;
      if (Element.Location.Y <= 0 ||
          Element.Location.Y + Element.Height >= myForm.ClientSize.Height)
        vector.Y *= -1;
    }
    public void Move(Form myForm, int speed, Elements newElement)
    {
      Velocity = speed;
      //Point center = new Point(Element.Location.X + (Element.Width / 2),
      //                         Element.Location.Y + (Element.Height / 2));
      Element.Location = new System.Drawing.Point(Element.Location.X + Velocity * vector.X,
                                   Element.Location.Y + Velocity * vector.Y);
      //Center = new System.Drawing.Point(Element.Location.X + (Element.Width / 2),
      //                       Element.Location.Y + (Element.Height / 2));
    }
    

  }
}

