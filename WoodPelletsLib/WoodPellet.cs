namespace WoodPelletsLib
{
    public class WoodPellet
    {

        public int Id { get; set; }

        //laver instansfelter for de properties der har constrains, så disse kan skrives direkte ind i propertien
        private string _brand;

        public string Brand
        {
            get { return _brand; }
            set
            {
                if (value.Length >= 2)
                {
                    _brand = value;
                }
                else
                {
                    throw new ArgumentException("Brand skal minimum have 2 bogstaver");
                }
            }
        }

        private double _price;

        public double Price
        {
            get { return _price; }
            set
            {
                if (value >= 0)
                {
                    _price = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Prisen skal være positiv");
                }
            }
        }

        private int _quality;

        public int Quality
        {
            get { return _quality; }
            set
            {
                if (value >= 1 &&  value <= 5)
                {
                    _quality = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Kvalitet skal være mellem 1 og 5");
                }
            }
        }

        public WoodPellet(int id, string brand, double price, int quality)
        {
            Id = id;
            Brand = brand;
            Price = price;
            Quality = quality;
        }

        public WoodPellet()
        {
        }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Brand)}={Brand}, {nameof(Price)}={Price.ToString()}, {nameof(Quality)}={Quality.ToString()}}}";
        }
    }
}