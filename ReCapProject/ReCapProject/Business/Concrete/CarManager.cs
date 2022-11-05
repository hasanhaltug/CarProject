using ReCapProject.Business.Abstract;
using ReCapProject.DataAccess.Abstract;
using ReCapProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapProject.Business.Concrete
{
    public class CarManager : ICarManager
    {
        ICarDB _carDB;
        
        public CarManager(ICarDB Cardb)
        {
           _carDB=Cardb;
        }
        public void Add(Car car)
        {
            _carDB.Add(car);
        }

        public void Delete(Car car)
        {
            _carDB.Delete(car);
        }
        public void Update(Car car)
        {
            _carDB.Update(car);
        }

        public List<Car> GetAll()
        {
           return _carDB.GetAll();
        }

        public List<Car> GetById()
        {
           return _carDB.GetById();
        }

       
    }
}
