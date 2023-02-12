using pokemon3.Pokemonbebmanow;
using System.Runtime.CompilerServices;
namespace pokemon3
{
    public partial class Form1 : Form
    {   
        List<Pokemon33> Pokelist = new List<Pokemon33>();
        Pokemon33 SelPokemon;
        Pokemon33 Monster;
        public Form1()
        {
            InitializeComponent();
            CLEARGAME();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void PRObutton1_Click(object sender, EventArgs e)
        {
            if (Pokelist[3].GetHP()<=0)
            {
                MessageBox.Show("HE IS DEAD");
            }
            else
            {
                SelPokemon=Pokelist[3];
                this.pictureBox1.Image = SelPokemon.getImage();
                this.textBox1.Text = SelPokemon.GetName();
                this.textBoxHP1.Text = SelPokemon.GetHP().ToString();
                this.textBoxAt1.Text = SelPokemon.GetAtk().ToString();
            }
        }

        private void PRObutton2_Click(object sender, EventArgs e)
        {
            if (Pokelist[0].GetHP() <= 0)
            {
                MessageBox.Show("He is Dead !!");
            }
            else
            {
                SelPokemon = Pokelist[0];
                this.pictureBox1.Image = SelPokemon.getImage();
                this.textBox1.Text = SelPokemon.GetName();
                this.textBoxHP1.Text = SelPokemon.GetHP().ToString();
                this.textBoxAt1.Text = SelPokemon.GetAtk().ToString();
            }
        }

        private void PRObutton3_Click(object sender, EventArgs e)
        {
            if (Pokelist[1].GetHP() <= 0)
            {
                MessageBox.Show("He is Dead !!");
            }
            else
            {
                SelPokemon = Pokelist[1];
                this.pictureBox1.Image = SelPokemon.getImage();
                this.textBox1.Text = SelPokemon.GetName();
                this.textBoxHP1.Text = SelPokemon.GetHP().ToString();
                this.textBoxAt1.Text = SelPokemon.GetAtk().ToString();
            }
        }

        private void PRObutton4_Click(object sender, EventArgs e)
        {
            if (Pokelist[2].GetHP() <= 0)
            {
                MessageBox.Show("He is Dead !!");
            }
            else
            {
                SelPokemon = Pokelist[2];
                this.pictureBox1.Image = SelPokemon.getImage();
                this.textBox1.Text = SelPokemon.GetName();
                this.textBoxHP1.Text = SelPokemon.GetHP().ToString();
                this.textBoxAt1.Text = SelPokemon.GetAtk().ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, Pokelist.Count);
            Monster = Pokelist[randomIndex];
            this.pictureBox2.Image = Monster.getImage();
            this.textBoxName4.Text = Monster.GetName();
            this.textBoxHP2.Text = Monster.GetHP().ToString();
            this.textBoxAt2.Text = Monster.GetAtk().ToString();
        }

        private void Atbutton1_Click(object sender, EventArgs e)
        {
            int PokemonHP = SelPokemon.GetHP();
            int PokemonATTACK = SelPokemon.GetAtk();
            int MonsterHP = Monster.GetHP();
            int MonsterATTACK = Monster.GetAtk();
            if (SelPokemon != null && Monster != null)
            {
                if (Monster.GetHP() >0)
                {
                    if (SelPokemon.GetHP()<0)
                    {
                        MessageBox.Show("Pokemon has died. Please choose a different Pokemon");
                    }
                    else
                    {
                        Monster.setHP(Monster.GetHP() - SelPokemon.GetAtk());
                        SelPokemon.setHP(SelPokemon.GetHP() - Monster.GetAtk());
                        textBoxHP1.Text = SelPokemon.GetHP().ToString();
                        textBoxHP2.Text = Monster.GetHP().ToString();
                    }
                }
                if (SelPokemon.GetHP()<0)
                {
                    textBoxHP1.Text = "0";
                    MessageBox.Show("Pokemon has died. Please choose a different Pokemon");

                }
                if (Monster.GetHP()<0)
                {
                    textBoxHP2.Text = "0";
                    MessageBox.Show("defeated the enemy");
                    CLEARGAME();


                    return;
                }
            }
            else
            {
                MessageBox.Show("SUCESS");
            }

        }
        void CLEARGAME()
        {
            Pokelist.Clear();
            Pokelist.Add(new Ivysaur());
            Pokelist.Add(new Monster());
            Pokelist.Add(new Rowlet());
            Pokelist.Add(new Sprigatito());
            textBoxAt1.Text = "";
            textBoxAt2.Text = "";
            textBoxHP1.Text = "";
            textBoxHP2.Text = "";
            textBox1.Text = "";
            textBoxName4.Text = "";
        }

        private void textBoxHP2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}