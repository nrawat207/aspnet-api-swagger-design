using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace aspnet_api_swagger_design.Controllers
{
    /// <summary>
    /// Product Controller 
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        /// <summary>
        /// Gets the list of all Products.
        /// </summary>
        /// <returns>The list of Products.</returns>
        /// <response code="200">Products received sucessfully</response>
        /// <response code="404">No record found</response>
        [HttpGet]
        [Produces("application/json")]
        public ActionResult GetAll()
        {
            return Ok(GetAllProducts());
        }


        /// <summary>
        /// Creates a Product.
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST api/Product
        ///     {        
        ///       "name": "FlowerPot",
        ///       "description": "FlowerPot for indoor",
        ///       "category": "home decor"        
        ///     }
        /// </remarks>
        /// <param name="product"></param>    
        /// <returns>A newly created Product</returns>
        /// <response code="201">Returns the newly created product</response>
        /// <response code="400">If the product is null</response>
        /// <response code="401">Unauthorized access to create new product</response>
        [HttpPost]       
        public ActionResult<Product> Post(Product product)
        {
            if(product == null || string.IsNullOrEmpty(product.Name)) { 
                return BadRequest("product is null");
            }

            // Logic to create new Employee
            return Ok(new Product());
        }


        private static IEnumerable<Product> GetAllProducts()
        {
            return new List<Product>()
            { new Product() };
        }
    }
}
