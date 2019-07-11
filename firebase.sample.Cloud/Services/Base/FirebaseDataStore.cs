using Firebase.sample.Cloud.Config;
using Firebase.sample.Cloud.Models;
using Plugin.CloudFirestore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firebase.sample.Cloud.Services
{
    public class FirebaseDataStore<T> : IDataStore<T>
        where T : FirebaseModel
    {
        private readonly string path;

        public FirebaseDataStore(string path)
        {
            this.path = path;
        }

        public Task AddItem(T item)
        {
            return CrossCloudFirestore.Current
                         .GetInstance(ApiKeys.FirebaseName)
                         .GetCollection(path)
                         .AddDocumentAsync(item);
        }

        public Task DeleteItem(T item)
        {
            return CrossCloudFirestore.Current
                         .GetInstance(ApiKeys.FirebaseName)
                         .GetCollection(path)
                         .GetDocument(item.Id)
                         .DeleteDocumentAsync();
        }

        public async Task<List<T>> GetItemsAsync()
        {
            var query = await CrossCloudFirestore.Current
                                    .GetInstance(ApiKeys.FirebaseName)
                                    .GetCollection(path)
                                    .GetDocumentsAsync();

            return query.ToObjects<T>().ToList();
        }
    }
}
