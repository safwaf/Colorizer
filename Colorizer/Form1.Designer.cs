namespace Colorizer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DisplayBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.ColorizeButton = new System.Windows.Forms.Button();
            this.BluePicker = new System.Windows.Forms.NumericUpDown();
            this.GreenPicker = new System.Windows.Forms.NumericUpDown();
            this.RedPicker = new System.Windows.Forms.NumericUpDown();
            this.LoadButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BluePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedPicker)).BeginInit();
            this.SuspendLayout();
            // 
            // DisplayBox
            // 
            this.DisplayBox.Location = new System.Drawing.Point(12, 12);
            this.DisplayBox.Name = "DisplayBox";
            this.DisplayBox.Size = new System.Drawing.Size(320, 320);
            this.DisplayBox.TabIndex = 0;
            this.DisplayBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Red";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Green";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Blue";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Bitmap File(*.BMP)|*.BMP;";
            // 
            // ColorizeButton
            // 
            this.ColorizeButton.Location = new System.Drawing.Point(338, 132);
            this.ColorizeButton.Name = "ColorizeButton";
            this.ColorizeButton.Size = new System.Drawing.Size(120, 32);
            this.ColorizeButton.TabIndex = 4;
            this.ColorizeButton.Text = "Colorize";
            this.ColorizeButton.UseVisualStyleBackColor = true;
            this.ColorizeButton.Click += new System.EventHandler(this.ColorizeButton_Click);
            // 
            // BluePicker
            // 
            this.BluePicker.Location = new System.Drawing.Point(338, 106);
            this.BluePicker.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.BluePicker.Name = "BluePicker";
            this.BluePicker.Size = new System.Drawing.Size(120, 20);
            this.BluePicker.TabIndex = 5;
            // 
            // GreenPicker
            // 
            this.GreenPicker.Location = new System.Drawing.Point(338, 67);
            this.GreenPicker.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.GreenPicker.Name = "GreenPicker";
            this.GreenPicker.Size = new System.Drawing.Size(120, 20);
            this.GreenPicker.TabIndex = 6;
            // 
            // RedPicker
            // 
            this.RedPicker.Location = new System.Drawing.Point(338, 28);
            this.RedPicker.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.RedPicker.Name = "RedPicker";
            this.RedPicker.Size = new System.Drawing.Size(120, 20);
            this.RedPicker.TabIndex = 7;
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(338, 170);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(118, 31);
            this.LoadButton.TabIndex = 8;
            this.LoadButton.Text = "Load Image";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(338, 207);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(118, 31);
            this.SaveButton.TabIndex = 9;
            this.SaveButton.Text = "Save Image";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 369);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.RedPicker);
            this.Controls.Add(this.GreenPicker);
            this.Controls.Add(this.BluePicker);
            this.Controls.Add(this.ColorizeButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DisplayBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DisplayBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BluePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenPicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedPicker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox DisplayBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button ColorizeButton;
        private System.Windows.Forms.NumericUpDown BluePicker;
        private System.Windows.Forms.NumericUpDown GreenPicker;
        private System.Windows.Forms.NumericUpDown RedPicker;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button SaveButton;
    }
}

