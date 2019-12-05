using System;
using System.Collections.Generic;
using System.Text;

namespace BolosGame
{
    class ClassBolos
    {
       public int[] pinosDerribados = new int[21];
       public int contador = 0;

        public void Tiro(int pinos)
        {
            // Guardando los el numero de pinos derribados por tiro
            pinosDerribados[contador] = pinos;
            contador++;
        }

        public int Puntaje()
        {
            int tFrame = 0;
            int puntaje = 0;

            for (int numframe = 0; numframe < 10; numframe++)
            {
                if (pinosDerribados[tFrame] == 10)
                {
                    // Calcula los 10 puntos del strike mas los proximos dos tiros
                    puntaje += 10 + pinosDerribados[tFrame + 1] + pinosDerribados[tFrame + 2];
                    tFrame += 1;
                    
                }
                else if (pinosDerribados[tFrame] + pinosDerribados[tFrame + 1] == 10)
                {
                    // Calcula los 10 puntos del spare mas el proximo tiro 
                    puntaje += 10 + pinosDerribados[tFrame + 2];
                    tFrame += 2;
                }
                else
                {
                    // Suma normal de los dos tiros en un frame
                    puntaje += pinosDerribados[tFrame] + pinosDerribados[tFrame + 1];
                    tFrame += 2;
                }

            }
            return puntaje;
        }

        public void JuegoNormal()
        {
            Tiro(1); Tiro(4);
            Tiro(4); Tiro(5);
            Tiro(6); Tiro(4);
            Tiro(5); Tiro(5);
            Tiro(10);
            Tiro(0); Tiro(1);
            Tiro(7); Tiro(3);
            Tiro(6); Tiro(4);
            Tiro(10);
            Tiro(2); Tiro(8); Tiro(6);

            // Puntaje de este ejemplos:  133

            Console.WriteLine("Puntaje total del juego:  " + Puntaje());

        }
    }
}
