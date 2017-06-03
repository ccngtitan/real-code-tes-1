using System;
using System.IO;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class TestPage : System.Web.UI.Page
{
	private static readonly string did = "admint4123", dpw = "12345^Qa";
	private SqlConnection con = new SqlConnection("Server=tcp:t4bsdev.database.windows.net,1433;Initial Catalog=MBPDB;Persist Security Info=False;User ID=" + did + ";Password=" + dpw + ";MultipleActiveResultSets=True;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
	public string str = "";
	
   public TestPage()
    {
		
	}
	
	public void Button1_Click(object sender, EventArgs e){
		Label1.Text = "The selected date is " + Calendar1.SelectedDate.ToShortDateString();
	}
}
