namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        double brackingDistance;
        public Form1()
        {
            InitializeComponent();

            //animation.Dock = DockStyle.Fill;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                brackingDistance = GetBrackingDistance(double.Parse(textBox1.Text), GetFriction());



                brackingDistanceField.Text = $"С учетом указанных условий рассчета, тормозной путь автомобиля составит {brackingDistance} метров";
            }
            else
                MessageBox.Show("Введите скорость автомобиля");

        }

        double GetFriction()
        {
            if (asphalt.Checked)
            {
                if (summerTires.Checked)
                {
                    if (weather_dry.Checked) return 0.87;
                    if (weather_rain.Checked) return 0.7;
                    if (weather_snow.Checked) return 0.3;
                    if (weather_ice.Checked) return 0.1;
                }
                else if (winterTires.Checked)
                {
                    if (weather_dry.Checked) return 0.9;
                    if (weather_rain.Checked) return 0.8;
                    if (weather_snow.Checked) return 0.35;
                    if (weather_ice.Checked) return 0.2;
                }
                else if (skinTires.Checked)
                {
                    if (weather_dry.Checked) return 0.7;
                    if (weather_rain.Checked) return 0.6;
                    if (weather_snow.Checked) return 0.2;
                    if (weather_ice.Checked) return 0.05;
                }
            }
            else if (gravel.Checked)
            {
                if (summerTires.Checked)
                {
                    if (weather_dry.Checked) return 0.6;
                    if (weather_rain.Checked) return 0.4;
                    if (weather_snow.Checked) return 0.2;
                    if (weather_ice.Checked) return 0.1;
                }
                else if (winterTires.Checked)
                {
                    if (weather_dry.Checked) return 0.63;
                    if (weather_rain.Checked) return 0.42;
                    if (weather_snow.Checked) return 0.23;
                    if (weather_ice.Checked) return 0.11;
                }
                else if (skinTires.Checked)
                {
                    if (weather_dry.Checked) return 0.32;
                    if (weather_rain.Checked) return 0.26;
                    if (weather_snow.Checked) return 0.1;
                    if (weather_ice.Checked) return 0.01;
                }
            }
            else if (primming.Checked)
            {
                if (summerTires.Checked)
                {
                    if (weather_dry.Checked) return 0.65;
                    if (weather_rain.Checked) return 0.45;
                    if (weather_snow.Checked) return 0.23;
                    if (weather_ice.Checked) return 0.12;
                }
                else if (winterTires.Checked)
                {
                    if (weather_dry.Checked) return 0.68;
                    if (weather_rain.Checked) return 0.48;
                    if (weather_snow.Checked) return 0.26;
                    if (weather_ice.Checked) return 0.15;
                }
                else if (skinTires.Checked)
                {
                    if (weather_dry.Checked) return 0.4;
                    if (weather_rain.Checked) return 0.18;
                    if (weather_snow.Checked) return 0.05;
                    if (weather_ice.Checked) return 0.02;
                }
            }

            return 0;
        }

        double GetBrackingDistance(double startingSpeed, double friction)
        {
            //d = (v ^ 2 / 2μg)
            startingSpeed = startingSpeed * 1000 / 3600;// км/час переводим в м/с

            return Math.Pow(startingSpeed, 2) / (2 * friction * 9.8);
        }
    }
}