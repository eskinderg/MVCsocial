using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Social.DictionaryService;

namespace Social.Controllers
{
    public class WizardController : Controller
    {


        DictServiceSoap _dictionaryService = null;
        public WizardController() { }

        public WizardController(DictServiceSoap dictionaryService)
        {
            this._dictionaryService = dictionaryService;

            
        }


        public ActionResult Index()
        {
            //string word = "Provoke";
            //string def = string.Empty;
            
            //def = _dictionaryService.Define(word).Definitions.First().WordDefinition;

            //Response.Write(def);
            return View();
        }
	}
}