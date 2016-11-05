using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication2
{
  class Field: Form
  {
    private List<Tank> tanks = new List<Tank>();
    private List<Hindrance> hindrances = new List<Hindrance>();
    //Form myForm;
    public Field(dynamic Controls )
    {
      //myForm = (Form1)sender;
    List<Label> labels = new List<Label>();
    List<Button> buttons = new List<Button>();
    int countOfButton = 1, countOfLabel=1;
      foreach (Control value in Controls)
      {
        Label currentLabel = value as Label;
        Button currentButton = value as Button;
        if (currentLabel != null)
        {
          currentLabel.Tag = countOfLabel++;
          labels.Add(currentLabel);
          tanks.Add(new Tank(labels.Last()));
        }
        if(currentButton != null)
        {
          currentButton.Tag = countOfButton++;
          buttons.Add(currentButton);
          hindrances.Add(new Hindrance(buttons.Last()));
        }
      }


    }
    public bool CheckPrimaryPosition(object sender)
    {
      Form myForm;
      myForm = (Form1)sender;
      List<Elements> elements = new List<Elements>(tanks);
      elements.AddRange(hindrances);
      bool work = true;
      if (tanks.Count != 0)
        foreach (var item in tanks)
          item.CheckBorder(item, ref work, ref myForm);
      for (int i = 0; i < elements.Count; i++)
      {
        for (int j = i; j < elements.Count-1; j++)
        {
          elements[i].CheckIntersections(elements[j+1], ref work);
        }
      }
      return work;
    }
  }
}
