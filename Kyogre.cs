using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDEX
{
    public class Kyogre : Pokemon
    {
        public Kyogre()
        {
            this.Type = PokemonType.Water;
            this.Height = 4.5;
            this.Weight = 352.0;
            this.HP = 100;
            this.Attack = 100;
            this.Defense = 90;
            this.SpecialAttack = 150;
            this.SpecialDefense = 140;
            this.Speed = 90;
            this.Total = 670;
            this.Name = "Kyogre";
            byte[] KyogreImage = Resource1.ResourceManager.GetObject("Kyogre") as byte[];
            if (KyogreImage != null)
            {
                this.image = KyogreImage;
            }
            else
            {
                // Handle cases where the image is not found
                // Option 1: Use a default image from resources
                this.image = PokemonDEX.Resource1.Kyogre; // ต้องเพิ่มรูปภาพ DefaultPikachuImage ใน Resources
                // Option 2: Log an error message
                Console.WriteLine("Error: Kyogre image not found in resources.");
            }
        }
        public string Status { get; set; }
    }
}
