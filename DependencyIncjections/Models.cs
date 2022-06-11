namespace DependencyIncjections
{
    public class Models
    {
        public Models()
        {
            ICar car = new PetrolCar();
            car.Run();
        }
        public interface ICar
        {
            void Run();
        }
        public interface IElecetrycityCar : ICar
        {
            bool HasBattery { get; set; }
        }
        public interface IPetrolCar : ICar
        {
            bool HasTank { get; set; }
        }
        public class ElectricityCar : IElecetrycityCar
        {
            public bool HasBattery { get; set; }

            public void Run()
            {
                Console.WriteLine("Elektrikli araba");
            }
        }
        public class PetrolCar : IPetrolCar
        {
            public bool HasTank { get; set; }

            public void Run()
            {
                Console.WriteLine("Benzinli/dizel araba");
            }
        }
    }
}
