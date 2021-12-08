using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductsController : ControllerBase
{
    private List<Product> products = new List<Product> {
        new Product("3 Æbleskiver", 15, "Food"),
        new Product("5 Æbleskiver", 20, "Food"),
        new Product("Gløgg", 5, "Bevrage"),
        new Product("Kaffe", 5, "Bevrage"),
        new Product("Cola 33 cl", 10, "Bevrage"),
        new Product("Risengrød", 15, "Food"),
        new Product("Bestik", 5, "Food"),
        new Product("Julegodter", 25, "Food"),
        new Product("Brændte Mandler", 25, "Food"),
        new Product("Frugt", 5, "Food"),
        new Product("Applesin 33 cl", 10, "Bevrage"),
        new Product("Simone", 100, "Food")
        };

    private readonly ILogger<ProductsController> _logger;

    public ProductsController(ILogger<ProductsController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "Products")]
    public IEnumerable<Product> Get()
    {
        return products
        .ToArray();
    }
}
