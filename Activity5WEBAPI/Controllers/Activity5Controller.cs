using Activity5BL;
using Activity5DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Activity5WEBAPI.Controllers
{
    public class Activity5Controller : ApiController
    {
        [HttpGet]
        public HttpResponseMessage InsertIntoProduct(DTO newProObj)
        {
            try
            {
                if (newProObj != null)
                {
                    BL blObj = new BL();
                    int result = blObj.InsertIntoProduct(newProObj);
                    if (result == 1)
                    {
                        return Request.CreateResponse(HttpStatusCode.InternalServerError, "Data Inserted into Product Successfully");
                    }


                    else
                    {
                        return Request.CreateResponse(HttpStatusCode.OK, "Product not added");


                    }
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, "Check all input values for Product");
                }

            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);

            }

        }
    }
}
