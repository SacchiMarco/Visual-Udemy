using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Classes;

namespace Vidly.Handler
{
    public class CostumersHandler
    {
        public CostumersHandler()
        {
            this.CostumersList = new List<CostumersClass>();
        }

        public List<CostumersClass> CostumersList;
    }
}