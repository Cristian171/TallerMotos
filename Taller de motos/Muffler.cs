using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_de_motos
{
    class Muffler : Parte
    {
        public override float ModificarSpeed()
        {
            return 0.0f; // Muffler no modifica Speed
        }

        public override float ModificarAcceleration()
        {
            return 0.5f; // Modifica Acceleration en 0.5
        }

        public override float ModificarHandling()
        {
            return 0.0f; // Muffler no modifica Handling
        }

        public override float ModificarGrip()
        {
            return 0.0f; // Muffler no modifica Grip
        }
    }
}
