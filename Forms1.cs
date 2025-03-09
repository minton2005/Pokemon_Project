using System.Data;
using System.Windows.Forms;

namespace PokemonDEX
{
    public partial class Form1 : Form
    {
        private List<Pokemon> pokemonsList = new List<Pokemon>();
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// when the form loads, the following code will be executed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //Create Pikachu object
            Pikachu pikachu = new Pikachu();
            //add Pikachu object to the list
            this.pokemonsList.Add(pikachu);
            //display the Pokemon's name and image
            this.displayPokemon(pikachu);
        }
        /// <summary>
        /// Display the Pokemon's name and image
        /// </summary>
        /// <param name="pokemon"></param>
        private void displayPokemon(Pokemon pokemon)
        {
            this.lblName.Text = pokemon.getName();
            using (var ms = new MemoryStream(pokemon.getImage()))
            {
                this.PTB1.Image = Image.FromStream(ms);

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Pikachu pikachu = new Pikachu(); // สร้างอ็อบเจ็กต์ Pikachu
            pikachu.Name = "Pikachu";
            pikachu.Type = Pokemon.PokemonType.Electric;
            pikachu.Status = "Normal";

            PTB1.Image = pikachu.getImageAsImage();
            PTB1.Visible = true;
            PTB1.BorderStyle = BorderStyle.FixedSingle;
            lblHeight.Text = "Height: " + pikachu.Height.ToString();
            lblWeight.Text = "Weight: " + pikachu.Weight.ToString();
            lblHP.Text = "HP: " + pikachu.HP.ToString();
            lblAttack.Text = "Attack: " + pikachu.Attack.ToString();
            lblDefense.Text = "Defense: " + pikachu.Defense.ToString();
            lblSpecialAttack.Text = "Special Attack: " + pikachu.SpecialAttack.ToString();
            lblSpecialDefense.Text = "Special Defense: " + pikachu.SpecialDefense.ToString();
            lblSpeed.Text = "Speed: " + pikachu.Speed.ToString();
            lblTotal.Text = "Total: " + pikachu.Total.ToString();
            lblName.Text = "Name: " + pikachu.Name.ToString();
            lblType.Text = "Type: " + pikachu.Type.ToString();

            lblName.Visible = true;
            lblType.Visible = true;
            lblStatus.Visible = true;
            lblHeight.Visible = true;
            lblWeight.Visible = true;
            lblHP.Visible = true;
            lblAttack.Visible = true;
            lblDefense.Visible = true;
            lblAttack.Visible = true;
            lblDefense.Visible = true;
            lblSpecialDefense.Visible = true;
            lblSpecialAttack.Visible = true;
            lblSpeed.Visible = true;
            lblTotal.Visible = true;
        }

        private void PTB2_Click(object sender, EventArgs e)
        {
            Snorlax snorlax = new Snorlax();

            PTB1.Image = snorlax.getImageAsImage();
            PTB1.Visible = true;
            PTB1.BorderStyle = BorderStyle.FixedSingle;
            lblHeight.Text = "Height: " + snorlax.Height.ToString();
            lblWeight.Text = "Weight: " + snorlax.Weight.ToString();
            lblHP.Text = "HP: " + snorlax.HP.ToString();
            lblAttack.Text = "Attack: " + snorlax.Attack.ToString();
            lblDefense.Text = "Defense: " + snorlax.Defense.ToString();
            lblSpecialAttack.Text = "Special Attack: " + snorlax.SpecialAttack.ToString();
            lblSpecialDefense.Text = "Special Defense: " + snorlax.SpecialDefense.ToString();
            lblSpeed.Text = "Speed: " + snorlax.Speed.ToString();
            lblTotal.Text = "Total: " + snorlax.Total.ToString();
            lblName.Text = "Name: " + snorlax.Name.ToString();
            lblType.Text = "Type: " + snorlax.Type.ToString();
            lblStatus.Text = snorlax.Status;

            lblName.Visible = true;
            lblType.Visible = true;
            lblStatus.Visible = true;
            lblHeight.Visible = true;
            lblWeight.Visible = true;
            lblHP.Visible = true;
            lblAttack.Visible = true;
            lblDefense.Visible = true;
            lblSpecialDefense.Visible = true;
            lblSpecialAttack.Visible = true;
            lblSpeed.Visible = true;
            lblTotal.Visible = true;
        }

        private void PTB3_Click(object sender, EventArgs e)
        {
            Zubat zubat = new Zubat();
            PTB1.Image = zubat.getImageAsImage();
            PTB1.Visible = true;
            PTB1.BorderStyle = BorderStyle.FixedSingle;
            lblHeight.Text = "Height: " + zubat.Height.ToString();
            lblWeight.Text = "Weight: " + zubat.Weight.ToString();
            lblHP.Text = "HP: " + zubat.HP.ToString();
            lblAttack.Text = "Attack: " + zubat.Attack.ToString();
            lblDefense.Text = "Defense: " + zubat.Defense.ToString();
            lblSpecialAttack.Text = "Special Attack: " + zubat.SpecialAttack.ToString();
            lblSpecialDefense.Text = "Special Defense: " + zubat.SpecialDefense.ToString();
            lblSpeed.Text = "Speed: " + zubat.Speed.ToString();
            lblTotal.Text = "Total: " + zubat.Total.ToString();
            lblName.Text = "Name: " + zubat.Name.ToString();
            lblType.Text = "Type: " + zubat.Type.ToString();
            lblStatus.Text = zubat.Status;

            lblName.Visible = true;
            lblType.Visible = true;
            lblStatus.Visible = true;
            lblHeight.Visible = true;
            lblWeight.Visible = true;
            lblHP.Visible = true;
            lblAttack.Visible = true;
            lblDefense.Visible = true;
            lblSpecialDefense.Visible = true;
            lblSpecialAttack.Visible = true;
            lblSpeed.Visible = true;
            lblTotal.Visible = true;

        }

        private void PTB4_Click(object sender, EventArgs e)
        {
            Zapdos zapdos = new Zapdos();
            PTB1.Image = zapdos.getImageAsImage();
            PTB1.Visible = true;
            PTB1.BorderStyle = BorderStyle.FixedSingle;
            lblHeight.Text = "Height: " + zapdos.Height.ToString();
            lblWeight.Text = "Weight: " + zapdos.Weight.ToString();
            lblHP.Text = "HP: " + zapdos.HP.ToString();
            lblAttack.Text = "Attack: " + zapdos.Attack.ToString();
            lblDefense.Text = "Defense: " + zapdos.Defense.ToString();
            lblSpecialAttack.Text = "Special Attack: " + zapdos.SpecialAttack.ToString();
            lblSpecialDefense.Text = "Special Defense: " + zapdos.SpecialDefense.ToString();
            lblSpeed.Text = "Speed: " + zapdos.Speed.ToString();
            lblTotal.Text = "Total: " + zapdos.Total.ToString();
            lblName.Text = "Name: " + zapdos.Name.ToString();
            lblType.Text = "Type: " + zapdos.Type.ToString();
            lblStatus.Text = zapdos.Status;

            lblName.Visible = true;
            lblType.Visible = true;
            lblStatus.Visible = true;
            lblHeight.Visible = true;
            lblWeight.Visible = true;
            lblHP.Visible = true;
            lblAttack.Visible = true;
            lblDefense.Visible = true;
            lblSpecialDefense.Visible = true;
            lblSpecialAttack.Visible = true;
            lblSpeed.Visible = true;
            lblTotal.Visible = true;
        }

        private void PTB5_Click(object sender, EventArgs e)
        {
            Kyogre kyogre = new Kyogre();
            PTB1.Image = kyogre.getImageAsImage();
            PTB1.Visible = true;
            PTB1.BorderStyle = BorderStyle.FixedSingle;
            lblHeight.Text = "Height: " + kyogre.Height.ToString();
            lblWeight.Text = "Weight: " + kyogre.Weight.ToString();
            lblHP.Text = "HP: " + kyogre.HP.ToString();
            lblAttack.Text = "Attack: " + kyogre.Attack.ToString();
            lblDefense.Text = "Defense: " + kyogre.Defense.ToString();
            lblSpecialAttack.Text = "Special Attack: " + kyogre.SpecialAttack.ToString();
            lblSpecialDefense.Text = "Special Defense: " + kyogre.SpecialDefense.ToString();
            lblSpeed.Text = "Speed: " + kyogre.Speed.ToString();
            lblTotal.Text = "Total: " + kyogre.Total.ToString();
            lblName.Text = "Name: " + kyogre.Name.ToString();
            lblType.Text = "Type: " + kyogre.Type.ToString();
            lblStatus.Text = kyogre.Status;

            lblName.Visible = true;
            lblType.Visible = true;
            lblStatus.Visible = true;
            lblHeight.Visible = true;
            lblWeight.Visible = true;
            lblHP.Visible = true;
            lblAttack.Visible = true;
            lblDefense.Visible = true;
            lblSpecialDefense.Visible = true;
            lblSpecialAttack.Visible = true;
            lblSpeed.Visible = true;
            lblTotal.Visible = true;
        }

        private void PTB6_Click(object sender, EventArgs e)
        {
            Shaymin shaymin = new Shaymin();
            PTB1.Image = shaymin.getImageAsImage();
            PTB1.Visible = true;
            PTB1.BorderStyle = BorderStyle.FixedSingle;
            lblHeight.Text = "Height: " + shaymin.Height.ToString();
            lblWeight.Text = "Weight: " + shaymin.Weight.ToString();
            lblHP.Text = "HP: " + shaymin.HP.ToString();
            lblAttack.Text = "Attack: " + shaymin.Attack.ToString();
            lblDefense.Text = "Defense: " + shaymin.Defense.ToString();
            lblSpecialAttack.Text = "Special Attack: " +shaymin.SpecialAttack.ToString();
            lblSpecialDefense.Text = "Special Defense: " + shaymin.SpecialDefense.ToString();
            lblSpeed.Text = "Speed: " + shaymin.Speed.ToString();
            lblTotal.Text = "Total: " + shaymin.Total.ToString();
            lblName.Text = "Name: " + shaymin.Name.ToString();
            lblType.Text = "Type: " + shaymin.Type.ToString();
            lblStatus.Text = shaymin.Status;

            lblName.Visible = true;
            lblType.Visible = true;
            lblStatus.Visible = true;
            lblHeight.Visible = true;
            lblWeight.Visible = true;
            lblHP.Visible = true;
            lblAttack.Visible = true;
            lblDefense.Visible = true;
            lblSpecialDefense.Visible = true;
            lblSpecialAttack.Visible = true;
            lblSpeed.Visible = true;
            lblTotal.Visible = true;
        }
    }
}
