namespace BlabberApp.Domain.Interfaces
{
    public interface IDataStore
    {
        bool Create(IDatum entity);
        IDatum Read(int idx);
        bool Update(IDatum entity);
        bool Delete(int idx);
 
    }
}