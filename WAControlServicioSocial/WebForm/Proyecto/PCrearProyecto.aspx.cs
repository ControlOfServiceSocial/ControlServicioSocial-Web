using SWLNControlServicioSocial;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForm_Proyecto_PCrearProyecto : System.Web.UI.Page
{
    CProyecto cProyecto = new CProyecto();
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    private void crearProyecto()
    {
        if (img.HasFile)
        {
            // Verifica si el archivo es una imagen
            string extension = Path.GetExtension(img.FileName);
            if (extension != "")
            {
                // Convierte el archivo a un array de bytes
                byte[] imagenBytes = img.FileBytes;
                try
                {
                    cProyecto.Insertar_CProyecto_I_CC(txtnombre.Text, desc.Text, ubicacion.Text, byte.Parse(estado.SelectedValue), imagenBytes, byte.Parse(horas.Text), inicio.SelectedDate, fin.SelectedDate, creacion.SelectedDate);

                }
                catch (Exception)
                {

                    throw;
                }
            }
            else
            {
                Response.Write("El archivo no es una imagen.");
            }
        }
        else
        {
            Response.Write("Por favor, selecciona un archivo para subir.");
        }
 
    }



    protected void btnSend_Click(object sender, EventArgs e)
    {
        crearProyecto();
    }
}