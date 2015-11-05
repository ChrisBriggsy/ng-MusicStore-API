using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;
using ng_MusicStore_Models;

namespace ng_MusicStore_Data
{
    public class MusicStoreDbContextFactory : IDbContextFactory<MusicStoreContext>
    {
	    public MusicStoreContext Create()
	    {
		    return new MusicStoreContext();
	    }
    }
}
