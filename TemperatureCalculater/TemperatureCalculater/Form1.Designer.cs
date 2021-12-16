namespace TemperatureCalculater
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
            this.buttonConvert1 = new System.Windows.Forms.Button();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.textBoxF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.te = new System.Windows.Forms.Label();
            this.buttonConvert2 = new System.Windows.Forms.Button();
            this.Clear1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonConvert1
            // 
            this.buttonConvert1.Location = new System.Drawing.Point(276, 32);
            this.buttonConvert1.Name = "buttonConvert1";
            this.buttonConvert1.Size = new System.Drawing.Size(94, 29);
            this.buttonConvert1.TabIndex = 0;
            this.buttonConvert1.Text = "Convert";
            this.buttonConvert1.UseVisualStyleBackColor = true;
            this.buttonConvert1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(35, 36);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(175, 27);
            this.textBoxC.TabIndex = 2;
            this.textBoxC.TextChanged += new System.EventHandler(this.textBoxC_TextChanged);
            // 
            // textBoxF
            // 
            this.textBoxF.Location = new System.Drawing.Point(35, 69);
            this.textBoxF.Name = "textBoxF";
            this.textBoxF.Size = new System.Drawing.Size(175, 27);
            this.textBoxF.TabIndex = 3;
            this.textBoxF.TextChanged += new System.EventHandler(this.textBoxF_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "C";
            // 
            // te
            // 
            this.te.AutoSize = true;
            this.te.Location = new System.Drawing.Point(228, 72);
            this.te.Name = "te";
            this.te.Size = new System.Drawing.Size(16, 20);
            this.te.TabIndex = 5;
            this.te.Text = "F";
            // 
            // buttonConvert2
            // 
            this.buttonConvert2.Location = new System.Drawing.Point(276, 72);
            this.buttonConvert2.Name = "buttonConvert2";
            this.buttonConvert2.Size = new System.Drawing.Size(94, 29);
            this.buttonConvert2.TabIndex = 6;
            this.buttonConvert2.Text = "Convert";
            this.buttonConvert2.UseVisualStyleBackColor = true;
            this.buttonConvert2.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Clear1
            // 
            this.Clear1.Location = new System.Drawing.Point(398, 32);
            this.Clear1.Name = "Clear1";
            this.Clear1.Size = new System.Drawing.Size(129, 73);
            this.Clear1.TabIndex = 7;
            this.Clear1.Text = "Clear";
            this.Clear1.UseVisualStyleBackColor = true;
            this.Clear1.Click += new System.EventHandler(this.Clear1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Clear1);
            this.Controls.Add(this.buttonConvert2);
            this.Controls.Add(this.te);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxF);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.buttonConvert1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonConvert1;
        private TextBox textBoxC;
        private TextBox textBoxF;
        private Label label1;
        private Label te;
        private Button buttonConvert2;
        private Button Clear1;
    }
}