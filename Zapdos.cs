using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDEX
{
    public class Zapdos : Pokemon
    {
        public Zapdos()
        {
            this.Type = PokemonType.Electric;
            this.Height = 1.6;
            this.Weight = 52.6;
            this.HP = 90;
            this.Attack = 90;
            this.Defense = 85;
            this.SpecialAttack = 125;
            this.SpecialDefense = 90;
            this.Speed = 100;
            this.Total = 580;
            this.Name = "Zapdos";
            byte[] ZapdosImage = Resource1.ResourceManager.GetObject("Zapdos") as byte[];
            if (ZapdosImage != null)
            {
                this.image = ZapdosImage;
            }
            else
            {
                // Handle cases where the image is not found
                // Option 1: Use a default image from resources
                this.image = PokemonDEX.Resource1.Zapdos; // ต้องเพิ่มรูปภาพ DefaultPikachuImage ใน Resources
                // Option 2: Log an error message
                Console.WriteLine("Error: Zapdos image not found in resources.");
            }
        }
        public string Status { get; set; }
    }
}
