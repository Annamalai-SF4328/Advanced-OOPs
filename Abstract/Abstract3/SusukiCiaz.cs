namespace Abstract2
{
    public class SusukiCiaz : Car
    {
        private EngineType _engineType;
        private int _seatsCount;
        private double _price;
        private CarType _carType;
        public SusukiCiaz(EngineType engine,int seatsCount,double price,CarType carType)
        {
            EngineType=engine;
            SeatsCount=seatsCount;
            Price=price;
            CarType=carType;
        }
        public override string GetCarType()
        {
            return CarType.ToString();
        }

        public override string GetEngineType()
        {
            return EngineType.ToString();
        }

        public override double GetPrice()
        {
            return Price;
        }

        public override int GetSeats()
        {
            return SeatsCount;
        }
    }
}