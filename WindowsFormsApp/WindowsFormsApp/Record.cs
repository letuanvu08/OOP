using System;

namespace WindowsFormsApp
{
    internal abstract class Record
    {
        protected DateTime dateTime;
        protected int id;
        protected int idVehicle;
        protected double numberKilometers;

        public int IdVehicle
        {
            get => idVehicle;
            set => id = value;
        }

        public double NumberKilometers
        {
            get => numberKilometers;
            set => numberKilometers = value;
        }

        public static double operator -(Record a, Record b)
        {
            if (a.IdVehicle != b.IdVehicle) throw new InvalidCastException();
            Console.WriteLine("A:" + a.NumberKilometers);
            Console.WriteLine("B:" + b.NumberKilometers);
            return a.numberKilometers - b.numberKilometers;
        }

        public static bool operator >(Record a, Record b)
        {
            if (a.IdVehicle != b.IdVehicle) throw new InvalidCastException();
            return (a.dateTime.Date - b.dateTime.Date).TotalDays > 0;
        }

        public static bool operator <(Record a, Record b)
        {
            if (a.IdVehicle != b.IdVehicle) throw new InvalidCastException();
            return (a.dateTime.Date - b.dateTime.Date).TotalDays < 0;
        }

        public static bool operator >=(Record a, Record b)
        {
            if (a.IdVehicle != b.IdVehicle) throw new InvalidCastException();
            return (a.dateTime.Date - b.dateTime.Date).TotalDays >= 0;
        }

        public static bool operator <=(Record a, Record b)
        {
            if (a.IdVehicle != b.IdVehicle) throw new InvalidCastException();
            return (a.dateTime.Date - b.dateTime.Date).TotalDays <= 0;
        }

        public static bool operator ==(Record a, Record b)
        {
            if (a.IdVehicle != b.IdVehicle) throw new InvalidCastException();
            return (a.dateTime.Date - b.dateTime.Date).TotalDays == 0;
        }

        public static bool operator !=(Record a, Record b)
        {
            if (a.IdVehicle != b.IdVehicle) throw new InvalidCastException();
            return (a.dateTime.Date - b.dateTime.Date).TotalDays != 0;
        }
    }


    internal class EngineRecord : Record
    {
        private string error;
        private int numberOilChange;

        public EngineRecord(int id, DateTime dateTime, double kilometer, int numberOil, string error)
        {
            idVehicle = id;

            this.dateTime = dateTime;
            numberKilometers = kilometer;
            numberOilChange = numberOil;
            this.error = error;
        }
    }

    internal class TransmissionRecord : Record
    {
        private string error;
        private int numberFluidChange;

        public TransmissionRecord(int id, DateTime dateTime, double kilometer, int numberFluid, string error)
        {
            idVehicle = id;

            this.dateTime = dateTime;
            numberKilometers = kilometer;
            numberFluidChange = numberFluid;
            this.error = error;
        }
    }

    internal class TiresRecord : Record
    {
        public TiresRecord(int idVehicle, DateTime dateTime, double kilometer)
        {
            base.idVehicle = idVehicle;

            this.dateTime = dateTime;
            numberKilometers = kilometer;
        }
    }
}