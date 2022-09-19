using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string producto { get; set; } = string.Empty;
         
        public int Precio { get; set; }
        public string Tipo { get; set; } = string.Empty;
        public float Domicilio { get; set; }
        
    
    }
}