using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace MiPrimeraWeb
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cusCustom_ServerValidate(object sender, ServerValidateEventArgs e)
        {
            string password;
            password = txtPassword.Text;

            bool contiene = password.Any(char.IsDigit) && password.Any(char.IsLower) && password.Any(char.IsUpper);


            if (!contiene || e.Value.Length < 8)
            {
                e.IsValid = false;
            }
            else if(contiene && e.Value.Length >= 8)
            {
                e.IsValid = true;
            }


        }
    }
}