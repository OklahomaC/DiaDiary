namespace DataAccess.IDataAccess;

public interface IMongoRepository<T>
{
      async Task Create(){}
      IEnumerable<T> GetAll();
      async Task Update(){}
      async Task Delete(){}
      async Task DeleteAll(){}

}