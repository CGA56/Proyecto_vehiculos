using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    public abstract class Vehiculo
    {
        #region Campos

        private string _patente;
        private Modelos _modelo;
        private double _motor;

        #endregion

        #region Propiedades

        public double Motor
        {
            get { return _motor; }
            set { _motor = value; }
        }


        public Modelos ModeloE
        {
            get { return _modelo; }
            set { _modelo = value; }
        }

        public string Patente
        {
            get { return _patente; }
            set { _patente = value; }
        }

        #endregion

        #region Constructores

        public Vehiculo()
        {
            Init();
            
        }

        public Vehiculo(string patente, Modelos modelo, double motor)
        {
            this._patente = patente;
            this._modelo = modelo;
            this._motor = motor;

        }

        #endregion

        #region Customers

        private void Init()
        {
            this._patente = string.Empty;
            this._modelo = Modelos.SELECCIONE;
            this._motor = 0.0;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Patente: " + this._patente);
            sb.AppendLine("Modelo: " + this._modelo); 
            sb.AppendLine("Motor: " + this._motor); 

            return sb.ToString();
        }

        

        #endregion

    }
}
