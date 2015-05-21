using Social.DictionaryService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace Social.Controllers
{
    [RoutePrefix("api")]
    public class DictionaryApiController : ApiController
    {
        
        private readonly DictServiceSoap _dictionaryService = null;


        public DictionaryApiController(DictServiceSoap dictionaryService)
        {
            this._dictionaryService = dictionaryService;
        }


        // GET /api/definition
        [Route("define/{word}")]
        public IEnumerable<Definition> Get(string word)
        {
            var definitions = _dictionaryService.Define(word);
            return definitions.Definitions.ToList();
        }


    }
}
