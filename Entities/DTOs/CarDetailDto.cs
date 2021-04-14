using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    //join operasyonlarını yazmak için kullanırız
    //:IEntity veremem çünkü o sen bi veritabanı tablosusun demek
    //dicem ki sen bi dtosun. cunku bu tek basına bı tablo değil
    //birkaç tablonun bir kaç satırını içeriyo
    public class CarDetailDto:IDto
    {
        public int CarId { get; set; }
        public string CarName { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public string CategoryName { get; set; }
        public decimal DailyPrice { get; set; }
    }
}
