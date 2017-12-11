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
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarPatentes();
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            lblMensaje.Visible = true;
             
            if (ControladorVehiculos.removeVehiculo(txtPatente.Text))
            {
                
                lblMensaje.Text = "Se elimino el Vehiculo con la patente: " + txtPatente.Text;
                cargarPatentes();
            }
            else
            {
                lblMensaje.Text = "No existe el vehiculo con esa patente";
            }
        }

        private void cargarPatentes()
        {
            List<Vehiculo> _misVehiculos = ControladorVehiculos.listadoVehiculos();

            //ControladorVehiculos misVehiculos = (ControladorVehiculos)Session["MisVehiculos"];
            lstPatentes.Items.Clear();
            foreach (Vehiculo vehiculo in _misVehiculos)
            {
                lstPatentes.Items.Add(vehiculo.Patente);
            }
        }

        
    }
}