
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace aspnet_api_swagger_design
{
    /// <summary>
    /// This Product Entity Class
    /// </summary>
    
    
    public class Product
    {
        
        /// <summary>
        /// ProductId
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [Required]
        //[JsonProperty("name")]
        public string Name { get; set; }


        /// <summary>
        /// Description
        /// </summary>
        //[JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Categrory
        /// </summary>
        [Required]
        //[JsonProperty("categrory")]
        public string Categrory { get; set; }

        /// <summary>
        /// ImageUrl
        /// </summary>
        //[JsonProperty("imageUrl")]
        public string? ImageUrl { get; set; }

    }
}
