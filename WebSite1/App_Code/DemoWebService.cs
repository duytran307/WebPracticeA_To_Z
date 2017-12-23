using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for DemoWebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class DemoWebService : System.Web.Services.WebService
{

    public DemoWebService()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public int Add(int a, int b)
    {
        return a + b;
    }

    [WebMethod]
    public int Sub(int a, int b)
    {
        return a - b;
    }

    [WebMethod]
    public int Multiple(int a, int b)
    {
        return a * b;
    }
    [WebMethod]
    public int Divide(int a, int b)
    {
        return a / b;
    }

}
