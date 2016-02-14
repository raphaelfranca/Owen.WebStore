﻿using Owen.WebStore.Domain.Commands.OrderCommands;
using Owen.WebStore.Domain.Services;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Owen.WebStore.Api.Controllers
{
    public class OrderController : BaseController
    {
        private readonly IOrderApplicationService _service;

        public OrderController(IOrderApplicationService service)
        {
            this._service = service;
        }

        [HttpPost]
        [Authorize]
        [Route("api/orders")]
        public Task<HttpResponseMessage> Post([FromBody]dynamic body)
        {
            var command = new CreateOrderCommand(
                orderItems: body.orderItems.ToObject<List<CreateOrderItemCommand>>()
            );

            var order = _service.Create(command, User.Identity.Name);
            return CreateResponse(HttpStatusCode.Created, order);
        }
    }
}