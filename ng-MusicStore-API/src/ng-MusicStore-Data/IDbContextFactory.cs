using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;

namespace ng_MusicStore_Data
{
    public interface IDbContextFactory<T> where T : DbContext
    {
	    T Create();
    }
}
