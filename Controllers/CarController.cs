using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WEBAPI.Controllers
{
    public class CarController : ApiController
    {
        private static List<Car> Cars = new List<Car>();

        public CarController()
            {
                if(Cars.Count <=0)
                {
                Cars.Add(new Car
                {
                    carID = 101,
                    chassisNumber = "ABC123",
                    engineNumber = "PQR456",
                    color = "Red",
                    price = 10_00_000f,
                    modelNumber ="Seltos", 
                    mfgDate= DateTime.Now

                });
                Cars.Add(new Car
                {
                    carID = 102,
                    chassisNumber = "ABC1234",
                    engineNumber = "PQR4567",
                    color = "Black",
                    price = 12_00_000f,
                    modelNumber = "Carens",
                    mfgDate = DateTime.Now

                });


            }
            }
        // GET: api/Car
        public IEnumerable<Car> Get()
        {
            return Cars.ToList();
        }

        // GET: api/Car/5
        public Car Get(int id)
        {
            return Cars.SingleOrDefault(c=>c.carID==id);
        }

        // (Insert)POST: api/Car
        public void Post([FromBody]Car newCar)
        {
            Car CarToAdd = new Car();
            CarToAdd.carID = newCar.carID;
            CarToAdd.chassisNumber = newCar.chassisNumber;
            CarToAdd.engineNumber = newCar.engineNumber;
            CarToAdd.color = newCar.color;
            CarToAdd.price = newCar.price;
            CarToAdd.modelNumber = newCar.modelNumber;
            CarToAdd.mfgDate = newCar.mfgDate;

            Cars.Add(CarToAdd);

        }

        // PUT: api/Car/5
        public void Put(int id, [FromBody]Car updatedCar)
        {
            Car carToUpdate = Get(id);
            carToUpdate.chassisNumber = updatedCar.chassisNumber;
            carToUpdate.engineNumber = updatedCar.engineNumber;
            carToUpdate.color = updatedCar.color;
            carToUpdate.price = updatedCar.price;
            carToUpdate.modelNumber = updatedCar.modelNumber;

          
        }

        // DELETE: api/Car/5
        public void Delete(int id)
        {
            Cars.Remove(Get(id));
        }
    }
}
