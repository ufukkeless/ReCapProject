using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Car : IEntity
    {
        //id
        public int CarId { get; set; }
        //Marka id
        public int BrandId { get; set; }
        //Renk id
        public int ColorId { get; set; }
        //Model yılı
        public int ModelYear { get; set; }
        //Güncel fiyatı
        public int DailyPrice { get; set; }
        //Tanım-açıklama
        public string Description { get; set; }
    }
}
