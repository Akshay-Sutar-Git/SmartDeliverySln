using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartDelivery_Infra.Models;

namespace SmartDelivery_Infra.Repositories.ReposInterFace
{
    public interface ISmartDeliveryRepos
    {
        Task<IEnumerable<Category>> GetCategoriesAsync();
    }
}
