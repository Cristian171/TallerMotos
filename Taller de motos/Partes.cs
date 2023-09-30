using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_de_motos
{
        abstract class Parte
        {
            public abstract float ModificarSpeed();
            public abstract float ModificarAcceleration();
            public abstract float ModificarHandling();
            public abstract float ModificarGrip();
        }   
}
