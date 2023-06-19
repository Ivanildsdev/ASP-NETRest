using ASP_NETRest.Data.VO;
using ASP_NETRest.Model;
using System.Collections.Generic;

namespace ASP_NETRest.Business
{
    public interface IPersonBusiness
    {
        PersonVO Create(PersonVO person);
        PersonVO FindByID(long id);
        List<PersonVO> FindAll();
        PersonVO Update(PersonVO person);
        void Delete(long id);

    }
}
