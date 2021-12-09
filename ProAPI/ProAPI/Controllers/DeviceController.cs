using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.OData;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProAPI.Data;
using ProAPI.Models;
using System.Net.Http;

namespace ProAPI.Controllers
{
    [ApiController]
    [Microsoft.AspNetCore.Mvc.Route("[controller]")]

    public class DeviceController : ControllerBase
    {

        private List<Device> listOfDevices = new List<Device>();

        [EnableQuery]
        [Microsoft.AspNetCore.Mvc.HttpGet]
        public IQueryable<Device> Get()
        {
            using ( var context = new DeviceStoreContext())
            {
                //return context.Devices.ToList();
            }
            return listOfDevices.AsQueryable();
        }

        [Microsoft.AspNetCore.Mvc.HttpDelete]
        public HttpRequestMessage Delete([FromUri]string key)
        {
            HttpRequestMessage response = new HttpRequestMessage();
            using (var context = new DeviceStoreContext())
            {
                try
                {

                    response.CreateResponse(System.Net.HttpStatusCode.OK);
                    listOfDevices.Remove(listOfDevices.Where(element => element.Id == key).FirstOrDefault());
                    return response;
                }
                catch (Exception ex)
                {
                    response.CreateResponse(System.Net.HttpStatusCode.BadRequest);
                    return response;
                }


            }
        }

        [Microsoft.AspNetCore.Mvc.HttpPost]
        public async Task<HttpRequestMessage> PostAsync()
        {
            HttpRequestMessage response = new HttpRequestMessage();
            try
                {
                using (var reader = new StreamReader(Request.Body))
                {
                    var body = await reader.ReadToEndAsync();
                    List<Models.Device> devices = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Models.Device>>(body);
                    this.listOfDevices.AddRange(devices);
                    response.CreateResponse(System.Net.HttpStatusCode.OK);
                }

                return response;
                }
                catch (Exception ex)
                {
                response.CreateResponse(System.Net.HttpStatusCode.BadRequest);
                return response;
                }


            
        }
    }
}
