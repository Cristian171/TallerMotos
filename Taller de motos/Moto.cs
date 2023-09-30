using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_de_motos
{
    class Moto
    {
        public float Speed { get; private set; }
        public float Acceleration { get; private set; }
        public float Handling { get; private set; }
        public float Grip { get; private set; }
        private float valorInicial = 1.0f; // Valor inicial de todos los parámetros

        // Constructor de la clase Moto
        public Moto()
        {
            Speed = valorInicial;
            Acceleration = valorInicial;
            Handling = valorInicial;
            Grip = valorInicial;
        }

        // Método para personalizar la moto con una parte
        public void PersonalizarParte(Parte parte)
        {
            Speed = valorInicial + parte.ModificarSpeed();
            Acceleration = valorInicial + parte.ModificarAcceleration();
            Handling = valorInicial + parte.ModificarHandling();
            Grip = valorInicial + parte.ModificarGrip();
        }
    }

}


