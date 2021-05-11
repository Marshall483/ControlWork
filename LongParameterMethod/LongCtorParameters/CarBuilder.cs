namespace LongParameterMethod.LongCtorParameters
{
    public class CarBuilder
    {
        private Car _car;

        public CarBuilder()
        {
            _car = new Car();
        }

        public CarBuilder SetWheels(uint count)
        {
            _car.WheelCount = count;
            return this;
        }

        public CarBuilder SetDoors(uint doors)
        {
            _car.DoorsCount = doors;
            return this;
        }

        public CarBuilder SetMaxLoad(uint load)
        {
            _car.MaxLoad = load;
            return this;
        }

        public CarBuilder SetManufacturer(Manufacturer manufacturer)
        {
            _car.Manufacturer = manufacturer;
            return this;
        }

        public CarBuilder SetColor(Color color)
        {
            _car.Color = color;
            return this;
        }

        public Car Build()
        {
            return _car;
        }
    }
}