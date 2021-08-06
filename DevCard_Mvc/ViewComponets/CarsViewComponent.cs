using System;
using System.Collections.Generic;
using DevCard_Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace DevCard_Mvc.ViewComponents
{
    public class CarsViewComponent : ViewComponent
    {
        
        public ViewViewComponentResult Invoke()
        {

            var Cars = new List<Car>
            {
                new Car(Guid.NewGuid(),"بنز" , "بنز بهترین ماشین" , "بنز یکی از بهترین ماشین های حال حاضر دنیا.","Images/Cars/benz.jpg"),
                new Car(Guid.NewGuid(),"بی ام وی" , "بی ام وی بهترین ماشین" , "بی ام وی یکی از بهترین ماشین های حال حاضر دنیا.","Images/Cars/bmw.jpg"),
                new Car(Guid.NewGuid(),"مک لارن" , "مک لارن بهترین ماشین" , "مک لارن یکی از بهترین ماشین های حال حاضر دنیا.","Images/Cars/maclaren.jpg"),
                new Car(Guid.NewGuid(),"بنز" , "بنز بهترین ماشین" , "بنز یکی از بهترین ماشین های حال حاضر دنیا.","Images/Cars/benz.jpg"),
            };
            return View("_Cars",Cars);
        }
    }
}