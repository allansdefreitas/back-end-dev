
using ScreenSound.Modelos;

internal abstract class DAL<T>
{

    public abstract IEnumerable<T> ListAll();

    public abstract void Add(T obj);

    public abstract void Update(T obj);
    public abstract void Delete(T obj);

    public abstract T Get(int id);

    public abstract T GetByName(string name);


}
