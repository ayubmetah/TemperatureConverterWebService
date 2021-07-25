using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for Convert
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class Convert : System.Web.Services.WebService
{

    public Convert()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }


    [WebMethod]
    public string HelloWorld()
    {
        return "Hello World";
    }

    [WebMethod]
    public int MyDog()
    {
        int dog = 4;
        //MessageBox.Show("I have {{dog}} dogs", dog);
        return dog;
    }

    [WebMethod]
    public double FahrenheitToCelsius(double Fahrenheight)
    {
        return ((Fahrenheight - 32) * 5) / 9;

    }

    [WebMethod]
    public double CelsiusToFahrenheit(double Celsius)
    {
        return ((Celsius * 9) / 5) + 32;

    }
}
