using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;

namespace TestesApiRest.APIs
{
    public class PetStoreAPIs : Inicializacao
    {
        public void ValidarEndpointPetPUTComSucesso()
        {
            int id = 1;
            string name = "Mineiro";
            int idCategory = 1;
            string nameCategory = "Dogs";
            string photoUrlsString = "string";
            int idTags = 0;
            string nameTags = "string";
            string status = "available";

            object category = new
            {
                idCategory,
                nameCategory
            };
            object[] photoUrls =
            {
                photoUrlsString
            };

            object[] tags =
            { new
                {
                    idTags,
                    nameTags
                }
            };

            Request = new RestRequest("https://petstore3.swagger.io/api/v3/pet", Method.PUT);
            Request.AddJsonBody(new
            {
                id,
                name,
                category,
                photoUrls,
                tags,
                status
            });
            Response = Client.Execute(Request);

            var code = (int)Response.StatusCode;
            Assert.IsTrue(code == 200, "Status code diferente do esperado!");
            Response.StatusCode.ToString().Contains("OK");
            Response.Content.Contains("name:doggie");
        }

        public void ValidarEndpointPetPetIdGetComSucesso(int petId)
        {
            Request = new RestRequest($"https://petstore3.swagger.io/api/v3/pet/{petId}");
            Response = Client.Execute(Request);

            var code = (int)Response.StatusCode;
            Assert.IsTrue(code == 200, "Status code conforme esperado!");
            Response.StatusCode.ToString().Contains("OK");
            Response.Content.Contains("Mineiro");
        }

        //public void ValidarEndpointPetPetIdGetComSucesso()
        //{
        //    Request = new RestRequest($"https://petstore3.swagger.io/api/v3/store/inventory");
        //    Response = Client.Execute(Request);

        //    var code = (int)Response.StatusCode;
        //    Assert.IsTrue(code == 200, "Status code conforme esperado!");
        //    Response.StatusCode.ToString().Contains("OK");
        //    Response.Content.Contains("approved");
        //}

    }
}
