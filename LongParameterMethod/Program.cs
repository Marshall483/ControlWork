using System;
using LongParameterMethod.LongCtorParameters;

namespace LongParameterMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var director = new CarDirector();
            
            var sportcar = director.BuildSportcar();
            var defaultCar = director.BuildDefault();
            
            var customCar = Car
                .CreateBuilder()
                .SetWheels(10)
                .SetDoors(10)
                .SetMaxLoad(1000)
                .SetManufacturer(Manufacturer.Shcoda)
                .SetColor(Color.White)
                .Build();
            
        }
    }
}