using FleetManagement_Backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FleetManagement_Backend.DAL.CarCategoryComponent
{
    public class SQLCarCategoryRepository : ICarCategoryInterface
    {
        private readonly AppDbContext context;

        public SQLCarCategoryRepository(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<ActionResult<IEnumerable<CarCategory>>?> GetAllCarCategories()
        {
            if (context.Car_category == null)
            {
                return null;
            }

            return await context.Car_category.ToListAsync();
            //throw new NotImplementedException();
        }
    }
}
