using HotChocolate;
using HotChocolate.Data;
using Microsoft.EntityFrameworkCore;
using GraphQL_CRUD_with_EF.Data;
using GraphQL_CRUD_with_EF.Data.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL_CRUD_with_EF.GqlTypes
{
    public class QueryType
    {
        public async Task<List<Cake>> AllCakeAsync([Service] MyWorldDbContext context)
        {
            return await context.Cake.ToListAsync();
        }
    }

}
