using ReCapProject.Business.Concrete;
using ReCapProject.DataAccess.Conctere;
using ReCapProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapProject.ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            CarManager _carManager = new CarManager(new CarDB());

            Car car1 = new Car
            {
                ID = 8,
                BrandID = 2,
                ColorID = 1,
                DailyPrice = 200,
                ModelYear = "2019",
                Description = "This car name is BMW. its clor is white"
            };

            foreach (var item in _carManager.GetAll())
            {
                Console.WriteLine(item.ID +" - "+ item.Description);
            }
            
            _carManager.Add(car1);

            car1.ColorID = 2;
            car1.BrandID = 3;
            car1.Description = "Very fast car";

            _carManager.Update(car1);


            _carManager.Delete(car1);


            foreach (var item in _carManager.GetById())
            {
                Console.WriteLine(item.ID);
            }
            
            
            Console.ReadLine();


        }
        
        

    }
}
