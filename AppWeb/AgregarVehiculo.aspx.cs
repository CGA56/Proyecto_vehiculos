using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EL;
using BL;
using System.Collections;

namespace AppWeb
{
    public partial class AgregarVehiculo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnColectivo_Click(object sender, EventArgs e)
        {
            pnlBus.Visible = true;
            cargarModeloColectivo();
            cargarRecorrido();
            EleccionDiv.Visible = false;
        }

        protected void btnTaxi_Click(object sender, EventArgs e)
        {
            pnlTaxi.Visible = true;
            cargarModeloTaxi();
            cargarTipoTaxi();
            EleccionDiv.Visible = false;
        }

        protected void btnCrearColectivo_Click(object sender, EventArgs e)
        {
            lblMensaje.Visible = true;
            
            try
            {
                if (txtPatenteColectivo.Text.Equals("") || txtMotorColectivo.Text.Equals("") || ddlModeloColectivo.SelectedIndex == 0 || ddlRecorrido.SelectedIndex == 0 )
                {
                    throw new Exception("Ingrese todos los datos del vehiculo");
                }
                string patente = txtPatenteColectivo.Text;
                Modelos modelo = (Modelos)Enum.Parse(typeof(Modelos), ddlModeloColectivo.SelectedValue);
                double motor = double.Parse(txtMotorColectivo.Text);
                Recorridos recorrido = (Recorridos)Enum.Parse(typeof(Recorridos), ddlRecorrido.SelectedValue);
                Colectivo objColectivo = new Colectivo(recorrido, patente, modelo, motor);
          
                if (ControladorVehiculos.addVehiculo(objColectivo))
                {
                    lblMensaje.Text = "Se agrego el colectivo";
                    limpiarCamposColectivo();
                }
                else
                {
                    lblMensaje.Text = "Ya existe un vehiculo con esa patente";
                }


            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error: " + ex.Message;
            }


        }

        protected void btnCancelarColectivo_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarVehiculo.aspx");
        }

        protected void btnCrearTaxi_Click(object sender, EventArgs e)
        {
            lblMensaje.Visible = true;
            
            try
            {
                if (txtMotorTaxi.Text.Equals("") || txtMotorTaxi.Text.Equals("") || ddlModeloTaxi.SelectedIndex == 0 || ddlTipoTaxi.SelectedIndex == 0)
                {
                    throw new Exception("Ingrese todos los datos del vehiculo");
                }
                string patente = txtPatenteTaxi.Text;
                Modelos modelo = (Modelos)Enum.Parse(typeof(Modelos), ddlModeloTaxi.SelectedValue);
                double motor = double.Parse(txtMotorTaxi.Text);
                TipoTaxi tipoTaxi = (TipoTaxi)Enum.Parse(typeof(TipoTaxi), ddlTipoTaxi.SelectedValue);
                Taxi objTaxi = new Taxi(tipoTaxi, patente, modelo, motor);
                if (ControladorVehiculos.addVehiculo(objTaxi))
                {
                    lblMensaje.Text = "Se agrego el Taxi";
                    limpiarCamposTaxi();
                }
                else
                {
                    lblMensaje.Text = "Ya existe un vehiculo con esa patente";
                }



            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error: " + ex.Message;
            }
        }

        protected void btnCancelarTaxi_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgregarVehiculo.aspx");
        }

        

        private void cargarRecorrido()
        {
            ddlRecorrido.Items.Clear();
            ddlRecorrido.DataSource = Enum.GetValues(typeof(Recorridos));
            DataBind();
            ddlRecorrido.SelectedIndex = 0;
        }


        private void cargarModeloColectivo()
        {
            ddlModeloColectivo.Items.Clear();
            ddlModeloColectivo.DataSource = Enum.GetValues(typeof(Modelos));
            ddlModeloColectivo.DataBind();
            ddlModeloColectivo.SelectedIndex = 0;

        }

        private void cargarModeloTaxi()
        {
            ddlModeloTaxi.Items.Clear();
            ddlModeloTaxi.DataSource = Enum.GetValues(typeof(Modelos));
            ddlModeloTaxi.DataBind();
            ddlModeloTaxi.SelectedIndex = 0;

        }

        
        private void cargarTipoTaxi()
        {
            ddlTipoTaxi.Items.Clear();
            ddlTipoTaxi.DataSource = Enum.GetValues(typeof(TipoTaxi));
            DataBind();
            ddlTipoTaxi.SelectedIndex = 0;
        }

        private void limpiarCamposColectivo()
        {
            txtMotorColectivo.Text = "";
            txtPatenteColectivo.Text = "";
            ddlRecorrido.SelectedIndex = 0;
            ddlModeloColectivo.SelectedIndex = 0;
        }

        private void limpiarCamposTaxi()
        {
            txtMotorTaxi.Text = "";
            txtPatenteTaxi.Text = "";
            ddlModeloTaxi.SelectedIndex = 0;
            ddlTipoTaxi.SelectedIndex = 0;

        }

        
    }
}