using ASP_NETRest.Hypermedia;
using ASP_NETRest.Hypermedia.Abstract;
using ASP_NETRest.Model.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Sockets;

namespace ASP_NETRest.Data.VO
{
    public class PersonVO : ISupportHyperMedia
    {
        public long Id { get; set; }

        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        
        public string Address { get; set; }
        
        public string Gender { get; set; }

        public List<HyperMediaLink> Links { get ; set ; } = new List<HyperMediaLink>();
    }
}
