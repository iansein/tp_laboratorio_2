using System;

namespace Entidades
{
    public class Operando
    {
        private double numero;

        #region Constructores

        /// <summary>
        /// Inicializa el numero en 0.
        /// </summary>
        public Operando() : this(0)
        {
        }

        /// <summary>
        /// Inicializa el numero con el valor pasado por parametro.
        /// </summary>
        /// <param name="numero"> Valor para inicializar el numero </param> 
        public Operando(double numero)
        {
            this.numero = numero;
        }

        /// <summary>
        /// Convierte el numero en formato de string a un formato double.
        /// </summary>
        /// <param name="strNumero"> Numero con formato string a convertir y setear. </param> 
        public Operando(string strNumero)
        {
            this.Numero = strNumero;
        }

        #endregion

        #region Propiedades

        
        /// <summary>
        /// Valida el numero y lo setea.
        /// </summary>
        public string Numero
        {
            set
            {
                this.numero = ValidarOperando(value);
            }
        }

        #endregion

        #region Validacion

        /// <summary>
        /// Intenta comprobar si lo recibido por parametro es numerico.
        /// </summary>
        /// <param name="numero"> String que va a ser convertido en double. </param>
        /// <returns> El numero en formato double si es correcto, sino 0 </returns>
        private double ValidarOperando(string numero)
        {
            double auxNumero;

            if(!double.TryParse(numero, out auxNumero))
            {
                auxNumero = 0;
            }

            return auxNumero;
        }

        /// <summary>
        /// Chequea que el string no contenga ni '1' ni '0'.
        /// </summary>
        /// <param name="binario"> String a validar. </param>
        /// <returns> True si el string esta en formato binario o False si no.</returns>
        private bool EsBinario(string binario)
        {
            for (int i = 0; i < binario.Length; i++)
            {
                if(binario[i] != '1' && binario[i] != '0')
                {
                    return false;
                }
               
            }

            return true;
        }

        #endregion

        #region Convertidores

        /// <summary>
        /// Convierte el binario con formato string en un numero decimal.
        /// </summary>
        /// <param name="binario"> String a ser convertido en decimal</param>
        /// <returns> El decimal con formato string si es correcto o "Valor invalido" si no. </returns>
        public string BinarioDecimal(string binario)
        {
            char[] arrayBinario = binario.ToCharArray();
            
            Array.Reverse(arrayBinario);

            int decimalTotal = 0;
            
            if(EsBinario(binario))
            {
                for (int i = 0; i < arrayBinario.Length; i++)
                {
                    if (arrayBinario[i] == '1')
                    {
                        decimalTotal += (int)Math.Pow(2, i);
                    }

                }

                return decimalTotal.ToString();
            }

            return "Valor invalido\n";
        }

        /// <summary>
        /// Convierte un numero decimal a un numero binario en formato string
        /// </summary>
        /// <param name="numero"> Numero a convertir a formato binario </param>
        /// <returns> El numero binario en formato de string </returns>
        public string DecimalBinario(double numero)
        {
            string strBinario = string.Empty;

            if(numero < 0)
            {
                strBinario = "-1";
                return strBinario;
            }

            if (numero == 0)
            {
                strBinario = "0";
            }
            else
            {
                while (numero > 0)
                {
                    strBinario = (int)numero % 2 + strBinario;
                    numero = (int)numero / 2;
                }

                return strBinario;
            }

            return strBinario;
        }

        /// <summary>
        /// Convierte un numero en formato string a un numero binario en formato de string
        /// </summary>
        /// <param name="numero"> Numero en formato de string a ser convertido </param>
        /// <returns> Numero Binario en formato de string si es correcto o "Valor invalido" si no </returns>
        public string DecimalBinario(string numero)
        {
            double auxNumero;
            string binario;

            if(Double.TryParse(numero, out auxNumero))
            {
                binario = DecimalBinario(auxNumero);

                if(binario != "-1")
                {
                    return binario;
                }

            }

            return "Valor invalido";
            
            
        }

        #endregion

        #region Operadores

        /// <summary>
        /// Hace una suma entre 2 numeros.
        /// </summary>
        /// <param name="num1">Primer numero para sumar. </param>
        /// <param name="num2">Segundo numero para sumar. </param>
        /// <returns> La suma de los 2 numeros. </returns>
        public static double operator +(Operando num1, Operando num2)
        {
            return num1.numero + num2.numero;
        }

        /// <summary>
        /// Hace una resta entre 2 numeros.
        /// </summary>
        /// <param name="num1">Primer numero para restar.</param>
        /// <param name="num2">Segundo numero para restar.</param>
        /// <returns> La resta de los 2 numeros. </returns>
        public static double operator -(Operando num1, Operando num2)
        {
            return num1.numero - num2.numero;
        }

        /// <summary>
        /// Hace una multiplicacion entre 2 numeros.
        /// </summary>
        /// <param name="num1">Primer numero para multiplicar.</param>
        /// <param name="num2">Segundo numero para multiplicar.</param>
        /// <returns> La multiplicacion de los 2 numeros. </returns>
        public static double operator *(Operando num1, Operando num2)
        {
            return num1.numero * num2.numero;
        }

        /// <summary>
        /// Hace una division entre 2 numeros.
        /// </summary>
        /// <param name="num1"> Primer numero para dividir. </param>
        /// <param name="num2"> Segundo numero para dividir.</param>
        /// <returns> La division de los 2 numeros, pero si el segundo numero es 0 retorna el minimo valor de un double</returns>
        public static double operator /(Operando num1, Operando num2)
        {
            if (num2.numero != 0)
            {
                return num1.numero / num2.numero;
            }

            return Double.MinValue;
        }

        #endregion

    }
}
