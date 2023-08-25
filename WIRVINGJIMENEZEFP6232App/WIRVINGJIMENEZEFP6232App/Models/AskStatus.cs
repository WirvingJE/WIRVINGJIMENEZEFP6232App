using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WIRVINGJIMENEZEFP6232App.Models
{
    public class AskStatus
    {
        public RestRequest Request { get; set; }
        public int AskStatusId { get; set; }
        public string AskStatus1 { get; set; } = null!;

        //funciones
        public async Task<List<AskStatus>> GetAllAskStatusAsync()
        {
            try
            {


             

                string RouteSufix = String.Format("AskStatus");

              
                string URL = Services.APIConnection.ProductionPrefixURL + RouteSufix;

                RestClient client = new RestClient(URL);

                Request = new RestRequest(URL, Method.Get);


                Request.AddHeader(Services.APIConnection.ApiKeyName, Services.APIConnection.ApiKeyValue);

             

                RestResponse response = await client.ExecuteAsync(Request);

            
                HttpStatusCode statusCode = response.StatusCode;

                if (statusCode == HttpStatusCode.OK)
                {
                    var list = JsonConvert.DeserializeObject<List<AskStatus>>(response.Content);
                    return list;
                }
                else
                {
                    return null;
                }


            }
            catch (Exception ex)
            {
                string message = ex.Message;

                throw;
            }
        }





    }
}
