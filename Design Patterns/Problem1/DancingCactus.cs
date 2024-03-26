using System;
using System.Collections.Generic;
using System.Text;

namespace Problem1
{
    /// <summary>
    /// Dancing Cactus class extends IToy and used properties and have additional 3 propertites and 2 methods - Turning on and off dancing 
    /// </summary>
    public class DancingCactus : IToy
    {
        public bool Chargable { get; set; }
        public bool CanMemic { get; set; }
        public bool CanSingASong { get; set; }

        public DancingCactus()
        {
            Cost = 28.50;
            Description = "🌵 【Upgrade Version - Dancing Cactus Toy】Please look for the store \"Shikimur\" when purchasing, we are not responsible for quality problems when purchasing from other stores, Upgraded version of funny dancing cactus repeat what you said. This version includes record, repeat, shine, dance and sing functions. It can sing 120 songs in various languages. You can record what you say and repeat what you say. Turn on the power and press the button. It will distort your body and shine when singing.\n🌵 【Operación Flow-Swing Dancing Cactus】 1.Open the bottom battery cover and insert three AA batteries: ENCENDIDO; 2.Pestaña izquierda: presione prolongadamente para grabar, hasta 15 segundos, presione para reproducir el sonido; 3.Pestaña derecha: presione para reproducir La música se puede grabar después de que la canción esté en pausa. 4.Presione repetidamente para cambiar a las siguientes -120 canciones.";
            Name = "Small Red Car";
            ManufactureCompany = "TikTok Dancing Cactus Plus Toy";
            ManufactureYear = "2021";
            MinimumAge = 2;
            MaximumAge = 9;
            ChokingHazard = true;
            Weight = 0.7;
            WeightUnit = "lb";

            Chargable = true;
            CanMemic = true;
            CanSingASong = true;
        }

        public void TurnOnDancing()
        {
            Console.WriteLine($"{Name} is 'ON' now! ");
        }

        public void TurnOffDancing()
        { 
            Console.WriteLine($"{Name} is 'OFF' now! ");
        }
    }
}
