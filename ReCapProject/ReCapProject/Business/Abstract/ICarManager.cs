using ReCapProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapProject.Business.Abstract
{
    public interface ICarManager
    {
        List<Car> GetAll();
        List<Car> GetById();
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
    }
}
