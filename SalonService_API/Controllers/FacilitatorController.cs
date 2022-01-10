using SalonService_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SalonService_API.Controllers
{
    public class FacilitatorController : ApiController
    {
        SalonDBEntities db = new SalonDBEntities();
        // GET: api/Facilitator
        [Route("api/GetFacilator")]
        public IEnumerable<Admin_Select_SalonFacilitator_Result> Get()
        {
            return db.Admin_Select_SalonFacilitator().ToList();
        }

        // GET: api/Facilitator/5
        public string Get(int id)
        {
            return "value";
        }

        [Route("api/AddFacilitator")]
        // POST: api/Facilitator
        public void Post(SalonFacilitator fac)
        {
            try
            {
                if (fac.FacilitatorName != null && fac.Salary > 0)
                {
                    db.Admin_Insert_SalonFacilitator(fac.FacilitatorName, fac.Salary);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        
        [HttpPost]
        [Route("api/UpdateFacilitator")]
        public void UpdateFacilitator(SalonFacilitator fac)
        {
            try
            {
                if (fac.Id > 0)
                {
                    db.Admin_Update_SalonFacilitator(fac.Id, fac.FacilitatorName, fac.Salary);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        [Route("api/DeleteFacilitator")]
        public void DeleteFacilitator(SalonFacilitator fac)
        {
            try
            {
                if (fac.Id > 0) 
                {
                    db.Admin_Delete_SalonFacilitator(fac.Id);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        // PUT: api/Facilitator/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Facilitator/5
        public void Delete(int id)
        {
        }
    }
}
