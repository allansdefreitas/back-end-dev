
using Microsoft.EntityFrameworkCore;
using ScreenSound.Banco;
using ScreenSound.Modelos;

internal abstract class DAL<T> where T : class
{

    private readonly ScreenSoundContext context;

    public DAL(ScreenSoundContext context)
    {
        this.context = context;
    }

    public IEnumerable<T> ListAll()
    {
        return context.Set<T>().ToList();
    }

    public void Add(T obj)
    {
        context.Set<T>().Add(obj);
        context.SaveChanges();
    }

    public void Update(T obj)
    {
        context.Set<T>().Update(obj);
        context.SaveChanges();
    }
    public void Delete(T obj)
    {
        context.Set<T>().Remove(obj);
        context.SaveChanges();
    }

    public T? Get(int id)
    {
        return context.Set<T>().Find(id);
    }

    public T? GetByName(string name)
    {
        return context.Set<T>().FirstOrDefault(theName => theName.Equals(name));
    }

    public void PrintAll()
    {
        var objs = ListAll();
        foreach (var obj in objs)
        {
            Console.WriteLine(obj);
            Console.WriteLine("===================================");
        }
    }

}
