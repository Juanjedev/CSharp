using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace WebConBBDD
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            DataView dato = (DataView)SqlDataSource1.Select(DataSourceSelectArguments.Empty);

            if(dato.Count == 0)
            {
                labelError.Text = "El usuario no existe en la Base de datos";
            }

        }
    }
}