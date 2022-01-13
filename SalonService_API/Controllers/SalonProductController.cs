using SalonService_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SalonService_API.Controllers
{
    public class SalonProductController : ApiController
    {
        SalonDBEntities db = new SalonDBEntities();

        [HttpGet]
        [Route("api/GetSalonProduct")]
        public IEnumerable<Admin_Select_SolonProduct_Result> GetSalonProduct()
        {
            return db.Admin_Select_SolonProduct().ToList();
        }

        [HttpPost]
        [Route("api/AddSalonProduct")]
        public bool AddSalonProduct(SalonProduct product)
        {
            try
            {
                if (product.ProductName != null)
                {
                    db.Admin_Insert_SlonProduct(product.ProductName);
                }
                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        [Route("api/UpdateSalonProduct")]
        public bool UpdateSalonProduct(SalonProduct product)
        {
            try
            {
                if (product.Id > 0)
                {
                    db.Admin_Update_SlonProduct(product.Id, product.ProductName);
                }
                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        [Route("api/DeleteSalonProduct")]
        public bool DeleteSalonProduct(SalonProduct product)
        {
            try
            {
                if (product.Id > 0)
                {
                    db.Admin_Delete_SolonProduct(product.Id);
                }
                return true;                   
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
