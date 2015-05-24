using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Social.Controllers
{
    public interface IHomeInjectable
    {
        string GetName();
    }

    public class HomeInjectable : IHomeInjectable
    {
        public string GetName()
        {
            return "My name is Eskinder";
        }

    }
}
