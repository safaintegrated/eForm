using eForm.Data.SqlServer;
using eForm.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Profile;

namespace eForm.WebApi.Controllers
{
    public class ProfileInfoController : ApiController
    {
        private readonly IProfileInfoService _profileService;

        public ProfileInfoController()
        {
            _profileService = new ProfileInfoService(new eFormSqlServerContext());
        }

        // GET api/product
        public IEnumerable<Data.ProfileInfo> Get()
        {
            return _profileService.FindAll().AsEnumerable();
        }
        public HttpResponseMessage Post(Data.ProfileInfo o)
        {
            if (ModelState.IsValid)
            {
                // this will set the ID for instance...
                string id = _profileService.Create(o);

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
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        // PUT api/product/5
        public HttpResponseMessage Put( Data.ProfileInfo o)
        {
            if (ModelState.IsValid)
            {
                var result = _profileService.Update(o);
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
           Data. ProfileInfo o = _profileService.GetById(id);

            if (o == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            try
            {
                _profileService.Delete(id);
            }
            catch (Exception exc)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }

            return Request.CreateResponse(HttpStatusCode.OK, o);
        }
    
    }
}
