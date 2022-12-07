namespace Tasks
{
    internal class Program
    {
        //Sukurkite interface’ą pavadinimų IVehicle su metodais Drive ir Refuel
        //(grąžinimo tipą galit pasirinkti patys ir tai kaip jį implementuosit,
        //galite daryti ir su void)
        //Tada sukurkite klasę Car, kuri implementuos šį interface’ą ir
        //taip pat turės properties string Model ir int Fuel.
        //Implementuokite reikalingus metodus, Drive() metodas turi patikrinti
        //ar degalai nėra pasibaigę, jeigu ne, važiuoti galima. Refuel metodas
        //turi patikrinti ar kiekis, kuriuo norima papildyti nėra minusinis(galite padaryti
        //ir maksimalų degalų bako dydį, bet pagalvokite, kaip tą funkcionalumą pernaudosite)


        static void Main(string[] args)
        {
            // 1task var car = new Car();
            //car.Drive();
            //car.Refuel(10);
            //car.Drive();

            //Pamodifikuokite pirmos užduoties programą.
            //Paverskite Car klasę abstrakčia ir pridėkite property string Model.
            //Sukurkite klasę BmwCar, kuri paveldės iš klasės Car ir turės savo property bool IsXDrive.
            //Sukurkite klasę AudiCar, kuri paveldės iš klasės Car ir turės savo property bool IsQuattro.
            var bmwCars = new List<BmwCar>
            {
                new BmwCar(true, "X5", 50),
                new BmwCar(true, "X6", 40),
                new BmwCar(false, "F10", 55),
                new BmwCar(false, "A", 20),
                new BmwCar(false, "1", 20),
            };

            var bmwComparer = new BmwCarComparer();
            bmwCars.Sort(bmwComparer);

            var fuelComparer = new BmwFuelComparer();
            bmwCars.Sort(fuelComparer);

            Console.ReadLine();

            //Implementuokite IComparer interface’ą ir kitiems automobilių tipams.

            var audiCars = new List<AudiCar>
            {
                new AudiCar(true, "X5", 50),
                new AudiCar(true, "X6", 40),
                new AudiCar(false, "F10", 55),
                new AudiCar(false, "B", 20),
                new AudiCar(false, "A", 20),
            };

            var audiComparer = new AudiCarComparer();
            audiCars.Sort(audiComparer);

            var audiFuelComparer = new AudiFuelComparer();
            audiCars.Sort(audiFuelComparer);

            var orderCars = bmwCars.OrderBy(x => x.Fuel).ThenBy(x => x.Model); // new listas

            Console.ReadLine();

            var bmw = new BmwCar(true, "BMW", 50);
            var audi = new AudiCar(false, "Audi", 100);

            bmw.Refuel(50);
            bmw.Drive();

            audi.Refuel(100);
            audi.Drive();

            Console.WriteLine(audi.Model);
            Console.WriteLine(bmw.Model);
        }
    }
}