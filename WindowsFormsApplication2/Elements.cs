using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.ComponentModel;
using System.Drawing;

namespace WindowsFormsApplication2
{
 class Elements
  {
    public System.Drawing.Point Center { get; set; }
    //protected struct Points
    //{
    //  public int YUp { get; set; }
    //  public int XRight { get; set; }
    //  public int YDown { get; set; }
    //  public int XLeft { get; set; }
    //  public Points(int yUp, int xRight, int yDown, int xLeft)
    //  {
    //    this.XRight = xRight;
    //    this.XLeft = xLeft;
    //    this.YUp = yUp;
    //    this.YDown = yDown;
    //  }
    //  //public void Add(int xRight, int xLeft, int yUp, int yDown)
    //  //{
    //  //  this.xRight = xRight;
    //  //  this.xLeft = xLeft;
    //  //  this.yUp = yUp;
    //  //  this.yDown = yDown;
    //  //}
    //}
    //protected Points coordinate;
    public dynamic Element { get; set; }
    protected Rect rect;
    public Elements() { }
    public Elements(dynamic element )
    {
      Element = element;
      Center = new System.Drawing.Point(Element.Location.X + (Element.Width / 2),
                             Element.Location.Y + (Element.Height / 2));
      
      rect=new Rect(element.Location.X,
                    element.Location.Y,
                    element.Size.Width,
                    element.Size.Height);
      //coordinate=new Points(element.Location.Y,
      //                             element.Location.X + element.Size.Width,
      //                             element.Location.Y + element.Size.Height,
      //                             element.Location.X);
      //MessageBox.Show(string.Format("{0} {1} {1} {2}", coordinate.YUp, coordinate.XRight, coordinate.YDown, coordinate.XLeft));
    }
    public void CheckIntersections(Elements item,ref bool work)
    {
      bool flag = true;
      Rect newRectangle = new Rect(item.Element.Location.X,
                              item.Element.Location.Y,
                              item.Element.Size.Width,
                              item.Element.Size.Height);
      if (rect.IntersectsWith(newRectangle))
      {
        flag = false;
        item.Element.BackColor = Color.Red;
        Element.BackColor = Color.Red;
        MessageBox.Show(String.Format("Intersection!"));
      }
        
      if (flag == false)
        work = false;
    }
  }
}
