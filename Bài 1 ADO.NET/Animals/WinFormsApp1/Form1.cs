namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private Cow cows;
        private Goat goats;
        private Sheep sheeps;
        public Form1()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            cows = new Cow(Int32.Parse(textBox1.Text));
            goats = new Goat(Int32.Parse(textBox3.Text));
            sheeps = new Sheep(Int32.Parse(textBox2.Text));
            MessageBox.Show("Thêm số lượng thành công.");


        }

        private void TiengKeuBtn_Click(object sender, EventArgs e)
        {
            label4.Text = "Bò : " + cows.HungrySound();
            label5.Text = "Cừu : " + sheeps.HungrySound();
            label6.Text = "Dê : " + goats.HungrySound();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cows.GiveBirth();
            sheeps.GiveBirth();
            goats.GiveBirth();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label7.Text = "Số lượng bò: " + cows.NumberOfAnimals + ", số lít sữa :" + cows.ProduceMilk();
            label8.Text = "Số lượng cừu: " + sheeps.NumberOfAnimals + ", số lít sữa :" + sheeps.ProduceMilk();
            label9.Text = "Số lượng dê: " + goats.NumberOfAnimals + ", số lít sữa :" + goats.ProduceMilk();
        }
    }
}
