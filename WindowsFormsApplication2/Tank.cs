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
    public Tank():base() { }
    public Tank(Label label) : base(label) { }

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
      
    //public void move(dynamic mas, int speed)
    //{
    //  foreach (var item in mas)
    //  {
    //    // item.
    //  }
    //}
  }
}

