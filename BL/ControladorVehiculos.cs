using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EL;

namespace BL
{
    public  static class ControladorVehiculos
    {

        private static List<Vehiculo> _listaVehiculos = new List<Vehiculo>();


        // CRUD y search

        public static bool addVehiculo(Vehiculo objVehiculo)
        {
            foreach (Vehiculo vehiculo in _listaVehiculos)
            {
                if(vehiculo.Patente.Equals(objVehiculo.Patente))
                {
                    return false;
                }
            }
            _listaVehiculos.Add(objVehiculo);
            return true;
        }

        public static bool removeVehiculo(string patente)
        {
            foreach (Vehiculo vehiculo in _listaVehiculos)
            {
                if(vehiculo.Patente.Equals(patente))
                {
                   
                  _listaVehiculos.Remove(vehiculo);
                    return true;
                }
            }
            return false;
        }

        public static Vehiculo buscarPorPatente(string patente)
        {
            foreach (Vehiculo vehiculo in _listaVehiculos)
            {
                if (vehiculo.Patente.Equals(patente))
                {
                    return vehiculo;
                }
            }
            return null;
        }


        public static bool updateVehiculo(Vehiculo objVehiculo)
        {
            foreach (Vehiculo vehiculo in _listaVehiculos)
            {
                if(vehiculo.Patente.Equals(objVehiculo.Patente))
                {
                    _listaVehiculos.Remove(vehiculo);
                    _listaVehiculos.Add(objVehiculo);
                    return false;
                }
            }
            return true;
        }

        public static List<Vehiculo> listadoVehiculos()
        {
            return _listaVehiculos;
        }

    }
}
