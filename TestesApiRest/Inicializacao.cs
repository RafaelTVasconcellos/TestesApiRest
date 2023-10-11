using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesApiRest
{
    public class Inicializacao
    {
        public static RestClient Client = new RestClient();
        public static RestRequest Request = new RestRequest();
        public static IRestResponse Response;
    }
}
