using SalonService_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SalonService_API.Controllers
{
    public class SalonServicesController : ApiController
    {
        SalonDBEntities db = new SalonDBEntities();

        [HttpGet]
        [Route("api/Getsalonservices")]
        public IEnumerable<Admin_Select_SalonServices_Result> Get()
        {
            return db.Admin_Select_SalonServices().ToList();
        }

        [HttpPost]
        [Route("api/AddSalonService")]
        public void Addservice(SalonService ser)
        {
            try
            {
                if (ser.ServiceName != null && ser.ServicePrice != null)
                {
                    db.Admin_Insert_SalonServices(ser.ServiceName, ser.ServicePrice);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        [Route("api/UpdateSalonService")]
        public void UpdateService(SalonService ser)
        {
            try
            {
                if (ser.Id > 0)
                {
                    db.Admin_Update_SalonServices(ser.Id, ser.ServiceName, ser.ServicePrice);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        [Route("api/DeleteSalonService")]
        public void DeleteService(SalonService ser)
        {
            try
            {
                if (ser.Id > 0)
                {
                    db.Admin_Delete_SalonServices(ser.Id);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
