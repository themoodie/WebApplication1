using System;
namespace WebApplication1.Models
{
    public class Site
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string URL { get; set; }
        public string Description { get; set; }
        public virtual User User { get; set; }
    }
}
