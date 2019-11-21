using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradingCompany.BLL.DTO;
using TradingCompany.BLL.Services.Abstractions;
using TradingCompany.DAL.Models.Entities.Implementations;
using TradingCompany.DAL.Models.Filters.Implementations;
using TradingCompany.DAL.UnitOfWork;

namespace TradingCompany.BLL.Services.Implementations
{
    public class OrderService : IOrderService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public OrderService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public IEnumerable<OrderDTO> GetOrders()
        {
            var orders = _unitOfWork.OrdersRepository.GetAll();
            OrderDTO buff = new OrderDTO();
            List<OrderDTO> orderDTO = new List<OrderDTO>();
            foreach (Order order in orders)
            {
                buff = _mapper.Map<Order, OrderDTO>(order);
                buff.User = _unitOfWork.UsersRepository.Get(new UserFilter() { Id = order.Id });
                orderDTO.Add(buff);
            }
            return orderDTO;
        }
    }
}
