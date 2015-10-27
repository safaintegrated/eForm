using eForm.Data.SqlServer;
using eForm.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace eForm.WebApi.Controllers
{
    public class ApplicationController : ApiController
    {
        private readonly IApplicationService _svc;
        public ApplicationController()
        {
            _svc = new ApplicationService(new eFormSqlServerContext());
        }

        // GET api/product
        public IEnumerable<Data.Application> Get()
        {
            return _svc.FindAll().AsEnumerable();
        }
        public HttpResponseMessage Post(Data.Application o)
        {
            //if (ModelState.IsValid)
            {
                // this will set the ID for instance...
                string id = _svc.Create(o);

                /*
                * 1. The client should send a POST request to /user to create the resource.
                * 2. The server should then return a 201 CREATED response, with the URI of 
                * the resource in the Location header.
                * */

                var response = Request.CreateResponse(HttpStatusCode.Created, o);

                string uri = Url.Link("DefaultApi", new { id = id });
                response.Headers.Location = new Uri(uri);
                return response;
            }
            //else
            //{
            //    return Request.CreateResponse(HttpStatusCode.BadRequest);
            //}
        }

        // PUT api/product/5
        public HttpResponseMessage Put(Data.Application o)
        {
            if (ModelState.IsValid)
            {
                var result = _svc.Update(o);
                if (result == false)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                }
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        // DELETE api/product/5
        public HttpResponseMessage Delete(string id)
        {
            Data.Application o = _svc.GetById(id);

            if (o == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            try
            {
                _svc.Delete(id);
            }
            catch (Exception exc)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }

            return Request.CreateResponse(HttpStatusCode.OK, o);
        }
    }
}
