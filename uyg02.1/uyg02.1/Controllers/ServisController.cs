using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using uyg02._1.Models;
using uyg02._1.ViewModel;

namespace uyg02._1.Controllers
{
    public class ServisController : ApiController
    {
        DB01Entities db = new DB01Entities();


        [HttpGet]
        [Route("api/ogrenciliste")]

        public  List<OgrenciModel> OgrenciListe()
        {
            List<OgrenciModel> liste = db.Ogrenci.Select(x => new OgrenciModel()
            {
                ogrId = x.ogrId,
                ogrNo = x.ogrNo,
                ogrAdsoyad = x.ogrAdsoyad,
                ogrMail = x.ogrMail,
                ogrYas = x.ogrYas
            }).ToList();
   
            return liste;
        }


        [HttpGet]
        [Route("api/ogrencibyid/{ogrId}")]
        public OgrenciModel OgrenciById(int ogrId)
        {
            OgrenciModel kayit = db.Ogrenci.Where(s => s.ogrId == ogrId).Select
                (x => new OgrenciModel()
                {
                    ogrId = x.ogrId,
                    ogrNo = x.ogrNo,
                    ogrAdsoyad = x.ogrAdsoyad,
                    ogrMail = x.ogrMail,
                    ogrYas = x.ogrYas
                }).SingleOrDefault();

            return kayit;
        }
        public BadImageFormatException;
    }
}
