using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases
{
    public class Game
    {
        protected int number;
        protected int intentos;

        public Game()
        {
            this.number = Convert.ToInt32(new Random().Next(1, 100)); // El campo number adiquiere un valor aleatorio entre 1 y 100
            this.intentos = 0; //garantiza conocer el valor inicial de intentos
        }

        public int GetIntentos()
        {
            return this.intentos;
        }
    }

    public class Adivinante: Game // Humano adivina numero a Computadora
    {
        public int Respuesta(int unNumero) // Recibe como parametro un numero y lo compara con el suyo. 
                                           //1: El numero es mas grande al que debe adivinarse. 0: Son iguales. -1: El numero es menor al que debe adivinarse
        {
            this.intentos++;
            if (unNumero > this.number)
            {
                return 1;
            } else if (unNumero == this.number)
            {
                return 0;
            } else
            {
                return -1;
            }
                
        }
    }

    public class Adivinador: Game // Computadora adivina numero a Humano
    {
        private int limInferior, limSuperior; // limita el rango de busqueda del numero a adivinar

        public Adivinador()
        {
            limInferior = 1;
            limSuperior = 100;
        }

        protected void piensaNumero()
        {
            this.number = (limInferior + limSuperior) / 2; //Busqueda Binaria
        }

        public int Pregunta(int unaRespuesta) // desplaza el rango de busqueda y piensa un nuevo numero basado en la respuesta recibida. 
                                              // 1: el numero es menor. -1: el numero es mayor
        {
            switch (unaRespuesta)
            {
                case 1:
                    this.intentos++;
                    limSuperior = this.number;
                    piensaNumero();
                    break;
                case -1:
                    this.intentos++;
                    limInferior = this.number;
                    piensaNumero();
                    break;
            }

            return this.number;
        }
    }
}
