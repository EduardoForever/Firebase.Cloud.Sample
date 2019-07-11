using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace Firebase.sample.Cloud.Services
{
    public interface IDataStore<T>
    {
        Task AddItem(T item);
        Task DeleteItem(T item);
        Task<List<T>> GetItemsAsync();
    }
}
