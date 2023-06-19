using ASP_NETRest.Model.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Sockets;

namespace ASP_NETRest.Data.VO
{
    public class PersonVO
    {
        public long Id { get; set; }

        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        
        public string Address { get; set; }
        
        public string Gender { get; set; }
    }
}
