
// cho phép truyên type vào class này

public interface IHasId
{
    int ID {get; set; }
}
public class DanhMuc<T> where T : class, IHasId
{
    private readonly List<T> danhSach = new List<T>();

    public DanhMuc()
    {
        
    }

    public void Add(T item)
    {
        danhSach.Add(item);
    }

    public List<T> GetAll()
    {
        return danhSach.ToList();
    }

    public T Get(int id)
    {
        return danhSach.FirstOrDefault(x => x.ID == id);
    }

    public bool Update(T updatedItem)
    {
        var existing = Get(updatedItem.ID);
        if(existing == null)
        {
            return false;
        }

        int index = danhSach.IndexOf(existing);
        danhSach[index] = updatedItem;
        return true;
    }

    public bool Delete(int id)
    {
        var item = Get(id);
        if(item == null)
        {
            return false;
        }
        danhSach.Remove(item);
        return true;

    }
}

