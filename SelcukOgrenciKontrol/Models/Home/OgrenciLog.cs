using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using Newtonsoft.Json;

namespace SelcukOgrenciKontrol.Models.Home
{
    public class OgrenciLog
    {


        public void logGetir()
        {
            string url = "https://jsonplaceholder.typicode.com/posts";
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;

        }
    }

    class Ogrenci{



    }

    

}