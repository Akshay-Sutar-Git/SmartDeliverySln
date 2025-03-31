using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SmartDelivery_Infra.Context;
using SmartDelivery_Infra.Models;
using SmartDelivery_Infra.Repositories.ReposInterFace;

namespace SmartDelivery_Infra.Repositories
{
    public class SmartDeliveryRepos:ISmartDeliveryRepos
    {
        private readonly SmartDeliveryDbContext context;
        public SmartDeliveryRepos(SmartDeliveryDbContext _context) 
        {
            this.context = _context;
        }

        public async Task<IEnumerable<Category>> GetCategoriesAsync()
        {
            return await context.categories.ToListAsync();
        }
        //public List<Category> GetAllCategories()
        //{
        //    var cat  = context.categories.ToList();
        //    return cat; 
        //}
    }
}
