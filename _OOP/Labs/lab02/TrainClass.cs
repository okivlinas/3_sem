using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lab02
{
    class Train
    {
        private int trainNumber;
        private string destination;
        private string departureTime;
        private int Seats;
        public static int count = 0; 
        private readonly int id; 
        public int Id
        {
            get { return id; }
        }
        public int TrainNumber
        {
            get { return trainNumber; }
            set { trainNumber = value; }
        }
        public string Destination
        {
            get { return destination; }
            set { destination = value; }
        }
        private string DepartureTime
        {
            get { return departureTime; }
            set { departureTime = value; }
        }
        private int seats
        {
            get { return Seats; }
            set { Seats = value; }
        }

        public Train(int mTrainNumber, string mDestination, string mDepartureTime, int mSeats)
        {
            trainNumber = mTrainNumber;
            destination = mDestination;
            departureTime = mDepartureTime;
            Seats = mSeats;
            id = GetHashCode();
            count++;
        }
        public Train(int mTrainNumber, string mDestination, string mDepartureTime)
        {
            trainNumber = mTrainNumber;
            destination = mDestination;
            departureTime = mDepartureTime;
            Seats = 100;
            id = GetHashCode();
            count++;
        }
        public Train()
        {
            trainNumber = 0;
            destination = "Default";
            departureTime = "Default";
            Seats = 0;
            id = GetHashCode();
            count++;
        }
        static Train()
        {
            count = 0;
        }

        const string trainMark = "BelTrain";

        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Номер поезда: {trainNumber}");
            Console.WriteLine($"Место отправления: {destination}");
            Console.WriteLine($"Время отправления: {departureTime}");
            Console.WriteLine($"Количество мест: {Seats}");
            Console.WriteLine($"Марка поезда:{trainMark}");
        }
        public override int GetHashCode()
        {
            var hash = 0;
            foreach (char temp in destination)
            {
                hash += Convert.ToInt32(temp);
            }
            return Convert.ToInt32(hash);
        }
        public void ChangeSeats(ref int newSeats)
        {
            if (newSeats <= 0)
            {
                Console.WriteLine("Количество мест должны быть положительным числом.");
            }
            else
            {
                Seats = newSeats;
                Console.WriteLine($"Новое количество мест поезда \"{trainNumber}\": {newSeats}");
            }
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj.GetType() != typeof(Train)) return false;
            Train train = (Train)obj;
            if (train == null) return false;
            return this.trainNumber == train.trainNumber && this.destination == train.destination && this.departureTime == train.departureTime && this.Seats == train.Seats;
        }
        public override string ToString()
        {
            return $"ID: {id}, Номер поезда: {trainNumber}, Место отправления: {destination}, " +
                $"Время отправления: {departureTime}, Количество мест: {Seats}, ";
        }
    }
}