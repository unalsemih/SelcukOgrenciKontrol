using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SelcukOgrenciKontrol.Models.Home
{
    public class Sorgulama
    {

        public DateTime baslangicTarih = new DateTime(2018,12,15);
        public DateTime bitisTarih = DateTime.Today;

        public string numara="0";
        public string ad="";
        public string soyad = "";
        public List<SelectListItem> fakulteler { get; set; }
        public List<SelectListItem> bloklar { get; set; }
        public int sayfaSayisi;
    }
}