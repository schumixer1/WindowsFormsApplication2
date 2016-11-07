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
    public Tank(Label label,Random rand, int speed) : base(label)
    {
      Velocity = speed;
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
      newElement.rect = new Rect(newElement.Element.Location.X,
                              newElement.Element.Location.Y,
                              newElement.Element.Size.Width,
                              newElement.Element.Size.Height);
      if (rect.IntersectsWith(newElement.rect) /*&& HaveAlreadyIntersect!=true*/)
      {
        //MessageBox.Show(string.Format("Intersection beween {0} and {1}", Element.Text, newElement.Element.Text));
        const int N = 5;
        //down
        if ((rect.Bottom >= newElement.rect.Top &&
             rect.Top <= newElement.rect.Top) &&
            (vector == new System.Drawing.Point(-1, 1) ||
             vector == new System.Drawing.Point(0, 1) ||
             vector == new System.Drawing.Point(1, 1)) &&
             Math.Abs(rect.Bottom - newElement.rect.Top) <= N)
        {
          vector.Y *= -1;
          Element.Location = new System.Drawing.Point(Element.Location.X,
                                   Element.Location.Y - 1);
          //vector.X *= -1;
        }
        //up
        else if ((rect.Top <= newElement.rect.Bottom &&
                 rect.Bottom >= newElement.rect.Bottom) &&
                (vector == new System.Drawing.Point(-1, -1) ||
                 vector == new System.Drawing.Point(0, -1) ||
                 vector == new System.Drawing.Point(1, -1)) &&
                 Math.Abs(rect.Top - newElement.rect.Bottom) <= N)
        {
          vector.Y *= -1;
          Element.Location = new System.Drawing.Point(Element.Location.X,
                         Element.Location.Y + 1);
        }
        //right
        else if ((rect.Right >= newElement.rect.Left &&
                 rect.Left <= newElement.rect.Left) &&
                (vector == new System.Drawing.Point(1, -1) ||
                 vector == new System.Drawing.Point(1, 0) ||
                 vector == new System.Drawing.Point(1, 1)) &&
                 Math.Abs(rect.Right - newElement.rect.Left) <= N)
        {
          vector.X *= -1;
          Element.Location = new System.Drawing.Point(Element.Location.X - 1,
                         Element.Location.Y);
        }
        //left
        else if ((rect.Left <= newElement.rect.Right &&
                 rect.Right >= newElement.rect.Right) &&
                (vector == new System.Drawing.Point(-1, -1) ||
                 vector == new System.Drawing.Point(-1, 0) ||
                 vector == new System.Drawing.Point(-1, 1)) &&
                 Math.Abs(rect.Left - newElement.rect.Right) <= N)
        {
          vector.X *= -1;
          Element.Location = new System.Drawing.Point(Element.Location.X + 1,
                         Element.Location.Y);
        }
        else
        {
          
        }
          //MessageBox.Show("mistake");

        //if (Element.Location.X <= 0 ||
        //  Element.Location.X + Element.Width >= myForm.ClientSize.Width)
        //  vector.X *= -1;
        //if (Element.Location.Y <= 0 ||
        //    Element.Location.Y + Element.Height >= myForm.ClientSize.Height)
        //  vector.Y *= -1;
        //HaveAlreadyIntersect = true;

      }
      }
    public void CheckMovingBorder(Form myForm)
    {
      //Border
      if (Element.Location.X <= 0)
      {
        vector.X *= -1;
        Element.Location = new System.Drawing.Point(Element.Location.X + 1,
                        Element.Location.Y);
      }
        else if(Element.Location.X + Element.Width >= myForm.ClientSize.Width)
      {
        vector.X *= -1;
        Element.Location = new System.Drawing.Point(Element.Location.X - 1,
                Element.Location.Y);
      }

      else if (Element.Location.Y <= 0)
      {
        vector.Y *= -1;
        Element.Location = new System.Drawing.Point(Element.Location.X ,
                Element.Location.Y+1);
      }
      else if(Element.Location.Y + Element.Height >= myForm.ClientSize.Height)
      {
        vector.Y *= -1;
        Element.Location = new System.Drawing.Point(Element.Location.X,
                Element.Location.Y - 1);
      }
        
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

