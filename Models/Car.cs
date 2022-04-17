using System;

namespace WEBAPI.Controllers
{
    public class Car
    {
        public int carID { get; set; }

        public string chassisNumber { get; set; }

        public string engineNumber { get; set; }

        public string color { get; set; }

        public float price { get; set; }

        public string modelNumber { get; set; }

        public DateTime mfgDate { get; set; }

    }
}