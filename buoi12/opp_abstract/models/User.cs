using vanPhong;

public class User : IHasId
{
    public int Id { get; set; }
    public string userName { get; set; }
    public string password { get; set; }
    public string fullName { get; set; }
    public string email { get; set; }

    
}