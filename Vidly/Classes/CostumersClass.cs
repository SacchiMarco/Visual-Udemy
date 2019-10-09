using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Classes
{
    public class CostumersClass
    {
        public CostumersClass(string name, int id)
        {
            this.CostumersName = name;
            this.Id = id;

        }

        public int Id { get; set; }
        public string CostumersName { get; set; }   
    }
}