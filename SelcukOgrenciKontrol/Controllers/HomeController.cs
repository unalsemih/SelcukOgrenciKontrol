using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SelcukOgrenciKontrol.Models.Home;
namespace SelcukOgrenciKontrol.Controllers
{
    public class HomeController : Controller
    {
        static List<Log> allData;
        // GET: Home
        [HttpGet]
        public ActionResult Index(int id = 1)
        {
            HomePage homeInfo = new HomePage();
            Loglar loglar = new Loglar();
            if (id == 1)
            {
            HttpWebRequest request = WebRequest.Create("http://localhost/denemeJson.json") as HttpWebRequest;
            string jsonVerisi = "";
            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                //jsonVerisi adlı değişkene elde ettiği veriyi atıyoruz.
                jsonVerisi = reader.ReadToEnd();
            }
                allData = JsonConvert.DeserializeObject<List<Log>>(jsonVerisi);
                allData.Add(allData[25]);
             
            }
            loglar.activePageNumber = id;
            loglar.logSayisi = allData.Count;
            System.Diagnostics.Debug.WriteLine("All Data : " + allData.Count);

            //     System.Diagnostics.Debug.WriteLine("" + loglar.logList[0].Tarih);
            loglar.logList.Clear();
            for (int i = (id-1)*10; i < (id-1)*10+10 && i < allData.Count; i++)
                loglar.logList.Add(allData[i]);

            loglar.sayfaSayisi = allData.Count / 10+1;
            Sorgulama sorgu = new Sorgulama();
    
            /* Fakülte Bİlgisi Doldurma Şimdilik  */
            var list = new List<SelectListItem>();
            SelectListItem item1 = new SelectListItem()
            {
                Text = "Tüm Fakülteler",
                Value = "0"
            };
            SelectListItem item2 = new SelectListItem()
            {
                Text = "Teknoloji Fakültesi",
                Value = "1"
            };
            SelectListItem item3 = new SelectListItem()
            {
                Text = "Mühendislik Fakültesi",
                Value = "2"
            };
            SelectListItem item4 = new SelectListItem()
            {
                Text = "Fen-Edebiyat Fakültesi",
                Value = "3"
            };
            list.Add(item1);
            list.Add(item2);
            list.Add(item3);
            list.Add(item4);
            /* Blok Bilgisi Doldurma Şİmdilik */
            var blokList = new List<SelectListItem>();
            SelectListItem blok1 = new SelectListItem()
            {
                Text = "Tüm Bloklar",
                Value = "0"
            };
            SelectListItem blok2 = new SelectListItem()
            {
                Text = "Blok-1",
                Value = "1"
            };
            SelectListItem blok3 = new SelectListItem()
            {
                Text = "Blok-2",
                Value = "2"
            };
            SelectListItem blok4 = new SelectListItem()
            {
                Text = "Blok-3",
                Value = "3"
            };
            blokList.Add(blok1);
            blokList.Add(blok2);
            blokList.Add(blok3);
            blokList.Add(blok4);
            sorgu.fakulteler = list.ToList();
            sorgu.bloklar = blokList;
            ViewBag.fakulteleri = list;
            //            BugunCikis bugun = new BugunCikis();
            //            bugun.tarih = DateTime.Today;


            homeInfo.logBilgileri = loglar;
            homeInfo.sorguBilgileri = sorgu;
            return View(homeInfo);
        }

     

    }
}