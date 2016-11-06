namespace WindowsFormsApplication2
{
  partial class Form1
  {
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(463, 137);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(171, 43);
      this.button1.TabIndex = 0;
      this.button1.Text = "button1";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(1002, 324);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(75, 23);
      this.button2.TabIndex = 1;
      this.button2.Text = "button2";
      this.button2.UseVisualStyleBackColor = true;
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(261, 212);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(75, 23);
      this.button3.TabIndex = 2;
      this.button3.Text = "button3";
      this.button3.UseVisualStyleBackColor = true;
      // 
      // button4
      // 
      this.button4.Location = new System.Drawing.Point(578, 284);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(337, 63);
      this.button4.TabIndex = 3;
      this.button4.Text = "button4";
      this.button4.UseVisualStyleBackColor = true;
      // 
      // label2
      // 
      this.label2.BackColor = System.Drawing.SystemColors.MenuHighlight;
      this.label2.Location = new System.Drawing.Point(88, 380);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(30, 16);
      this.label2.TabIndex = 5;
      this.label2.Text = "T6";
      this.label2.Click += new System.EventHandler(this.label2_Click);
      // 
      // label1
      // 
      this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
      this.label1.Location = new System.Drawing.Point(717, 44);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(20, 40);
      this.label1.TabIndex = 6;
      this.label1.Text = "T4";
      // 
      // label3
      // 
      this.label3.BackColor = System.Drawing.SystemColors.MenuHighlight;
      this.label3.Location = new System.Drawing.Point(839, 72);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(60, 40);
      this.label3.TabIndex = 7;
      this.label3.Text = "T3";
      // 
      // label4
      // 
      this.label4.BackColor = System.Drawing.SystemColors.MenuHighlight;
      this.label4.Location = new System.Drawing.Point(33, 61);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(60, 23);
      this.label4.TabIndex = 8;
      this.label4.Text = "T5";
      // 
      // label5
      // 
      this.label5.BackColor = System.Drawing.SystemColors.MenuHighlight;
      this.label5.Location = new System.Drawing.Point(460, 520);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(60, 26);
      this.label5.TabIndex = 9;
      this.label5.Text = "T1";
      // 
      // label6
      // 
      this.label6.BackColor = System.Drawing.SystemColors.MenuHighlight;
      this.label6.Location = new System.Drawing.Point(939, 202);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(94, 24);
      this.label6.TabIndex = 10;
      this.label6.Text = "T2";
      this.label6.Click += new System.EventHandler(this.label6_Click);
      // 
      // label7
      // 
      this.label7.BackColor = System.Drawing.SystemColors.MenuHighlight;
      this.label7.Location = new System.Drawing.Point(168, 479);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(74, 57);
      this.label7.TabIndex = 11;
      this.label7.Text = "T7";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.InactiveCaption;
      this.ClientSize = new System.Drawing.Size(1171, 580);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.button4);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
  }
}

