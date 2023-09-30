using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_de_motos
{
    class Engine : Parte
    {
        public override float ModificarSpeed()
        {
            return 2.0f; // Modifica Speed en 2.0
        }

        public override float ModificarAcceleration()
        {
            return 1.0f; // Modifica Acceleration en 1.0
        }

        public override float ModificarHandling()
        {
            return 1.0f; // Modifica Handling en 1.0
        }

        public override float ModificarGrip()
        {
            return 0.0f; // Engine no modifica Grip
        }
    }
}
