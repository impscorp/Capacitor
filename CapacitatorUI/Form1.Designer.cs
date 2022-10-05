namespace CapacitatorUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.R = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.C = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.V = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Tau = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.I = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rPostFactor = new System.Windows.Forms.ComboBox();
            this.cPostFactor = new System.Windows.Forms.ComboBox();
            this.iPostFactor = new System.Windows.Forms.ComboBox();
            this.tauPostFactor = new System.Windows.Forms.ComboBox();
            this.vPostFactor = new System.Windows.Forms.ComboBox();
            this.tPostFactor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // R
            // 
            this.R.Location = new System.Drawing.Point(35, 74);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(244, 39);
            this.R.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "R = Ohm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "C = Capacity";
            // 
            // C
            // 
            this.C.Location = new System.Drawing.Point(35, 155);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(244, 39);
            this.C.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "V = Volt";
            // 
            // V
            // 
            this.V.Location = new System.Drawing.Point(35, 241);
            this.V.Name = "V";
            this.V.Size = new System.Drawing.Size(244, 39);
            this.V.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 469);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "Load time";
            // 
            // Time
            // 
            this.Time.Location = new System.Drawing.Point(35, 504);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(244, 39);
            this.Time.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(235, 32);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tau = Time Constant";
            // 
            // Tau
            // 
            this.Tau.Location = new System.Drawing.Point(35, 423);
            this.Tau.Name = "Tau";
            this.Tau.Size = new System.Drawing.Size(244, 39);
            this.Tau.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 32);
            this.label6.TabIndex = 11;
            this.label6.Text = "I = Ampere";
            // 
            // I
            // 
            this.I.Location = new System.Drawing.Point(35, 327);
            this.I.Name = "I";
            this.I.Size = new System.Drawing.Size(244, 39);
            this.I.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 576);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 46);
            this.button1.TabIndex = 12;
            this.button1.Text = "calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rPostFactor
            // 
            this.rPostFactor.FormattingEnabled = true;
            this.rPostFactor.Location = new System.Drawing.Point(345, 74);
            this.rPostFactor.Name = "rPostFactor";
            this.rPostFactor.Size = new System.Drawing.Size(156, 40);
            this.rPostFactor.TabIndex = 13;
            // 
            // cPostFactor
            // 
            this.cPostFactor.FormattingEnabled = true;
            this.cPostFactor.Location = new System.Drawing.Point(345, 156);
            this.cPostFactor.Name = "cPostFactor";
            this.cPostFactor.Size = new System.Drawing.Size(156, 40);
            this.cPostFactor.TabIndex = 14;
            // 
            // iPostFactor
            // 
            this.iPostFactor.FormattingEnabled = true;
            this.iPostFactor.Location = new System.Drawing.Point(345, 328);
            this.iPostFactor.Name = "iPostFactor";
            this.iPostFactor.Size = new System.Drawing.Size(156, 40);
            this.iPostFactor.TabIndex = 15;
            // 
            // tauPostFactor
            // 
            this.tauPostFactor.FormattingEnabled = true;
            this.tauPostFactor.Location = new System.Drawing.Point(345, 424);
            this.tauPostFactor.Name = "tauPostFactor";
            this.tauPostFactor.Size = new System.Drawing.Size(156, 40);
            this.tauPostFactor.TabIndex = 16;
            // 
            // vPostFactor
            // 
            this.vPostFactor.FormattingEnabled = true;
            this.vPostFactor.Location = new System.Drawing.Point(345, 240);
            this.vPostFactor.Name = "vPostFactor";
            this.vPostFactor.Size = new System.Drawing.Size(156, 40);
            this.vPostFactor.TabIndex = 17;
            // 
            // tPostFactor
            // 
            this.tPostFactor.FormattingEnabled = true;
            this.tPostFactor.Location = new System.Drawing.Point(345, 503);
            this.tPostFactor.Name = "tPostFactor";
            this.tPostFactor.Size = new System.Drawing.Size(156, 40);
            this.tPostFactor.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 698);
            this.Controls.Add(this.tPostFactor);
            this.Controls.Add(this.vPostFactor);
            this.Controls.Add(this.tauPostFactor);
            this.Controls.Add(this.iPostFactor);
            this.Controls.Add(this.cPostFactor);
            this.Controls.Add(this.rPostFactor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.I);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Tau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.V);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.C);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.R);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox R;
        private Label label1;
        private Label label2;
        private TextBox C;
        private Label label3;
        private TextBox V;
        private Label label4;
        private TextBox Time;
        private Label label5;
        private TextBox Tau;
        private Label label6;
        private TextBox I;
        private Button button1;
        private ComboBox rPostFactor;
        private ComboBox cPostFactor;
        private ComboBox iPostFactor;
        private ComboBox tauPostFactor;
        private ComboBox vPostFactor;
        private ComboBox tPostFactor;
    }
}