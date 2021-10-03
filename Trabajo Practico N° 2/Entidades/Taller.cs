﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// No podrá tener clases heredadas.
    /// </summary>
    public sealed class Taller
    {
        #region Atributos

        private List<Vehiculo> vehiculos;
        private int espacioDisponible;

        #endregion

        #region Enumeradores

        /// <summary>
        /// Enumerador del tipo de vehiculo.
        /// </summary>
        public enum ETipo
        {
            Ciclomotor, 
            Sedan, 
            SUV, 
            Todos
        }

        #endregion

        #region "Constructores"

        /// <summary>
        /// Crea la instancia Taller e inicializa al objeto por defecto una lista de vehiculos.
        /// </summary>
        private Taller()
        {
            this.vehiculos = new List<Vehiculo>();
        }

        /// <summary>
        /// Crea la instancia Taller e inicializa al objeto con los datos correspondientes
        /// </summary>
        /// <param name="espacioDisponible"> Espacio disponible del taller que va a ser asignado. </param>
        public Taller(int espacioDisponible) : this()
        {
            this.espacioDisponible = espacioDisponible;
        }
        #endregion

        #region "Sobrecargas"

        /// <summary>
        /// Muestro el estacionamiento y TODOS los vehículos
        /// </summary>
        /// <returns> Toda la informacion de los vehiculos y del taller en formato de string. </returns>
        public override string ToString()
        {
            return Listar(this, ETipo.Todos);
        }

        #endregion

        #region "Métodos"

        /// <summary>
        /// Expone los datos del elemento y su lista (incluidas sus herencias)
        /// SOLO del tipo requerido
        /// </summary>
        /// <param name="taller">Elemento a exponer</param>
        /// <param name="ETipo">Tipos de ítems de la lista a mostrar</param>
        /// <returns> Toda la informacion del taller y de los vehiculos en formato string </returns>
        public string Listar(Taller t, ETipo tipo)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Tenemos {0} lugares ocupados de un total de {1} disponibles", t.vehiculos.Count, t.espacioDisponible);
            sb.AppendLine("");
            foreach (Vehiculo v in t.vehiculos)
            {
                switch (tipo)
                {
                    case ETipo.Ciclomotor:
                        if(v is Ciclomotor)
                        {
                            sb.AppendLine(v.Mostrar());
                        }
                        break;

                    case ETipo.Sedan:
                        if(v is Sedan)
                        {
                            sb.AppendLine(v.Mostrar());
                        }
                        break;

                    case ETipo.SUV:
                        if(v is Suv)
                        {
                            sb.AppendLine(v.Mostrar());
                        }                       
                        break;

                    default:
                        sb.AppendLine(v.Mostrar());
                        break;
                }
            }

            return sb.ToString();
        }
        #endregion

        #region "Operadores"
        /// <summary>
        /// Agregará un elemento a la lista
        /// </summary>
        /// <param name="taller">Objeto donde se agregará el elemento</param>
        /// <param name="vehiculo">Objeto a agregar</param>
        /// <returns> El taller como estaba, o el taller con el vehiculo agregado</returns>
        public static Taller operator +(Taller t, Vehiculo vehiculo)
        {
            if (t.vehiculos.Count < t.espacioDisponible)
            {
                foreach (Vehiculo v in t.vehiculos)
                {                    
                    if (v == vehiculo)
                    {
                        return t;
                    }
                }

                t.vehiculos.Add(vehiculo);
            }
            return t;
        }
        /// <summary>
        /// Quitará un elemento de la lista
        /// </summary>
        /// <param name="taller">Objeto donde se quitará el elemento</param>
        /// <param name="vehiculo">Objeto a quitar</param>
        /// <returns>El taller como estaba, o el taller sin el vehiulo que se removio (si existia)</returns>
        public static Taller operator -(Taller t, Vehiculo vehiculo)
        {
            foreach (Vehiculo v in t.vehiculos)
            {
                if (v == vehiculo)
                {
                    t.vehiculos.Remove(vehiculo);
                    return t;
                }
            }

            return t;
        }
        #endregion
    }
}
