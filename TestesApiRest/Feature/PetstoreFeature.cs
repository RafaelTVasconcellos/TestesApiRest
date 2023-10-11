using Microsoft.VisualStudio.TestTools.UnitTesting;
using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesApiRest.Feature
{
    [TestClass]
    public class PetstoreFeature
    {
        [TestMethod]
        [TestCategory("01")]
        public void ValidarEndpointPetPUTComSucesso()
        {
            WriteLine("Dado que: Realizo a chamada ao endpoint 'https://petstore3.swagger.io/api/v3/pet' PUT ");
            WriteLine("E: Preencher os campos @id, @name, @category { @id, @name}, @photoUrls, @tags { @id, @name} e @status com valores válidos ");
            WriteLine("Quando: Executar o endpoint ");
            WriteLine("Então: Retornará o Status Code '200' e os dados serão atualizados com sucesso ");

            APIs.APIs.PetStoreAPIs.ValidarEndpointPetPUTComSucesso();
        }

        [TestMethod]
        [TestCategory("07")]
        public void ValidarEndpointPetPetIdGetComSucesso()
        {
            WriteLine("Dado que: Realizo a chamada ao endpoint 'https://petstore3.swagger.io/api/v3/pet/{petId}' GET");
            WriteLine("E: Preencher o campo @id com valor válido ");
            WriteLine("Quando: Executar o endpoint ");
            WriteLine("Então: Retornará o Status Code '200' e o @name com sucesso ");

            APIs.APIs.PetStoreAPIs.ValidarEndpointPetPetIdGetComSucesso();
        }
    }
}
