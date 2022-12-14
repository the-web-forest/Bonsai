using MongoDB.Driver;
using Bonsai.Domain.Models;
using MongoDB.Bson;
using Bonsai.Helpers;

namespace Bonsai.External.Repositories
{
	public abstract class BaseRepository<T> where T: Model
	{

		protected readonly IMongoCollection<T> _collection;

		protected BaseRepository(IMongoDatabase mongoDatabase)
		{
			_collection = mongoDatabase.GetCollection<T>(typeof(T).Name);
		}

		public async Task Create(T Data)
        {
			Data.CreatedAt = DateHelper.BrazilDateTimeNow();
			Data.UpdatedAt = DateHelper.BrazilDateTimeNow();
            await _collection.InsertOneAsync(Data);
        }

		public async Task Update(T Data)
        {
            Data.UpdatedAt = DateHelper.BrazilDateTimeNow();
            await _collection.ReplaceOneAsync(doc => doc.Id == Data.Id, Data);
        }

	}
}

