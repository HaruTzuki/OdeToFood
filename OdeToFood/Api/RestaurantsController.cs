using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OdeFood.Data;
using OdeToFood.Core;

namespace OdeToFood.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantsController : ControllerBase
    {
        private readonly IRestaurantData restaurantData;

        public RestaurantsController(IRestaurantData restaurantData)
        {
            this.restaurantData = restaurantData;
        }

        [HttpGet]
        public IEnumerable<Restaurant> GetRestaurants()
        {
            return restaurantData.GetRestaurantsByName("");
        }
    }
}