namespace LongParameterMethod.LongCtorParameters
{
    public class CarDirector
    {
        public Car BuildSportcar()
        {
            var car = Car.CreateBuilder()
                .SetManufacturer(Manufacturer.Lada)
                .SetColor(Color.Yellow)
                .SetDoors(100)
                .SetWheels(100)
                .SetMaxLoad(1)
                .Build();

            return car;
        }

        public Car BuildDefault()
        {
            var car = Car.CreateBuilder()
                .SetManufacturer(Manufacturer.Opel)
                .SetColor(Color.Blue)
                .SetDoors(5)
                .SetWheels(4)
                .SetMaxLoad(42)
                .Build();

            return car;
        }
    }
}