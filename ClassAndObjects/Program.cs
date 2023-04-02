using System;

namespace ClassAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            // Membuat Object Taxi
            Taxi taxi = new Taxi();

            // Pengesetan Nilai Properties
            Console.WriteLine("Masukkan Nama Driver: ");
            taxi.DriverName = Console.ReadLine();
            taxi.OnDuty = true;
            Console.WriteLine("Masukkan Jumlah Penumpang: ");
            taxi.NumPassenger = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            // Pemanggilan Method
            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();

            Console.ReadLine();
        }
    }
}
