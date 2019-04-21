using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SelcukOgrenciKontrol.Models.Home
{
    public class Loglar
    {
        public Loglar(){
            logList = new List<Log>();
        }
        public List<Log> logList { get; set; }
        public int logSayisi;
        public int sayfaSayisi;
        public int activePageNumber;
    }
}