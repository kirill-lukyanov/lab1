using System;
using System.Collections.Generic;

namespace Lab9
{
    class Program
    {
        public interface IMobile
        {
            void ChageSensivity(float value);
            void ShowDeviceType();
        }
        public class Computer
        {
            public float power;

            public Computer(float power)
            {
                this.power = power;
            }
            public virtual void ShowSpecification()
            {
                Console.WriteLine("\n>>>>>>>>>>    Компьютер");
                Console.WriteLine($"Power: {power} ГГЦ");
            }
        }
        class Stationary : Computer
        {
            public float SupplyPower;
            public Stationary(float power, float SupplyPower) : base(power)
            {
                this.SupplyPower = SupplyPower;
            }
            public override void ShowSpecification()
            {
                Console.WriteLine("\n>>>>>>>>>>    Стационарный компьютер");
                Console.WriteLine($"Computing Power: {power} ГГц");
                Console.WriteLine($"Supply Power: {SupplyPower} Вт");

            }
        }

        class Mobile : Computer
        {
            public float BatteryCapacity;
            public Mobile(float power, float BatteryCapacity) : base(power)
            {
                this.BatteryCapacity = BatteryCapacity;
            }
            public override void ShowSpecification()
            {
                Console.WriteLine("\n>>>>>>>>>>    Мобильное устройство");
                Console.WriteLine($"Computing Power: {power} ГГц");
                Console.WriteLine($"Battery Capacity: {BatteryCapacity} %");
            }
        }
        class Pad : Mobile, IMobile
        {
            public float SensorSensitivity;
            public Pad(float power, float BatteryCapacity, float SensorSens) : base(power, BatteryCapacity)
            {
                this.SensorSensitivity = SensorSens;
            }

            public void ChageSensivity(float value)
            {
                SensorSensitivity = value;
            }

            public void ShowDeviceType()
            {
                Console.WriteLine("\n>>>>>>>>>>    Планшет");
            }

            public override void ShowSpecification()
            {
                Console.WriteLine($"Computing Power: {power} ГГц");
                Console.WriteLine($"Battery Capacity: {BatteryCapacity} %");
                Console.WriteLine($"Sensor Sensitivity: {SensorSensitivity}");
            }
        }
        class NoteBook : Mobile, IMobile
        {
            public float TouchpadSensitivity;

            public NoteBook(float power, float BatteryCapacity, float TouchpadSensitivity) : base(power, BatteryCapacity)
            {
                this.TouchpadSensitivity = TouchpadSensitivity;

            }

            public void ChageSensivity(float value)
            {
                TouchpadSensitivity = value;
            }

            public void ShowDeviceType()
            {
                Console.WriteLine("\n>>>>>>>>>>    Ноутбук");
            }

            public override void ShowSpecification()
            {
                Console.WriteLine($"Computing Power: {power} ГГц");
                Console.WriteLine($"Battery Capacity: {BatteryCapacity} %");
                Console.WriteLine($"Touchpad Sensitivity: {TouchpadSensitivity}");
            }
        }
        static void Main(string[] args)
        {
            /*
            var Computers = new List<Computer>();
            Computers.Add(new Computer(3.0f));
            Computers.Add(new Stationary(2.2f, 17000));
            Computers.Add(new Mobile(2.2f, 20000));
            Computers.Add(new Pad(1.1f, 57, 0.2f));
            Computers.Add(new NoteBook(2.3f, 100, 0.7f));
            
            foreach (Computer comp in Computers)
            {
                comp.ShowSpecification();
            }*/

            Pad pad = new Pad(1.1f, 57, 0.2f);
            pad.ChageSensivity(0.5f);
            pad.ShowDeviceType();
            pad.ShowSpecification();

            NoteBook noteBook = new  NoteBook(2.3f, 100, 0.7f);
            noteBook.ChageSensivity(0.8f);
            noteBook.ShowDeviceType();
            noteBook.ShowSpecification();

            Console.ReadKey();
        }
    }
}
