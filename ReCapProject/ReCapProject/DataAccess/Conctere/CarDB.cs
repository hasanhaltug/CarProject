using ReCapProject.DataAccess.Abstract;
using ReCapProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ReCapProject.DataAccess.Conctere
{
    public class CarDB:ICarDB
    {
        List<Car> Carss;

        public CarDB()
        {
            Carss = new List<Car>
            {
                new Car{ID=1,ColorID=1,BrandID=1,DailyPrice=90,ModelYear="2016",Description="This car name is Skoda. its clor is white"},
                new Car{ID=2,ColorID=3,BrandID=2,DailyPrice=300,ModelYear="2018",Description="This car name is BMW. its clor is blue"},
                new Car{ID=3,ColorID=2,BrandID=3,DailyPrice=320,ModelYear="2019",Description="This car name is Mercedes. its clor is black"},
                new Car{ID=4,ColorID=1,BrandID=4,DailyPrice=100,ModelYear="2020",Description="This car name is Volkswagen. its clor is white"},
                new Car{ID=5,ColorID=4,BrandID=5,DailyPrice=400,ModelYear="2010",Description="This car name is Audi. its clor is gry"},
                new Car{ID=6,ColorID=5,BrandID=6,DailyPrice=110,ModelYear="2015",Description="This car name is Seat. its clor is Red"},
                new Car{ID=7,ColorID=2,BrandID=1,DailyPrice=100,ModelYear="2017",Description="This car name is Skoda. its clor is white"}
            };
        }

        public void Add(Car car)
        {
            Car carsFind = Carss.SingleOrDefault(i=>i.ID==car.ID );//& i.BrandID==car.BrandID &i.ColorID==car.ColorID
            if (carsFind == null)
            {              
                Carss.Add(car);
                Console.WriteLine("Araç ekleme işlemi gerçekleşti");
            }
            else
            {
                Console.WriteLine("Eklenmek istenen araç zaten var");
            }
            
        }

        public void Delete(Car car)
        {
            Car carsFind = Carss.SingleOrDefault(i => i.ID == car.ID);//& i.BrandID==car.BrandID &i.ColorID==car.ColorID
            if (carsFind != null)
            {
                Carss.Remove(carsFind);
                Console.WriteLine("Araç Silme işlemi gerçekleşti");
            }
            else
            {
                Console.WriteLine("Silmek istenen araç zaten yok");
            }
        }

        public void Update(Car car)
        {
            Car carsFind = Carss.SingleOrDefault(i => i.ID == car.ID);
            carsFind.ColorID = car.ColorID;
            carsFind.BrandID = car.BrandID;
            carsFind.DailyPrice = car.DailyPrice;
            carsFind.ModelYear = car.ModelYear;
            carsFind.Description = car.Description;
        }

        public List<Car> GetById()
        {
            return Carss;
        }

        public List<Car> GetAll()
        {
            return Carss;
        }
    }
}
