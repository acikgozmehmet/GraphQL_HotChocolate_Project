using Dot6.HotChoc12.CRUD.Demo.Data;
using Dot6.HotChoc12.CRUD.Demo.Data.Entities;

namespace Dot6.HotChoc12.CRUD.Demo.GqlTypes
{
    public class MutationType
    {
        public async Task<Cake> SaveCakeAsync([Service] myWorldDbContext context, Cake newCake)
        {
            context.Cake.Add(newCake);
            await context.SaveChangesAsync();
            return newCake;
        }

        public async Task<Cake> UpdateCakeAsync([Service] myWorldDbContext context, Cake updateCake)
        {
            context.Cake.Update(updateCake);
            await context.SaveChangesAsync();
            return updateCake;
        }

        public async Task<string> DeleteCakeAsync([Service] myWorldDbContext context, int id)
        {

            var cakeToDelete = await context.Cake.FindAsync(id);

            if (cakeToDelete == null) {
                return "invalid opeartion";
            }

            context.Cake.Remove(cakeToDelete);
            await context.SaveChangesAsync();
            return "Deleted";
        }


    }
}
