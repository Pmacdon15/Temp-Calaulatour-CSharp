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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCal));
            textBox_C = new TextBox();
            label1 = new Label();
            textBox_F = new TextBox();
            textBox_K = new TextBox();
            label2 = new Label();
            label3 = new Label();
            pictureBox_Temp_Indactor = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Temp_Indactor).BeginInit();
            SuspendLayout();
            // 
            // textBox_C
            // 
            textBox_C.Location = new Point(180, 31);
            textBox_C.Name = "textBox_C";
            textBox_C.Size = new Size(175, 35);
            textBox_C.TabIndex = 1;
            textBox_C.TextChanged += textBox_C_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(40, 31);
            label1.Name = "label1";
            label1.Size = new Size(82, 30);
            label1.TabIndex = 0;
            label1.Text = "Celsius'";
            // 
            // textBox_F
            // 
            textBox_F.Location = new Point(180, 91);
            textBox_F.Name = "textBox_F";
            textBox_F.Size = new Size(175, 35);
            textBox_F.TabIndex = 2;
            textBox_F.TextChanged += textBox_F_TextChanged;
            // 
            // textBox_K
            // 
            textBox_K.Location = new Point(180, 149);
            textBox_K.Name = "textBox_K";
            textBox_K.Size = new Size(175, 35);
            textBox_K.TabIndex = 3;
            textBox_K.TextChanged += textBox_K_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(40, 94);
            label2.Name = "label2";
            label2.Size = new Size(115, 30);
            label2.TabIndex = 5;
            label2.Text = "Fahrenheit'";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(40, 154);
            label3.Name = "label3";
            label3.Size = new Size(73, 30);
            label3.TabIndex = 6;
            label3.Text = "Kalvin'";
            // 
            // pictureBox_Temp_Indactor
            // 
            pictureBox_Temp_Indactor.BorderStyle = BorderStyle.Fixed3D;
            pictureBox_Temp_Indactor.Image = Properties.Resources.waiting;
            pictureBox_Temp_Indactor.Location = new Point(401, 31);
            pictureBox_Temp_Indactor.Name = "pictureBox_Temp_Indactor";
            pictureBox_Temp_Indactor.Size = new Size(165, 153);
            pictureBox_Temp_Indactor.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Temp_Indactor.TabIndex = 7;
            pictureBox_Temp_Indactor.TabStop = false;
            // 
            // FormCal
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            ClientSize = new Size(619, 234);
            Controls.Add(pictureBox_Temp_Indactor);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox_K);
            Controls.Add(textBox_F);
            Controls.Add(label1);
            Controls.Add(textBox_C);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormCal";
            Text = "Temperature Calculator";
            ((System.ComponentModel.ISupportInitialize)pictureBox_Temp_Indactor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_C;
        private Label label1;
        private TextBox textBox_F;
        private TextBox textBox_K;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox_Temp_Indactor;
    }
}
