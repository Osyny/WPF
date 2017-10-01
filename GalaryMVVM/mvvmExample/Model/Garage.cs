using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvvmExample.Model
{
    //3. Create source
    class Garage
    {
        public static List<Car> AllCars { get; set; } = new List<Car>()
        {
            new Car { Image="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTs7L6yFDSocYapkw9WMH6tal3h9rFl21Nj3n2ukumhn6uIxLxhwA",
						Model="X5",
						Name="BMW",
						Year=2016,
						Tag = { "#_car1" }
				            },
            new Car { Image="http://www.chicco.ru/images/8058664011865/derby-goluboj-mashinki-turbo-touch-crash-igrushki-/full.jpg",
                        Model="Corolla",
                        Name="Toyota",
                        Year=2012,
						Tag = { "#_car2",
								"#_IsLike"}
				},

            new Car { Image="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR020vkPkrgIRb6WutOBIJXDbYuSuvLBaFxh67Pw7jUjaFwlbNI",
                        Model="B3",
                        Name="Volkswagen",
                        Year=2014,
                        Tag = { "#_car3",
                                "#_IsLike3"}
                }
        };


    }
}
