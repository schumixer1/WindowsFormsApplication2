using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication2
{
  class Field : Form
  {
    private List<Tank> tanks = new List<Tank>();
    private List<Hindrance> hindrances = new List<Hindrance>();
    private Track trackElement;
    Form myForm;
    public Field(object sender, dynamic Controls, int speed)
    {
      myForm = (Form1)sender;
      Random rand = new Random();
      List<Label> labels = new List<Label>();
      List<Button> buttons = new List<Button>();
      int countOfButton = 1, countOfLabel = 1;
      foreach (Control value in Controls)
      {
        Label currentLabel = value as Label;
        Button currentButton = value as Button;
        TrackBar currentTrackBar = value as TrackBar;
        if (currentLabel != null)
        {
          currentLabel.Tag = countOfLabel++;
          labels.Add(currentLabel);
          tanks.Add(new Tank(labels.Last(), rand, speed));
        }
        else if (currentButton != null)
        {
          currentButton.Tag = countOfButton++;
          buttons.Add(currentButton);
          hindrances.Add(new Hindrance(buttons.Last()));
        }
        else if (currentTrackBar != null)

        {
          trackElement = new Track(currentTrackBar);
          //trackbar.Margin. = 0;
        }
      }



    }
    public bool CheckPrimaryPosition()
    {
      //Form myForm;
      //myForm = (Form1)sender;
      List<Elements> elements = new List<Elements>(tanks);
      elements.AddRange(hindrances);
      elements.Add(trackElement);
      bool work = true;
      if (tanks.Count != 0)
        foreach (var item in tanks)
          item.CheckBorder(item, ref work, ref myForm);
      for (int i = 0; i < elements.Count; i++)
      {
        for (int j = i; j < elements.Count - 1; j++)
        {
          elements[i].CheckIntersections(elements[j + 1], ref work);
        }
      }
      return work;
    }
    public void CheckMoving()
    {
      //border
      foreach (var item in tanks)
        item.CheckMovingBorder(myForm);

      //elements
      List<Elements> elements = new List<Elements>(tanks);
      elements.AddRange(hindrances);
      elements.Add(trackElement);
      for (int i = 0; i < elements.Count; i++)
      {
        for (int j = 0; j < elements.Count; j++)
        {
          if ((elements[i] is Tank) && (i != j))
            ((Tank)elements[i]).CheckMovingElement(elements[j]);
        }
      }
      //border
      foreach (var item in tanks)
        item.CheckMovingBorder(myForm);
    }
    public void MoveTanks(object sender, System.EventArgs e)
    {
      //CheckMovingElements();
      for (int i = 0; i < trackElement.Element.Value; i++)
      {
        CheckMoving();
        foreach (var item in tanks)
          item.Move(myForm, 1, null);
      }
    }
 }
}
