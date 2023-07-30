using System;

namespace ClassesAndObjectExample
{
    class Sensor
    {
        private float temperature; // in Celsius    
        private double relative_humidity; // Write Read and Write methods
        private int CO2_conc; // Write Read and Write methods
        private string model_id; // Write Read and Write methods

        // Method to read the temperature of the object
        public float Read_temperature()
        {
            return temperature;
        }

        // Method to change the temperature of the object
        public void Change_temperature(float temp_val)
        {
            temperature = temp_val;
        }
        // Please note that this is a Default constructor
        public Sensor()
        {
            temperature = -999;

        }
    }

    class PLC
    {
        static void Main(string[] args)
        {
            // Object of type Sensor class
            Sensor object_1 = new Sensor();
            Console.WriteLine(object_1.ToString());
            float temp = object_1.Read_temperature();
            Console.WriteLine("Temp is = {0} degrees", temp);
            object_1.Change_temperature(45);
            temp = object_1.Read_temperature();
            Console.WriteLine("Temp is = {0} degrees", temp);
            // Object of type PLC class
            PLC obj_plc = new PLC();
            Console.WriteLine(obj_plc.ToString());


            Console.ReadKey();
        }
    }

}
