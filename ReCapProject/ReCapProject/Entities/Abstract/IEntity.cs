using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapProject.Entities.Abstract
{
    public interface IEntity
    {
        public int ID { get; set; }
        public int BrandID { get; set; }
        public int ColorID { get; set; }
        public  string ModelYear { get; set; }
        public double DailyPrice { get; set; }
        public string Description { get; set; }
    }
}
