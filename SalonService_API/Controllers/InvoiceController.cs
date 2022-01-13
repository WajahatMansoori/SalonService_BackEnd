using SalonService_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SalonService_API.Controllers
{
    public class InvoiceController : ApiController
    {
        SalonDBEntities db = new SalonDBEntities();

        [HttpGet]
        [Route("api/GetallInvoices")]
        public IEnumerable<Admin_Select_Invoices_Result> GetAllInvoices()
        {
            return db.Admin_Select_Invoices();
        }

        [HttpPost]
        [Route("api/InsertInvoice")]
        public bool AddInvoice(Invoice iv)
        {
            try
            {
                if (iv.SalonProductsId > 0 && iv.InvoiceAmount > 0 && iv.InvoiceDate != null && iv.ProductQuantity > 0)
                {
                    db.Admin_Insert_Invoices(iv.SalonProductsId, iv.InvoiceAmount, iv.InvoiceDate, iv.ProductQuantity);
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
