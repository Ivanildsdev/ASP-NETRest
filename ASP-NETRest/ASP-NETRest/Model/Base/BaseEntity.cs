using System.ComponentModel.DataAnnotations.Schema;

namespace ASP_NETRest.Model.Base
{
    public class BaseEntity
    {
        [Column("id")]
        public long Id { get; set; }
    }
}
