using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class Colectivo :Vehiculo
    {
        #region Campos
        private Recorridos _Recorrido;
        private string _CodigoColectivo;
        #endregion

        #region Propiedades
        public string CodigoColectivo
        {
            get { return _CodigoColectivo; }
            set { _CodigoColectivo = value; }
        }

        public Recorridos Recorrido
        {
            get { return _Recorrido; }
            set { _Recorrido = value; }
        }
        #endregion

        #region constructores

        public Colectivo(Recorridos recorridos, string patente, Modelos modelo, double potencia)
            : base(patente, modelo, potencia)
        {
            this._CodigoColectivo = generarCodigo();
            this.Recorrido = recorridos;
        }

        public Colectivo()
            : base()
        {
            Init();
        }


        #endregion

        #region Custumers
        private void Init()
        {
            this._CodigoColectivo = string.Empty;
            this._Recorrido = Recorridos.SELECCIONE;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine(base.ToString());
            builder.AppendLine("Recorrido : "+this._Recorrido);
            builder.AppendLine("Codigo    : " + this._CodigoColectivo);
            return builder.ToString();
        }

        private string generarCodigo()
        {
            Random objRandom = new Random();
            string codigo = generadorDeLetrasMayusculas(2) + objRandom.Next(10, 1000);
            return codigo;
        }

        /// <summary>
        /// Método que recibe una cantidad int para generar un string con letras aleatorias en mayúscula 
        /// </summary>
        /// <param name="cantidad">int de cantidad a generar</param>
        /// <returns>un valor string</returns>
        private static string generadorDeLetrasMayusculas(int cantidad)
        {
            System.Threading.Thread.Sleep(10);
            Random objRandom = new Random();
            string letrasAzar = string.Empty;
            for (int i = 0; i < cantidad; i++)
            {
                char letra = (char)objRandom.Next(65, 91);
                letrasAzar += letra;
            }

            return letrasAzar;
        }

        #endregion

    }
}
