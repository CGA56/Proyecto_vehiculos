using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public class Taxi:Vehiculo
    {
        #region Campos

        private string _codigoTaxi;
        private TipoTaxi _tipoTaxi;

        #endregion

        #region Propiedades

        public TipoTaxi TipoTaxiE
        {
            get { return _tipoTaxi; }
            set { _tipoTaxi = value; }
        }


        public string CodigoTaxi
        {
            get { return _codigoTaxi; }
            set { _codigoTaxi = value; }
        }

        #endregion

        #region Constructores

        public Taxi()
            : base()
        {
            Init();
        }

        public Taxi(TipoTaxi tipoTaxi, string patente, Modelos modelo, double potencia)
            : base(patente, modelo, potencia)
        {
            this._codigoTaxi = generarCodigo();
            this._tipoTaxi = tipoTaxi;
        }

        

        #endregion

        #region Customers

        private void Init()
        {
            this._codigoTaxi = string.Empty;
            this._tipoTaxi = TipoTaxi.SELECCIONE;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Vehículo: Taxi");
            sb.AppendFormat(base.ToString());
            sb.AppendLine("Código Taxi: " + this._codigoTaxi);
            sb.AppendLine("Tipo Taxi: " + this._tipoTaxi);

            return sb.ToString();
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
