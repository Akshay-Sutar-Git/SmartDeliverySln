using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartDelivery_App.DTOs;

namespace SmartDelivery_App.Interfaces
{
    public interface ISmartDeliveryServices
    {
        Task<IEnumerable<CategoryDto>> GetAllCategoriesAsync();
    }
}
