using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cinema
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string Cinema = ConfigurationManager.ConnectionStrings["CinemaDB"].ConnectionString.ToString();
            SqlConnection conn = new SqlConnection(Cinema);

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = "Insert into Sale(Nome, Cognome, SalaSud, SalaNord, SalaEst, Ridotto)";

                command.Parameters.AddWithValue("Nome", Nome.Text);
                command.Parameters.AddWithValue("Cognome", Cognome.Text);
                command.Parameters.AddWithValue("SalaSud", Sud.Value);
                command.Parameters.AddWithValue("SalaNord", Nord.Value);
                command.Parameters.AddWithValue("SalaEst", Est.Value);

            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cinema
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string Cinema = ConfigurationManager.ConnectionStrings["CinemaDB"].ConnectionString.ToString();
            SqlConnection conn = new SqlConnection(Cinema);

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = "Insert into Sale(Nome, Cognome, SalaSud, SalaNord, SalaEst, Ridotto)";

                command.Parameters.AddWithValue("Nome", Nome.Text);
                command.Parameters.AddWithValue("Cognome", Cognome.Text);
                command.Parameters.AddWithValue("SalaSud", Sud.Value);
                command.Parameters.AddWithValue("SalaNord", Nord.Value);
                command.Parameters.AddWithValue("SalaEst", Est.Value);

            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cinema
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string Cinema = ConfigurationManager.ConnectionStrings["CinemaDB"].ConnectionString.ToString();
            SqlConnection conn = new SqlConnection(Cinema);

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = "Insert into Sale(Nome, Cognome, SalaSud, SalaNord, SalaEst, Ridotto)";

                command.Parameters.AddWithValue("Nome", Nome.Text);
                command.Parameters.AddWithValue("Cognome", Cognome.Text);
                command.Parameters.AddWithValue("SalaSud", Sud.Value);
                command.Parameters.AddWithValue("SalaNord", Nord.Value);
                command.Parameters.AddWithValue("SalaEst", Est.Value);
                command.Parameters.AddWithValue("Ridotto", CheckBox1.Checked);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}
