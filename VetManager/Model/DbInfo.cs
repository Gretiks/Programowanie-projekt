public class DbInfo
{
    public string connector { get; set; }
    public DbInfo()
    {
        this.connector = "Server=localhost;Database=weterynarz;Uid=root;Pwd=1234;";
    }
}