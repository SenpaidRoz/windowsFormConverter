namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Получим нажатый символ
            char number = e.KeyChar;

            //Фильтруем символы. Цифры, клавиша BackSpace , запятая и ASCII
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44)
            {
                //
                e.Handled = true;
            }

            //
            if((textBox1.Text.Contains(',') == true) & (number == 44))
            {
                e.Handled=true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //
            double numb = 0.0;

            //
            numb = Convert.ToDouble(textBox1.Text);

            //
            if (checkBox1.Checked == true)
            {
                //
                numb = numb / 2.54;
            }
            else
            {
                numb = numb * 2.54;
            }

            //
            label3.Text = numb.ToString();
        }
    }
}