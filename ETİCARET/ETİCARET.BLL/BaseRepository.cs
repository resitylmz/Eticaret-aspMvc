using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETİCARET.BLL
{
    protected readonly TeknoBlogContext context = new TeknoBlogContext();
    public ICollection<T> Listele(Expression<Func<T, bool>> filter = null)
    {
        return filter == null ? context.Set<T>().ToList() : context.Set<T>().Where(filter).ToList();
    }

    public T Ara(IdType id)
    {
        return context.Set<T>().Find(id);
    }

    public bool Ekle(T data)
    {
        // context.Set<T>().Add(data);
        //aşağıdaki iki satır, yukarıdaki bir satırın alternatifidir.
        var addedData = context.Entry<T>(data);
        addedData.State = System.Data.Entity.EntityState.Added;
        int durum = context.SaveChanges();
        return durum == 0 ? false : true;
    }

    public bool Sil(IdType id)
    {
        var removedData = context.Set<T>().Find(id);
        context.Set<T>().Remove(removedData);
        // context.Set<T>().Add(data);
        //aşağıdaki iki satır, yukarıdaki bir satırın alternatifidir.
        //var rd = context.Entry<T>(removedData);
        //rd.State = System.Data.Entity.EntityState.Deleted;
        int durum = context.SaveChanges();
        return durum == 0 ? false : true;
    }

    public bool Guncelle(T data)
    {
        var guncellenenData = context.Entry<T>(data);
        guncellenenData.State = System.Data.Entity.EntityState.Modified;
        int durum = context.SaveChanges();
        return durum == 0 ? false : true;
    }
}
}
