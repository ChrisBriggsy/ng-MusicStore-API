using Microsoft.Data.Entity;
using ng_MusicStore_API.Models;

namespace ng_MusicStore_API.Services
{
	public interface IDbContextFactory<T> where T: DbContext
	{
		/// <summary>
		/// Creates new dbcontext
		/// </summary>
		/// <returns>New instance of db context</returns>
		T Create();
	}
}