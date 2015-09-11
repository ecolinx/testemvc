using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Net;
using System.Net.Http;

namespace TesteMVC.Controllers
{
	public class TesteController : ApiController
    {
		public HttpResponseMessage Get()
        {
			var response = new HttpResponseMessage ();
			var lista = new List<int> ();

			for (int i = 0; i < 50; i++) {
				lista.Add (i);
			}

			response = Request.CreateResponse (HttpStatusCode.OK, lista);

			return response;
        }
    }
}
