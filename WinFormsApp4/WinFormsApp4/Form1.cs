namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAngleConversionCalculator newform = new FormAngleConversionCalculator();
            newform.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormCoordinateCalculation newform = new FormCoordinateCalculation();
            newform.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormIntersectionCalculation newform = new FormIntersectionCalculation();   
            newform.ShowDialog();
        }
    }
}
