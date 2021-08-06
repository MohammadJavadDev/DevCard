using System;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard_Mvc.Models
{
    public class Car
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

        public Car(Guid id, string name, string title, string description , string imageurl)
        {
            Id = id;
            Name = name;
            Title = title;
            Description = description;
            ImageUrl = imageurl;
        }
    }
}
