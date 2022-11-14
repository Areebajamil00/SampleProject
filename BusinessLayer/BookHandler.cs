using System.Data.SqlClient;
using System.Data;
using WebApplication16.Models;
using SampleProject.DataLayer;

namespace SampleProject.BusinessLayer
{
    public class BookHandler : IBookHandler
    {
        ISQLDataHelper DatabaseHandler;
        public BookHandler(ISQLDataHelper databaseHandler)
        {
            DatabaseHandler = databaseHandler;
        }

        public book GetBook(string name)
        {
            throw new System.NotImplementedException();
        }

        public bool InsertBook(book book)
        {
            return DatabaseHandler.InsertBook(book);
        }

        public bool IssueBook(book issue)
        {
            throw new System.NotImplementedException();
        }

        public bool UpdateBook(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
