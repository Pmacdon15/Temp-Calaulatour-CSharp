using System.Diagnostics.CodeAnalysis;

namespace Temp_Calaulatour
{
    public partial class FormCal : Form
    {
        public FormCal()
        {
            InitializeComponent();
        }

        private void textBox_C_TextChanged(object sender, EventArgs e)
        {
            // Try to parse the input value as a double
            if (double.TryParse(textBox_C.Text, out double celsius))
            {
                // Convert Celsius to Fahrenheit
                double fahrenheit = getFahrenheit(celsius);
                // Convert Celsius to Kelvin
                double kelvin = getKelvin(celsius);

                // Set the values to the respective text boxes
                textBox_F.Text = fahrenheit.ToString("F0"); // Format to 0 decimal places
                textBox_K.Text = kelvin.ToString("F0"); // Format to 0 decimal places

                //Set Image 
                setImage(celsius);
            }
            else
            {
                clearAllButThisTextBox("C");
            }
        }

        private void textBox_F_TextChanged(object sender, EventArgs e)
        {
            // Try to parse the input value as a double
            if (double.TryParse(textBox_F.Text, out double fahrenheit))
            {
                // Convert Fahrenheit to Celsius
                double celsius = getCelsiusFromFahrenheit(fahrenheit);
                // Convert Celsius to Kelvin
                double kelvin = getKelvin(celsius);

                // Set the values to the respective text boxes
                textBox_K.Text = kelvin.ToString("F0"); // Format to 0 decimal places
                textBox_C.Text = celsius.ToString("F0"); // Format to 0 decimal places

                //Set Image 
                setImage(celsius);
            }
            else
            {
                clearAllButThisTextBox("F");
            }
        }

        private void textBox_K_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox_K.Text, out double kelvin))
            {
                // Convert Kelvin to Celsius
                double celsius = getCelsiusFromKelvin(kelvin);
                // Convert Celsius to Fahrenheit
                double fahrenheit = getFahrenheit(celsius);

                // Set the values to the respective text boxes
                textBox_C.Text = celsius.ToString("F0"); // Format to 0 decimal places
                textBox_F.Text = fahrenheit.ToString("F0"); // Format to 0 decimal places

                //Set Image 
                setImage(celsius);
            }
            else
            {
                clearAllButThisTextBox("K");
            }
        }

        private void setImage(double celsius)
        {
            if (celsius < 15)
            {
                pictureBox_Temp_Indactor.Visible = true;
                pictureBox_Temp_Indactor.Image = Properties.Resources.cold;
            }
            else
            {
                pictureBox_Temp_Indactor.Visible = true;
                pictureBox_Temp_Indactor.Image = Properties.Resources.warm;
            }
        }
        double getCelsiusFromFahrenheit(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
        double getCelsiusFromKelvin(double kelvin)
        {
            return kelvin - 273.15;
        }
        double getFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }
        double getKelvin(double celsius)
        {
            return celsius + 273.15;
        }
        private void clearAllButThisTextBox(string boxToexclude)
        {
            // Clear the output text boxes excpet the one that is being edited
            if (boxToexclude == "C")
            {
                textBox_F.Clear();
                textBox_K.Clear();
                pictureBox_Temp_Indactor.Image = Properties.Resources.waiting;
            }
            else if (boxToexclude == "F")
            {
                textBox_C.Clear();
                textBox_K.Clear();
                pictureBox_Temp_Indactor.Image = Properties.Resources.waiting;
            }
            else
            {
                textBox_C.Clear();
                textBox_F.Clear();
                pictureBox_Temp_Indactor.Image = Properties.Resources.waiting;
            }
        }

      
    }


}