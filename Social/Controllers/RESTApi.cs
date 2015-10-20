using Authentication;
using Newtonsoft.Json.Linq;
using Social.DictionaryService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using System.Web.Http.Results;


namespace Social.Controllers
{
    [Authorize]
    [RoutePrefix("api")]
    public class RESTApiController : ApiController
    {

        private readonly DictServiceSoap _dictionaryService = null;
        private readonly ApplicationUserManager _userManager = null;


        public RESTApiController() { }

        public RESTApiController(DictServiceSoap dictionaryService,ApplicationUserManager userManager )
        {
            this._dictionaryService = dictionaryService;
            this._userManager = userManager;
        }


        // GET /api/definition
        [AllowAnonymous]
        [Route("define/{word}")]
        public HttpResponseMessage Get(string word)
        {
            var definitions = _dictionaryService.Define(word);

            var json = from def in definitions.Definitions
                       select new 
                       {
                       Word = def.Word,
                       WordDefinition = def.WordDefinition
                       };


            return new HttpResponseMessage()
            {
                Content = new StringContent(JArray.FromObject(json).ToString(), Encoding.UTF8, "application/json")
            };
        }

        // GET /api/getallusers
        [Route("getallusers")]
        public HttpResponseMessage Get()
        {
            //ApplicationUser Needs to decorated with datacontract attribute
            //IEnumerable<ApplicationUser> list = _userManager.Users.ToList();
            List<ApplicationUser> list = _userManager.Users.ToList();

            var json = from lst in _userManager.Users.ToList()
                       select new {
                                    FirstName = lst.FirstName, 
                                    LastName = lst.LastName, 
                                    Email = lst.Email            
                       };


            return new HttpResponseMessage()
            {
                Content = new StringContent(JArray.FromObject(json).ToString(), Encoding.UTF8, "application/json")
            };
        }


    }
}
