using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Clases_Derivadas;

namespace Entidades
{

    public class Calculos
    {    
        MamiferosARescatar listaMamiferos;
        public Calculos(MamiferosARescatar listaMamiferos)
        {
           this.listaMamiferos = listaMamiferos;
        }
        
        /// <summary>
        /// Calcula el total de delfines en la lista
        /// </summary>
        public int TotalDelfines
        {
            get
            {
                int contador = 0;

                foreach (Mamifero item in this.listaMamiferos.ListaMamiferos)
                {
                    if(item is Delfin)
                    {
                        contador++;
                    }
                }

                return contador;
            }
        }

        /// <summary>
        /// Calcula el total de leones en la lista
        /// </summary>
        public int TotalLeones
        {
            get
            {
                int contador = 0;

                foreach (Mamifero item in this.listaMamiferos.ListaMamiferos)
                {
                    if (item is Leon)
                    {
                        contador++;
                    }
                }

                return contador;
            }
        }

        /// <summary>
        /// Calcula el total de elefantes en la lista
        /// </summary>
        public int TotalElefantes
        {
            get
            {
                int contador = 0;

                foreach (Mamifero item in this.listaMamiferos.ListaMamiferos)
                {
                    if (item is Elefante)
                    {
                        contador++;
                    }
                }

                return contador;
            }
        }

        /// <summary>
        /// Calcula el total de hipopotamos en la lista
        /// </summary>
        public int TotalHipopotamos
        {
            get
            {
                int contador = 0;

                foreach (Mamifero item in this.listaMamiferos.ListaMamiferos)
                {
                    if (item is Hipopotamo)
                    {
                        contador++;
                    }
                }

                return contador;
            }
        }

        /// <summary>
        /// Calcula el porcentaje de mamiferos en argentina
        /// </summary>
        public int PorcentajeDeMamiferosEnArgentina
        {
            get
            {
                int porcentajeTotal = 0;
                int contador = 0;

                foreach (Mamifero item in this.listaMamiferos.ListaMamiferos)
                {
                    if (item.Ubicacion == EUbicacion.Argentina)
                    {
                        contador++;
                    }
                }

                if(this.listaMamiferos.ListaMamiferos.Count == 0)
                {
                    return porcentajeTotal;
                }

                porcentajeTotal = contador * 100 / this.listaMamiferos.ListaMamiferos.Count;

                return porcentajeTotal;
            }
        }

        /// <summary>
        /// Calcula el porcentaje de mamiferos en argentina
        /// </summary>
        public int PorcentajeDeMamiferosEnUruguay
        {
            get
            {
                int porcentajeTotal = 0;
                int contador = 0;

                foreach (Mamifero item in this.listaMamiferos.ListaMamiferos)
                {
                    if (item.Ubicacion == EUbicacion.Uruguay)
                    {
                        contador++;
                    }
                }

                if (this.listaMamiferos.ListaMamiferos.Count == 0)
                {
                    return porcentajeTotal;
                }

                porcentajeTotal = contador * 100 / this.listaMamiferos.ListaMamiferos.Count;

                return porcentajeTotal;
            }
        }

        /// <summary>
        /// Calcula el porcentaje de mamiferos de tamaño grande
        /// </summary>
        public int PorcentajeDeGrandes
        {
            get
            {
                int porcentajeTotal = 0;
                int contador = 0;

                foreach (Mamifero item in this.listaMamiferos.ListaMamiferos)
                {
                    if (item.Tamanio == ETamanio.Grande)
                    {
                        contador++;
                    }
                }

                if (this.listaMamiferos.ListaMamiferos.Count == 0)
                {
                    return porcentajeTotal;
                }

                porcentajeTotal = contador * 100 / this.listaMamiferos.ListaMamiferos.Count;

                return porcentajeTotal;
            }
        }

        /// <summary>
        /// Calcula el porcentaje de mamiferos de tamaño mediano
        /// </summary>
        public int PorcentajeDeMedianos
        {
            get
            {
                int porcentajeTotal = 0;
                int contador = 0;

                foreach (Mamifero item in this.listaMamiferos.ListaMamiferos)
                {
                    if (item.Tamanio == ETamanio.Mediano)
                    {
                        contador++;
                    }
                }

                if (this.listaMamiferos.ListaMamiferos.Count == 0)
                {
                    return porcentajeTotal;
                }

                porcentajeTotal = contador * 100 / this.listaMamiferos.ListaMamiferos.Count;

                return porcentajeTotal;
            }
        }

        /// <summary>
        /// Calcula el porcentaje de leones en Argentina
        /// </summary>
        public int PorcentajeLeonesEnArgentina
        {
            get
            {
                int porcentajeTotal = 0;
                int contador = 0;

                foreach (Mamifero item in this.listaMamiferos.ListaMamiferos)
                {
                    if (item.Ubicacion == EUbicacion.Argentina && item is Leon)
                    {
                        contador++;
                    }
                }

                if (this.listaMamiferos.ListaMamiferos.Count == 0)
                {
                    return porcentajeTotal;
                }

                porcentajeTotal = contador * 100 / this.listaMamiferos.ListaMamiferos.Count;

                return porcentajeTotal;
            }
        }


        /// <summary>
        /// Calcula el porcentaje de delfines en Argentina
        /// </summary>
        public int PorcentajeDelfinesEnArgentina
        {
            get
            {
                int porcentajeTotal = 0;
                int contador = 0;

                foreach (Mamifero item in this.listaMamiferos.ListaMamiferos)
                {
                    if (item.Ubicacion == EUbicacion.Argentina && item is Delfin)
                    {
                        contador++;
                    }
                }

                if (this.listaMamiferos.ListaMamiferos.Count == 0)
                {
                    return porcentajeTotal;
                }

                porcentajeTotal = contador * 100 / this.listaMamiferos.ListaMamiferos.Count;

                return porcentajeTotal;
            }
        }


        /// <summary>
        /// Calcula el porcentaje de elefantes en Argentina
        /// </summary>
        public int PorcentajeElefantesEnArgentina
        {
            get
            {
                int porcentajeTotal = 0;
                int contador = 0;

                foreach (Mamifero item in this.listaMamiferos.ListaMamiferos)
                {
                    if (item.Ubicacion == EUbicacion.Argentina && item is Elefante)
                    {
                        contador++;
                    }
                }

                if (this.listaMamiferos.ListaMamiferos.Count == 0)
                {
                    return porcentajeTotal;
                }

                porcentajeTotal = contador * 100 / this.listaMamiferos.ListaMamiferos.Count;

                return porcentajeTotal;
            }
        }


        /// <summary>
        /// Calcula el porcentaje de hipopotamos en Argentina
        /// </summary>
        public int PorcentajeHipopotamosEnArgentina
        {
            get
            {
                int porcentajeTotal = 0;
                int contador = 0;

                foreach (Mamifero item in this.listaMamiferos.ListaMamiferos)
                {
                    if (item.Ubicacion == EUbicacion.Argentina && item is Hipopotamo)
                    {
                        contador++;
                    }
                }

                if (this.listaMamiferos.ListaMamiferos.Count == 0)
                {
                    return porcentajeTotal;
                }

                porcentajeTotal = contador * 100 / this.listaMamiferos.ListaMamiferos.Count;

                return porcentajeTotal;
            }
        }


        /// <summary>
        /// Calcula el porcentaje de leones en Uruguay
        /// </summary>
        public int PorcentajeLeonesEnUruguay
        {
            get
            {
                int porcentajeTotal = 0;
                int contador = 0;

                foreach (Mamifero item in this.listaMamiferos.ListaMamiferos)
                {
                    if (item.Ubicacion == EUbicacion.Uruguay && item is Leon)
                    {
                        contador++;
                    }
                }

                if (this.listaMamiferos.ListaMamiferos.Count == 0)
                {
                    return porcentajeTotal;
                }

                porcentajeTotal = contador * 100 / this.listaMamiferos.ListaMamiferos.Count;

                return porcentajeTotal;
            }
        }

        /// <summary>
        /// Calcula el porcentaje de delfines en Uruguay
        /// </summary>
        public int PorcentajeDelfinesEnUruguay
        {
            get
            {
                int porcentajeTotal = 0;
                int contador = 0;

                foreach (Mamifero item in this.listaMamiferos.ListaMamiferos)
                {
                    if (item.Ubicacion == EUbicacion.Uruguay && item is Delfin)
                    {
                        contador++;
                    }
                }

                if (this.listaMamiferos.ListaMamiferos.Count == 0)
                {
                    return porcentajeTotal;
                }

                porcentajeTotal = contador * 100 / this.listaMamiferos.ListaMamiferos.Count;

                return porcentajeTotal;
            }
        }

        /// <summary>
        /// Calcula el porcentaje de hipopotamos en Uruguay
        /// </summary>
        public int PorcentajeHipopotamosEnUruguay
        {
            get
            {
                int porcentajeTotal = 0;
                int contador = 0;

                foreach (Mamifero item in this.listaMamiferos.ListaMamiferos)
                {
                    if (item.Ubicacion == EUbicacion.Uruguay && item is Hipopotamo)
                    {
                        contador++;
                    }
                }

                if (this.listaMamiferos.ListaMamiferos.Count == 0)
                {
                    return porcentajeTotal;
                }

                porcentajeTotal = contador * 100 / this.listaMamiferos.ListaMamiferos.Count;

                return porcentajeTotal;
            }
        }

        /// <summary>
        /// Calcula el porcentaje de elefantes en Uruguay
        /// </summary>
        public int PorcentajeElefantesEnUruguay
        {
            get
            {
                int porcentajeTotal = 0;
                int contador = 0;

                foreach (Mamifero item in this.listaMamiferos.ListaMamiferos)
                {
                    if (item.Ubicacion == EUbicacion.Uruguay && item is Elefante)
                    {
                        contador++;
                    }
                }

                if (this.listaMamiferos.ListaMamiferos.Count == 0)
                {
                    return porcentajeTotal;
                }

                porcentajeTotal = contador * 100 / this.listaMamiferos.ListaMamiferos.Count;

                return porcentajeTotal;
            }
        }

        /// <summary>
        /// Se sobreescribe el ToString con toda la informacion estadistica.
        /// </summary>
        public override string ToString()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendFormat($"Total de delfines: {this.TotalDelfines}\n");
            datos.AppendFormat($"Total de leones: {this.TotalLeones}\n");
            datos.AppendFormat($"Total de hipopotamos: {this.TotalHipopotamos}\n");
            datos.AppendFormat($"Total de elefantes: {this.TotalElefantes}\n");
            datos.AppendFormat($"Porcentaje de mamiferos en Argentina: %{this.PorcentajeDeMamiferosEnArgentina}\n");
            datos.AppendFormat($"Porcentaje de mamiferos en Uruguay: %{this.PorcentajeDeMamiferosEnUruguay}\n");
            datos.AppendFormat($"Porcentaje de mamiferos grandes: %{this.PorcentajeDeGrandes}\n");
            datos.AppendFormat($"Porcentaje de mamiferos medianos: %{this.PorcentajeDeMedianos}\n");
            datos.AppendFormat($"Porcentaje de delfines en Argentina: %{this.PorcentajeDelfinesEnArgentina}\n");
            datos.AppendFormat($"Porcentaje de leones en Argentina: %{this.PorcentajeLeonesEnArgentina}\n");
            datos.AppendFormat($"Porcentaje de elefantes en Argentina: %{this.PorcentajeElefantesEnArgentina}\n");
            datos.AppendFormat($"Porcentaje de hipopotamos en Argentina: %{this.PorcentajeHipopotamosEnArgentina}\n");
            datos.AppendFormat($"Porcentaje de delfines en Uruguay: %{this.PorcentajeDelfinesEnUruguay}\n");
            datos.AppendFormat($"Porcentaje de leones en Uruguay: %{this.PorcentajeLeonesEnUruguay}\n");
            datos.AppendFormat($"Porcentaje de elefantes en Uruguay: %{this.PorcentajeElefantesEnUruguay}\n");
            datos.AppendFormat($"Porcentaje de hipopotamos en Uruguay: %{this.PorcentajeHipopotamosEnUruguay}\n");


            return datos.ToString();
        }

    }
}
