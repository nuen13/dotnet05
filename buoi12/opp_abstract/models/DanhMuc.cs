

namespace vanPhong
{
    //Cho phép truyền type vào class này
public interface IHasId
{
    int Id { get; set; }
}

public class DanhMuc<T> where T : class, IHasId
{
    private readonly List<T> danhSach = new List<T>();

    public DanhMuc()
    {
    }

    // Thêm
    public void Add(T item)
    {
        danhSach.Add(item);
    }

    // Lấy toàn bộ
    public List<T> GetAll()
    {
        return danhSach.ToList();
    }

    // Lấy theo Id
    public T Get(int id)
    {
        return danhSach.FirstOrDefault(x => x.Id == id);
    }

    // Cập nhật
    public bool Update(T updatedItem)
    {
        var existing = Get(updatedItem.Id);
        if (existing == null)
            return false;

        int index = danhSach.IndexOf(existing);
        danhSach[index] = updatedItem;
        return true;
    }

    // Xóa
    public bool Delete(int id)
    {
        var item = Get(id);
        if (item == null)
            return false;

        danhSach.Remove(item);
        return true;
    }
}








}
