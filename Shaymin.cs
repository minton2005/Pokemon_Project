using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDEX
{
    public class Shaymin : Pokemon
    {
        public Shaymin()
        {
            this.Type = PokemonType.Grass;
            this.Height = 0.2;
            this.Weight = 2.1;
            this.HP = 100;
            this.Attack = 100;
            this.Defense = 100;
            this.SpecialAttack = 100;
            this.SpecialDefense = 100;
            this.Speed = 100;
            this.Total = 600;
            this.Name = "Shaymin";
            byte[] ShayminImage = Resource1.ResourceManager.GetObject("Shaymin") as byte[];
            if (pikachuImage != null)
            {
                this.image = ShayminImage;
            }
            else
            {
                // Handle cases where the image is not found
                // Option 1: Use a default image from resources
                this.image = PokemonDEX.Resource1.Shaymin; // ต้องเพิ่มรูปภาพ DefaultPikachuImage ใน Resources
                // Option 2: Log an error message
                Console.WriteLine("Error: Shaymin image not found in resources.");
            }
        }
        public string Status { get; set; }
    }
}
