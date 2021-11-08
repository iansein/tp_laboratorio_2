using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        #region Operar

        /// <summary>
        /// Hace una operacion dependiendo que operador se le haya pasado por parametro.
        /// </summary>
        /// <param name="num1"> Primer numero para la operacion </param>
        /// <param name="num2"> Segundo numero para la operacion </param>
        /// <param name="operador"> Operador para la operacion </param>
        /// <returns> Resultado de la operacion </returns>
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            double resultado = 0;

            operador = ValidarOperador(operador);

            switch(operador)
            {
                case '+':
                    resultado = num1 + num2;
                    break;

                case '-':
                    resultado = num1 - num2;
                    break;

                case '/':
                    resultado = num1 / num2;
                    break;

                case '*':
                    resultado = num1 * num2;
                    break;

            }

            return resultado;

        }

        #endregion

        #region Validar Operador

        /// <summary>
        /// Valida el operador pasado por parametro.
        /// </summary>
        /// <param name="operador"> El operador a validar </param>
        /// <returns> El operador correspondiente, y si el operador pasado por parametro no es ninguno de los pedidos retorna '+' </returns>
        private static char ValidarOperador(char operador)
        {   
            if(operador == '+' || operador == '-' || operador == '/' || operador == '*')
            {
                return operador;
            }

            return '+';            
        }

        #endregion
        
    }
}
