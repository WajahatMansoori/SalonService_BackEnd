using SalonService_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SalonService_API.Controllers
{
    public class AppointmentController : ApiController
    {
        SalonDBEntities db = new SalonDBEntities();

        [HttpGet]
        [Route("api/GetAppointmentlist")]
        public IEnumerable<Admin_Select_SolonAppointment_Result> GetAppointmentlist()
        {
            try
            {
                return db.Admin_Select_SolonAppointment().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //[HttpGet]
        //[Route("api/GetServedAppointmentlist")]
        //public List<SolonAppointment> GetAppointmentlist()
        //{
        //    try
        //    {
        //        var GetBookedAppointmentList = db.SolonAppointments.Where(x => x.IsServed == false).ToList();
        //        return GetBookedAppointmentList;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }

        //}

        [HttpPost]
        [Route("api/InsertAppointment")]
        public bool BookAppointment(SolonAppointment ap)
        {
            try
            {
                //List<SolonAppointment> appointments = new List<SolonAppointment>();
                //string clientname = string.Empty;
                //string clientPhone = string.Empty;
                //int ServiceId = 0;
                //int facilitatorId = 0;
                //string Service_Id_List = string.Empty;
                //DateTime AppointmentDate=DateTime.Now;           
                //foreach (var item in ap)
                //{
                //    if (item.ClientName != null)
                //    {
                //        clientname = item.ClientName;
                //    }
                //    if (item.ClientPhone != null)
                //    {
                //        clientPhone = item.ClientPhone;
                //    }                
                //    if (item.AppointDate != null)
                //    {
                //        AppointmentDate = item.AppointDate.Value;
                //    }
                //    if (item.SalonFacilitatorId > 0)
                //    {
                //        facilitatorId = item.SalonFacilitatorId.Value;
                //    }
                //    if (item.SalonServicesId > 0)
                //    {
                //        ServiceId = item.SalonServicesId.Value;
                //    }
                //    appointments.Add(item);

                //}

                //foreach (var item in appointments)
                //{                    
                //    IList<string> serviceList = new List<string> { item.SalonServicesId.ToString() };
                //    Service_Id_List = string.Join(",", serviceList);                                        
                //}
                //db.Admin_Insert_SolonAppointment(clientname, clientPhone, Service_Id_List, facilitatorId, AppointmentDate);
                if (ap.ClientName != null && ap.ClientPhone != null && ap.AppointDate != null && ap.SalonFacilitatorId > 0 && ap.SalonServicesId > 0 && ap.SlotTime != null) 
                {
                    db.Admin_Insert_SolonAppointment(ap.ClientName, ap.ClientPhone, ap.SalonServicesId.ToString(), ap.SalonFacilitatorId, ap.AppointDate,ap.SlotTime);
                }
                
                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        [Route("api/GetAvailablefacilitator")]
        public List<SalonFacilitator> GetAavailabelFacilitator()
        {
            var Getlist = db.SalonFacilitators.Where(x => x.IsBooked == false).ToList();
            return Getlist;
        }

        [HttpPost]
       // [Route("api/MarkasServed")]
        public bool MarkAsServed(int FacId)
        {
            try
            {
                if (FacId > 0)
                {
                    db.Admin_Update_ClientServiceServed(FacId);
                }
                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        [Route("api/MarkasServed")]
        public bool GetFacId(string facName)
        {
            try
            {
                var data = db.SalonFacilitators.Where(x => x.FacilitatorName == facName).FirstOrDefault();
                if (data != null)
                {
                    MarkAsServed(data.Id);
                }
                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }

        [HttpGet]
        [Route("api/GetServedAppointList")]
        public List<SolonAppointment> GetServedAppointList()
        {
            var data = db.SolonAppointments.Where(x => x.IsServed == true).ToList();
            return data;
        }
    }
}
