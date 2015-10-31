using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Brello.Models
{
    public interface ICar
    {
        string Honk();
    }

    public  class Car
    {
        //In oreder for Mock to change behavoir, Method must be virtual
        public virtual string Horn()
        {
            ReadyEngines();
            return "Honk!";
        }

        // Even counting method calls, be virtual
        public virtual void ReadyEngines()
        {
            
        }
    }
}