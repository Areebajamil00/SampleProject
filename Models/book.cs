using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication16.Models
{
    public class book
    {
        public string bookname { set; get; }
        public int bookid { set; get; }
        public string category { set; get; }
        public int availibilty { set; get; }
        public int shelf { get; set; }
    }
}