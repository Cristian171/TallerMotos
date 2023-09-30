using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_de_motos
{
    class Chasis : Parte
    {
        public override float ModificarSpeed()
        {
            return 0.5f; // Modifica Speed en 0.5
        }

        public override float ModificarAcceleration()
        {
            return 0.5f; // Modifica Acceleration en 0.5
        }

        public override float ModificarHandling()
        {
            return 1.0f; // Modifica Handling en 1.0
        }

        public override float ModificarGrip()
        {
            return 1.0f; // Modifica Grip en 1.0
        }
    }
}
