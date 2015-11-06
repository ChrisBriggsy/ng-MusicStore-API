using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ng_MusicStore_API.Models;

namespace ng_MusicStore_API.Services.Query
{
    public interface IGenreQueryService
    {
		/// <summary>
		/// Gets all genres
		/// </summary>
		/// <returns>List of genres</returns>
	    Task<IEnumerable<Genre>> GetAllGenres();
    }
}
