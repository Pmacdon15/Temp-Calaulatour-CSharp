namespace Temp_Calaulatour
{
    public partial class FormCal : Form
    {
        public FormCal()
        {
            InitializeComponent();
        }

      

        private void textBox_Input_TextChanged(object sender, EventArgs e)
        {
            // Try to parse the input value as a double
            if (double.TryParse(textBox_Input.Text, out double celsius))
            {
                // Convert Celsius to Fahrenheit
                double fahrenheit = (celsius * 9 / 5) + 32;
                // Convert Celsius to Kelvin
                double kelvin = celsius + 273.15;

                // Set the values to the respective text boxes
                textBox_F.Text = fahrenheit.ToString("F2"); // Format to 2 decimal places
                textBox_K.Text = kelvin.ToString("F2"); // Format to 2 decimal places

                //Set Image 
                if (celsius < 15)
                {
                    pictureBox_Temp_Indactor.Visible= true;
                    pictureBox_Temp_Indactor.Image = Properties.Resources.cold;
                }           
                else
                {
                    pictureBox_Temp_Indactor.Visible = true;
                    pictureBox_Temp_Indactor.Image = Properties.Resources.warm;
                }
            }
            else
            {
                // Clear the output text boxes if the input is not a valid number
                textBox_F.Clear();
                textBox_K.Clear();
                pictureBox_Temp_Indactor.Visible=false;

            }
        }
    }
}