using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult OrderFood(Order order)
        {
            MongoClient dbClient = new MongoClient();
            var database = dbClient.GetDatabase("restaurant");
            var collection = database.GetCollection<Order>("orders");

            collection.InsertOne(order);

            return View(order);
        }

        public IActionResult ShowOrders() {

            MongoClient dbClient = new MongoClient();
            var database = dbClient.GetDatabase("restaurant");
            var collection = database.GetCollection<Order>("orders");

            List<Order> orders = collection.Find(o => true).ToList();
            return View(orders);
        }
    }
}
