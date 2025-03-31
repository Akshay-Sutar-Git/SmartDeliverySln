using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using SmartDelivery_App.CQRS.Categories.Queries;
using SmartDelivery_App.DTOs;
using SmartDelivery_App.Interfaces;

namespace SmartDelivery_App.Services
{
    public class SmartDeliveryServices:ISmartDeliveryServices
    {
        private readonly IMediator mediator;
        private readonly IMapper mapper;

        public SmartDeliveryServices(IMediator _mediator, IMapper _mapper)
        {
            mediator = _mediator;
            mapper = _mapper;
        }
        public async Task<IEnumerable<CategoryDto>> GetAllCategoriesAsync()
        {
            var categories = await mediator.Send(new GetAllCategoriesQuery());
            return mapper.Map<IEnumerable<CategoryDto>>(categories);
        }
    }
}
