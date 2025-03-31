using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore.Migrations;
using SmartDelivery_Infra.Models;

using SmartDelivery_Infra.Repositories.ReposInterFace;

namespace SmartDelivery_App.CQRS.Categories.Queries
{
    public class GetAllCategoriesHandler : IRequestHandler<GetAllCategoriesQuery, IEnumerable<Category>>
    {
        private readonly ISmartDeliveryRepos repos;
        public GetAllCategoriesHandler(ISmartDeliveryRepos _repos)
        {
            this.repos = _repos;
        }

        public async Task<IEnumerable<Category>> Handle(GetAllCategoriesQuery request, CancellationToken cancellationToken)
        {
            return await repos.GetCategoriesAsync();
        }

    }
}
