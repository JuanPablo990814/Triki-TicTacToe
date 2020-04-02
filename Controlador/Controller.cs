using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class Controller
    {
        public string[,] matrix { get; set; } = new string[3, 3];
        public string jugador { get; set; }
        public bool ganar1 { get; set; }
        public bool ganar2 { get; set; }
        public string texto { get; set; }
        public bool matrixllena {get;set; }

        public string dificultad { get; set; }
        public bool gano { get; set; }

        public int tamaño { get; set; }
        /*
         {
         00 01 02
         10 11 12
         20 21 22
         }
        */
        public void reiniciar()
        {
            int num=0;
            for(int i =0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    if(matrix[i,j]=="x" || matrix[i, j] == "o")
                    {
                        tamaño++;
                        num++;
                    }
                }
            }

            if (num == 9)
            {
                matrixllena = true;
            }
        }

        public void validar()
        {
            jugador1();
            jugador2();
        }

        public void jugador1()
        {
            //TOP HORIZONTAL
            if (matrix[0, 0] == "x" && matrix[0, 1] == "x" && matrix[0, 2] == "x")
            {
                ganar1 = true;
            }
            //MID HORIZONTAL
            if (matrix[1, 0] == "x" && matrix[1, 1] == "x" && matrix[1, 2] == "x")
            {
                ganar1 = true;
            }
            //BOTTOM HORIZONTAL
            if (matrix[2, 0] == "x" && matrix[2, 1] == "x" && matrix[2, 2] == "x")
            {
                ganar1 = true;
            }

            //TOP VERTICAL
            if (matrix[0, 0] == "x" && matrix[1, 0] == "x" && matrix[2, 0] == "x")
            {
                ganar1 = true;
            }
            //MID VERTICAL
            if (matrix[0, 1] == "x" && matrix[1, 1] == "x" && matrix[2, 1] == "x")
            {
                ganar1 = true;
            }
            //BOTTOM VERTICAL
            if (matrix[0, 2] == "x" && matrix[1, 2] == "x" && matrix[2, 2] == "x")
            {
                ganar1 = true;
            }


            //ESQUINAS
            if (matrix[0, 0] == "x" && matrix[1, 1] == "x" && matrix[2, 2] == "x")
            {
                ganar1 = true;
            }
            //ESQUINAS 2
            if (matrix[2, 0] == "x" && matrix[1, 1] == "x" && matrix[0, 2] == "x")
            {
                ganar1 = true;
            }
        }

        public void jugador2()
        {
            //TOP HORIZONTAL
            if (matrix[0, 0] == "o" && matrix[0, 1] == "o" && matrix[0, 2] == "o")
            {
                ganar2 = true;
            }
            //MID HORIZONTAL
            if (matrix[1, 0] == "o" && matrix[1, 1] == "o" && matrix[1, 2] == "o")
            {
                ganar2 = true;
            }
            //BOTTOM HORIZONTAL
            if (matrix[2, 0] == "o" && matrix[2, 1] == "o" && matrix[2, 2] == "o")
            {
                ganar2 = true;
            }

            //TOP VERTICAL
            if (matrix[0, 0] == "o" && matrix[1, 0] == "o" && matrix[2, 0] == "o")
            {
                ganar2 = true;
            }
            //MID VERTICAL
            if (matrix[0, 1] == "o" && matrix[1, 1] == "o" && matrix[2, 1] == "o")
            {
                ganar2 = true;
            }
            //BOTTOM VERTICAL
            if (matrix[0, 2] == "o" && matrix[1, 2] == "o" && matrix[2, 2] == "o")
            {
                ganar2 = true;
            }


            //ESQUINAS
            if (matrix[0, 0] == "o" && matrix[1, 1] == "o" && matrix[2, 2] == "o")
            {
                ganar2 = true;
            }
            //ESQUINAS 2
            if (matrix[2, 0] == "o" && matrix[1, 1] == "o" && matrix[0, 2] == "o")
            {
                ganar2 = true;
            }
        }




    }
}
