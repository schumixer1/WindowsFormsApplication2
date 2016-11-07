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
      this.label3 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.trackBar1 = new System.Windows.Forms.TrackBar();
      this.textBox1 = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(463, 137);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(246, 179);
      this.button1.TabIndex = 0;
      this.button1.Text = "button1";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // label3
      // 
      this.label3.BackColor = System.Drawing.SystemColors.MenuHighlight;
      this.label3.Location = new System.Drawing.Point(969, 121);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(136, 128);
      this.label3.TabIndex = 7;
      this.label3.Text = "T3";
      // 
      // label7
      // 
      this.label7.BackColor = System.Drawing.SystemColors.MenuHighlight;
      this.label7.Location = new System.Drawing.Point(524, 374);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(108, 60);
      this.label7.TabIndex = 11;
      this.label7.Text = "T7";
      // 
      // trackBar1
      // 
      this.trackBar1.AutoSize = false;
      this.trackBar1.LargeChange = 3;
      this.trackBar1.Location = new System.Drawing.Point(445, 508);
      this.trackBar1.Maximum = 20;
      this.trackBar1.Name = "trackBar1";
      this.trackBar1.Size = new System.Drawing.Size(302, 75);
      this.trackBar1.TabIndex = 12;
      this.trackBar1.Tag = "";
      this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
      this.trackBar1.Value = 5;
      this.trackBar1.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.trackBar1_MouseWheel);
      this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
      // 
      // textBox1
      // 
      this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
      this.textBox1.Location = new System.Drawing.Point(527, 548);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(120, 20);
      this.textBox1.TabIndex = 13;
      this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.InactiveCaption;
      this.ClientSize = new System.Drawing.Size(1171, 580);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.trackBar1);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.button1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TrackBar trackBar1;
    private System.Windows.Forms.TextBox textBox1;
  }
}

