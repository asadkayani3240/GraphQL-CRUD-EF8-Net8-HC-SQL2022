using GraphQL_CRUD_with_EF.Data;
using GraphQL_CRUD_with_EF.Data.Entities;
using HotChocolate;
using HotChocolate.Data;
using System.Threading.Tasks;

namespace GraphQL_CRUD_with_EF.GraphQL
{
    public class MutationType
    { 
        public async Task<Cake> SaveCakeAsync([Service] MyWorldDbContext context, Cake newCake)
        {
            context.Cake.Add(newCake);
            await context.SaveChangesAsync();
            return newCake;
        }
         
        public async Task<Cake> UpdateCakeAsync([Service] MyWorldDbContext context, Cake updateCake)
        {
            context.Cake.Update(updateCake);
            await context.SaveChangesAsync();
            return updateCake;
        }
         
        public async Task<string> DeleteCakeAsync([Service] MyWorldDbContext context, int id)
        {
            var cakeToDelete = await context.Cake.FindAsync(id);
            if (cakeToDelete == null)
            {
                return "Invalid operation";
            }
            context.Cake.Remove(cakeToDelete);
            await context.SaveChangesAsync();
            return "Deleted!";
        }
    }
}
