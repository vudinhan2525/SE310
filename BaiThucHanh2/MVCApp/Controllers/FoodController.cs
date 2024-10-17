using Microsoft.AspNetCore.Mvc;
using MVCApp.Models;
namespace MVCApp.Controllers
{   
    public class DeleteFoodRequest
    {
        public int Id { get; set; }
    }

    public class FoodController : Controller
{
    private readonly ApplicationDbContext _context;
    private readonly ILogger<FoodController> _logger;
    public FoodController(ApplicationDbContext context,ILogger<FoodController> logger)
    {
        _context = context;
         _logger = logger;
    }

    [HttpGet("/Food/{id}")]
    public IActionResult Details(int id)
    {
        var food = _context.Foods.FirstOrDefault(f => f.Id == id);
        if (food == null)
        {
            return NotFound();
        }
        return View(food); 
    }

    [HttpPost]
    public IActionResult Add(Food newFood)
    {
        if (ModelState.IsValid)
        {
            _context.Foods.Add(newFood); 
            _context.SaveChanges();      
            return Ok();                
        }
        
        return BadRequest(); 
    }
    [HttpPost("/Food/DeleteById")]
    public IActionResult DeleteById([FromBody] DeleteFoodRequest request) 
    {   
        var food = _context.Foods.FirstOrDefault(f => f.Id == request.Id);
        if (food == null)
        {
            return NotFound();
        }
        _context.Foods.Remove(food);
        _context.SaveChanges();

        return Ok();
    }

    [HttpPost("/Food/Update")]
    public IActionResult Update([FromBody] Food updatedFood) 
    {
        if (ModelState.IsValid)
        {
            var food = _context.Foods.FirstOrDefault(f => f.Id == updatedFood.Id);
            if (food == null)
            {
                return NotFound();
            }

            // Update the food properties
            food.Name = updatedFood.Name;
            food.Description = updatedFood.Description;
            food.Price = updatedFood.Price;
            food.Image = updatedFood.Image;

            _context.SaveChanges();
            return Ok();
        }
        
        return BadRequest();
    }
}
}
