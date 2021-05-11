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
    
    public class Car
    {
        public uint WheelCount { get; set; }
        public uint DoorsCount { get; set; }
        public uint MaxMaxLoad { get; set; }
        public string Manufacturer { get; set; }
        public Color Color { get; set; }

        public Car(uint wheelCount, uint doors, uint maxLoad, string manufacturer, Color color)
        {
            WheelCount = wheelCount;
            DoorsCount = doors;
            MaxMaxLoad = maxLoad;
            Manufacturer = manufacturer;
            Color = color;
        }
        
    }
}