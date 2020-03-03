using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Net.Http;

namespace KissList.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KissListController : ControllerBase
    {
        private JsonDocument jDoc;
        public async Task<> GetKissList()
        {
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(""))
                {
                    var stringResponse = await response.Content.ReadAsStringAsync();
                    jDoc = JsonDocument.Parse(stringResponse);
                    var name = jDoc.RootElement.GetProperty();
                    var id = jDoc.RootElement.GetProperty();
                    .Name = name.ToString();
                    .ID = id.ToString();

                }
            }
            return ;
        }
    }
}