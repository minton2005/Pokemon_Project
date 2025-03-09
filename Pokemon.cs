using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDEX
{
    public enum PokemonType
    {
        Normal,
        Flying,
        Electric  
    }
    public class Pokemon
    {
        public string Name { get; set; } // เปลี่ยน protected เป็น public
        public int HP { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int SpecialAttack { get; set; }
        public int SpecialDefense { get; set; }
        public int Speed { get; set; }
        public int Total { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public string Species { get; set; }
        public PokemonType Type { get; set; } // เปลี่ยน protected เป็น public
        protected byte[] image;
        public Pokemon() 
        {
            this.Name = "Unknown";
            this.Species = "Unknown";
            this.image = Array.Empty<byte>(); // กำหนดเป็น empty byte array
        }
        //methods
        public string getName()
        {
            return this.Name;
        }
        public byte[] getImage()
        {
            return this.image;
        }
        public System.Drawing.Image getImageAsImage()
        {
            if (this.image != null && this.image.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(this.image))
                {
                    return System.Drawing.Image.FromStream(ms);
                }
            }
            return null; // คืนค่า null หากไม่มีรูปภาพ
        }
        public enum PokemonType { Normal, Flying, Electric, Water, Grass }
    }
}
