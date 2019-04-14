using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MVCdotNetCRUDapp.Controllers
{
    public class HelloWorldController : Controller
    {
        //GET: /HelloWorld/
        public string Index(string name, int id = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {id}");
        }
        //GET: /HelloWorld/Welcome
        public string Welcome(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }
    }
}