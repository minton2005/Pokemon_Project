using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDEX
{
    public class Zubat : Pokemon
    {
        public Zubat()
        {
            this.Type = PokemonType.Flying;
            this.Height = 0.8;
            this.Weight = 7.5;
            this.HP = 40;
            this.Attack = 45;
            this.Defense = 35;
            this.SpecialAttack = 30;
            this.SpecialDefense = 40;
            this.Speed = 55;
            this.Total = 245;
            this.Name = "Zubat";
            byte[] pikachuImage = Resource1.ResourceManager.GetObject("Zubat") as byte[];
            if (pikachuImage != null)
            {
                this.image = pikachuImage;
            }
            else
            {
                // Handle cases where the image is not found
                // Option 1: Use a default image from resources
                this.image = PokemonDEX.Resource1.Zubat; // ต้องเพิ่มรูปภาพ DefaultPikachuImage ใน Resources
                // Option 2: Log an error message
                Console.WriteLine("Error: Pikachu image not found in resources.");
            }
        }
            public string Status { get; set; }
    }
    
}
