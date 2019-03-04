using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfBackEnd
{
    public class ServiceCase
    {
        public int Id { get; set; }
        public int CaseNr { get; set; }
        public DateTime Created { get; set; }
        public string Source { get; set; }
        public ICollection<ServiceCaseItem> ServiceCaseItems { get; set; }
    }
}