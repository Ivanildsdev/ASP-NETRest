using ASP_NETRest.Model;
using System.Collections.Generic;

namespace ASP_NETRest.Repository
{
    public interface IPersonRepository
    {
        Person Create(Person person);
        Person FindByID(long id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long id);
        bool Exists(long id);

    }
}
