using System.Resources;

namespace LAB04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button_LoadPokemon_Click(object sender, EventArgs e)
        {
            Pikachu pikachu = new Pikachu();
            labelname.Text = pikachu.Name();
            //เพิ่มที่อยู่ไฟล์ภาพ
            pictureBox1.Image = LAB04.Properties.Resources.f3e1b8019f160f88531d8af792716b4f;
        }

        private void button_LoadPokemon1_Click(object sender, EventArgs e)
        {
            Mewtwo mewtwo = new Mewtwo();
            labelname.Text = mewtwo.Name();
            pictureBox1.Image = LAB04.Properties.Resources.Mewtwo;
        }

        private void button_LoadPokemon2_Click(object sender, EventArgs e)
        {
            Mimikyu mimikyu = new Mimikyu();
            labelname.Text = mimikyu.Name();
            pictureBox1.Image = LAB04.Properties.Resources.Mimikyu;
        }

        private void button_LoadPokemon3_Click(object sender, EventArgs e)
        {
            Geodude geodude = new Geodude();
            labelname.Text = geodude.Name();
            pictureBox1.Image = LAB04.Properties.Resources.Geodude;
        }

        private void button_LoadPokemon4_Click(object sender, EventArgs e)
        {
            Onix onix = new Onix();
            labelname.Text = onix.Name();
            pictureBox1.Image = LAB04.Properties.Resources.Onix;
        }

        private void button_LoadPokemon5_Click(object sender, EventArgs e)
        {
            Voltorb voltorb = new Voltorb();
            labelname.Text = voltorb.Name();
            pictureBox1.Image = LAB04.Properties.Resources.Voltorb;
        }

        private void button_LoadPokemon6_Click(object sender, EventArgs e)
        {
            Meowth meowth = new Meowth();
            labelname1.Text = meowth.Name();
            pictureBox.Image = LAB04.Properties.Resources.Meowth;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
