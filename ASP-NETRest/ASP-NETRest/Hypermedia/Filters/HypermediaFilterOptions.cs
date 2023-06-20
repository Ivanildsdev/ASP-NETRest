using ASP_NETRest.Hypermedia.Abstract;
using System.Collections.Generic;

namespace ASP_NETRest.Hypermedia.Filters
{
    public class HypermediaFilterOptions
    {
        public List<IResponseEnricher>  ContentResponseEnricherList { get; set; } = new List<IResponseEnricher>();
    }
}
