using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //core katmanı diğer katmanları referans almaz
    //generic constraint generic kısıt. t ne olabilir, class mesela o zaman int yazamayız where T:class
    //class: referans tip
    //t ya ientities olabilir yada ordan implemente olan bişey olabilir. T:class tek başına yetmiyo o zaman tüm classlar olabilirdi ben sadece burda kullandığım classlar olsun istiyorum
    //IEntity: IEntity olabilir veya Ientity implemente eden nesne olabilir
    //IEntity devre dışı bırakmak istiyorum new dicem. Interface oldugu için Ientity newlenemicek
    public interface IEntityRepository<T> where T : class, IEntity, new()
        //generic T, tekrarlayan şeyler olduğu için
        //Expression<Func<T,bool>> filter=null , expression bizim filtreler yazabilmemizi sağlıyo, ürünü fiyata,kategoriye göre listele
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

        //List<T> GetAllByCategory(int categoryId);
    }
}
