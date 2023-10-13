using Dot6.HotChoc12.CRUD.Demo.Data;
using Dot6.HotChoc12.CRUD.Demo.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Dot6.HotChoc12.CRUD.Demo.GqlTypes
{
    public class QueryType
    {
        public async Task<List<Cake>> AllCakeAsync([Service] myWorldDbContext context)
        {
            return await context.Cake.ToListAsync();
        }



    }
}
