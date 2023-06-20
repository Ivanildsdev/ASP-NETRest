using Microsoft.AspNetCore.Mvc.Filters;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASP_NETRest.Hypermedia.Abstract
{
    public interface ISuportHyperMedia
    {
        List<HyperMediaLink> Links { get; set; }

    }
}
