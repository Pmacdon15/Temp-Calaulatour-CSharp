namespace Temp_Calaulatour
{
    partial class FormCal
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
            textBox_Input = new TextBox();
            label1 = new Label();
            textBox_F = new TextBox();
            textBox_K = new TextBox();
            label2 = new Label();
            label3 = new Label();
            pictureBox_Temp_Indactor = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Temp_Indactor).BeginInit();
            SuspendLayout();
            // 
            // textBox_Input
            // 
            textBox_Input.Location = new Point(222, 104);
            textBox_Input.Name = "textBox_Input";
            textBox_Input.Size = new Size(184, 35);
            textBox_Input.TabIndex = 0;
            textBox_Input.TextChanged += textBox_Input_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 104);
            label1.Name = "label1";
            label1.Size = new Size(176, 30);
            label1.TabIndex = 1;
            label1.Text = "Temperature in C'";
            // 
            // textBox_F
            // 
            textBox_F.Location = new Point(579, 104);
            textBox_F.Name = "textBox_F";
            textBox_F.Size = new Size(175, 35);
            textBox_F.TabIndex = 2;
            // 
            // textBox_K
            // 
            textBox_K.Location = new Point(579, 177);
            textBox_K.Name = "textBox_K";
            textBox_K.Size = new Size(175, 35);
            textBox_K.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(439, 107);
            label2.Name = "label2";
            label2.Size = new Size(115, 30);
            label2.TabIndex = 5;
            label2.Text = "Fahrenheit'";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(439, 182);
            label3.Name = "label3";
            label3.Size = new Size(73, 30);
            label3.TabIndex = 6;
            label3.Text = "Kalvin'";
            // 
            // pictureBox_Temp_Indactor
            // 
            pictureBox_Temp_Indactor.Image = Properties.Resources.warm;
            pictureBox_Temp_Indactor.Location = new Point(93, 253);
            pictureBox_Temp_Indactor.Name = "pictureBox_Temp_Indactor";
            pictureBox_Temp_Indactor.Size = new Size(164, 159);
            pictureBox_Temp_Indactor.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Temp_Indactor.TabIndex = 7;
            pictureBox_Temp_Indactor.TabStop = false;
            pictureBox_Temp_Indactor.Visible = false;
            // 
            // FormCal
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 525);
            Controls.Add(pictureBox_Temp_Indactor);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox_K);
            Controls.Add(textBox_F);
            Controls.Add(label1);
            Controls.Add(textBox_Input);
            Name = "FormCal";
            Text = "Temperature Calculator";
            ((System.ComponentModel.ISupportInitialize)pictureBox_Temp_Indactor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_Input;
        private Label label1;
        private TextBox textBox_F;
        private TextBox textBox_K;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox_Temp_Indactor;
    }
}
