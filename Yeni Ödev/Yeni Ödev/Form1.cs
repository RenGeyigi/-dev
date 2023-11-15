namespace Yeni_Ödev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("İşçi");
            comboBox1.Items.Add("muhendis");




        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personel pers = new Personel
                (adTxt.Text, adresTxt.Text, comboBox1.Text, Convert.ToInt32(yasTxt.Text), Convert.ToInt32(mesaiTxt.Text));

            if (comboBox1.Text == "İşçi")

            {
                MessageBox.Show(pers.ucretHesapla().ToString());

            }
            else
            {
                pers.ucretHesapla(1000);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }





        private void button2_Click(object sender, EventArgs e)
        {
            muhendis muh = new muhendis();
            muh.Ad = AdTxt2.Text;
            muh.Adres = AdresTxt2.Text;
            muh.Yas = Convert.ToInt32(YasTxt2.Text);
            muh.Unvan = comboBox2.Text;
            muh.Mesai = Convert.ToInt32(MesaiTxt2.Text);
            muh.Birim = birimTxt2.Text;
            MessageBox.Show(muh.ucretHesapla().ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            isci iscim = new isci(adTxt3.Text, adresTxt3.Text, Convert.ToInt32(yasTxt3.Text), unvanTxt3.Text, Convert.ToInt32(mesaiTxt3.Text), turTxt3.Text);
            MessageBox.Show(iscim.ucretHesapla().ToString());
        }
    }


}
