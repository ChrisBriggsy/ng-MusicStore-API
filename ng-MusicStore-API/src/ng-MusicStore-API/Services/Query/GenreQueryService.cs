using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.Data.Entity;
using Microsoft.Framework.DependencyInjection;
using ng_MusicStore_API.Models;

namespace ng_MusicStore_API.Services.Query
{
	public class GenreQueryService : IGenreQueryService
	{
		private readonly IDbContextFactory<MusicStoreContext> _dbContextFactory;

		public GenreQueryService(IDbContextFactory<MusicStoreContext> dbContextFactory)
		{
			_dbContextFactory = dbContextFactory;
		}

		public async Task<IEnumerable<Genre>> GetAllGenres()
		{
			using (var dbContext = _dbContextFactory.Create())
			{
				var genres = await dbContext.Genres.ToListAsync();
				return genres;
			}
		}
	}

}
