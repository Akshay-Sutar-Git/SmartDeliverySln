using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using SmartDelivery_Infra.Models;

namespace SmartDelivery_App.CQRS.Categories.Queries
{
    public record GetAllCategoriesQuery() : IRequest<List<Category>>;
    
}
