using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication16.Models;

namespace SampleProject.BusinessLayer
{
    public interface IBookHandler
    {
        public bool InsertBook(book book);
        public book GetBook(string name);

        public bool UpdateBook(int id);
        public bool IssueBook(book issue);
    }
}
