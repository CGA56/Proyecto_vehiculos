using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EL;
using BL;

namespace AplicacionWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarPatentes();
            mostrarDiv.Visible = false;
        }

        
        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            mostrarDiv.Visible = false;
            buscadorDiv.Visible = true;
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            
            Vehiculo objVehiculo = ControladorVehiculos.buscarPorPatente(txtPatente.Text);
            if (objVehiculo != null)
            {
                mostrarDiv.Visible = true;
                buscadorDiv.Visible = false;
                txtVehiculo.Text = objVehiculo.ToString();
            }
            else
            {
                lblMensaje.Visible = true;
                lblMensaje.Text = "No existe el vehiculo con esa patente";
            }
        }

        private void cargarPatentes()
        {
            
            lstPatentes.Items.Clear();
            foreach (Vehiculo vehiculo in ControladorVehiculos.listadoVehiculos())
            {
                lstPatentes.Items.Add(vehiculo.Patente);
            }
        }
    }
}