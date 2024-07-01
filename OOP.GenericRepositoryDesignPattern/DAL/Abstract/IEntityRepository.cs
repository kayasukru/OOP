using OOP.GenericRepositoryDesignPattern.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.GenericRepositoryDesignPattern.DAL.Abstract
{
    public interface IEntityRepository<T>
        where T : class, IEntity, new()
    {
        //CRUD
        void Create(T entity); // (C)reate
        List<T> GetAll(); // (R)ead
        T Get(); //

        void Update(T entity);
        void Delete(int entity);
    }
}
