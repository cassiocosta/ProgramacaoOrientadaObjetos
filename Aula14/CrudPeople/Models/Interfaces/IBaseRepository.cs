using System.Collections.Generic;

namespace CrudPeople.Models.Interfaces
{
    public interface IBaseRepository<Entity>
        where Entity : class
    {
         
        Entity GetById(int id);
        List<Entity>GetAll();
        void Create(Entity obj);
        void Delete(int id);
        void Update(Entity obj);
        

    }
}