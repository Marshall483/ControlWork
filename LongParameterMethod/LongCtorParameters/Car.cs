namespace LongParameterMethod.LongCtorParameters
{
    public enum Color
    {
        Green,
        Yellow,
        Blue,
        White,
        Black
    }

    public enum Manufacturer
    {
        Opel,
        Shcoda,
        Lada,
        Toyota
    }
    
    public class Car
    {
        public uint WheelCount { get; set; }
        public uint DoorsCount { get; set; }
        public uint MaxLoad { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public Color Color { get; set; }

        public static CarBuilder CreateBuilder()
        {
            return new CarBuilder();
        }
    }
}