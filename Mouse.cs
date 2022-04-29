namespace HelloWorld
{
    /// <summary>Computer mouse representation. Setting some default values.</summary>
    public class Mouse
    {
        public System.Guid Id { get; } = System.Guid.NewGuid();
        public bool IsWireless { get; set; } = true;
        public string Brand { get; set; } = "No brand";
        public int NumberOfButtons { get; set; } = 3;
        public string Color { get; set; } = "blue";
        public bool? HasLight { get; set; }
        public decimal? Price { get; set; }
    }
}