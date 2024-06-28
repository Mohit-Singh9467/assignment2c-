using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace assignment2c_.Controllers
{
   [RoutePrefix("api/calorie")]public class calorieController : ApiController
    { 
            [HttpGet]
            [Route("Menu/{burger}/{drink}/{side}/{dessert}")]
            public string Get(int burger, int drink, int side, int dessert)
            {
                int[] burgerCalories = { 0, 461, 431, 420, 0 };
                int[] drinkCalories = { 0, 130, 160, 118, 0 };
                int[] sideCalories = { 0, 100, 57, 70, 0 };
                int[] dessertCalories = { 0, 167, 266, 75, 0 };

                int totalCalories = burgerCalories[burger] + drinkCalories[drink] + sideCalories[side] + dessertCalories[dessert];
                return $"Your total calorie count is {totalCalories}";
            }
        }
    }

