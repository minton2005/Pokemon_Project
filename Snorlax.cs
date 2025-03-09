using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDEX
{
    public class Snorlax : Pokemon
    {
        public Snorlax()
        {
            this.Type = PokemonType.Normal;
            this.Height = 2.1;
            this.Weight = 460.0;
            this.HP = 160;
            this.Attack = 110;
            this.Defense = 65;
            this.SpecialAttack = 65;
            this.SpecialDefense = 110;
            this.Speed = 30;
            this.Total = 540;
            this.Name = "Snorlax";
            byte[] pikachuImage = Resource1.ResourceManager.GetObject("Snorlax") as byte[];
            if (pikachuImage != null)
            {
                this.image = pikachuImage;
            }
            else
            {
                // Handle cases where the image is not found
                // Option 1: Use a default image from resources
                this.image = PokemonDEX.Resource1.Snorlax; // ต้องเพิ่มรูปภาพ DefaultPikachuImage ใน Resources

                // Option 2: Log an error message
                Console.WriteLine("Error: Pikachu image not found in resources.");
            }
        }
        public string Status { get; set; }
    }
}

