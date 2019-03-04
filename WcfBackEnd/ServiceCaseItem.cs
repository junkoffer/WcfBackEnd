using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfBackEnd
{
    public class ServiceCaseItem
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public string TennantID { get; set; }
    }
}