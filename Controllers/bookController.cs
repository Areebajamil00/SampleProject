using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication16.Models;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace WebApplication16.Controllers
{
    public class bookController : ApiController
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["webapi_conn"].ConnectionString);
        book bookk = new book();
        user users = new user();
        // GET api/values

        //public List<book> Get()
        //{
        //    SqlDataAdapter d = new SqlDataAdapter("", con);
        //    d.SelectCommand.CommandType = CommandType.StoredProcedure;
        //    DataTable dt = new DataTable();
        //    d.Fill(dt);
        //    List<book> isbook = new List<book>();
        //    if (dt.Rows.Count > 0)
        //    {
        //        for (int i = 0; i < dt.Rows.Count; i++)
        //        {
        //            book boook = new book();
        //            boook.bookname = dt.Rows[i]["bookname"].ToString();
        //            boook.bookid = Convert.ToInt32(dt.Rows[i]["bookid"].ToString());
        //            boook.category = dt.Rows[i]["bookname"].ToString();
        //            boook.shelf = Convert.ToInt32(dt.Rows[i]["bookname"].ToString());
        //            boook.availibilty = Convert.ToInt32(dt.Rows[i]["bookname"].ToString());
        //            isbook.Add(boook);
        //        }
        //    }
        //    if (isbook.Count > 0)
        //    {
        //        return (isbook);
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}

        // GET api/values/5
        //   question3

        // [Route("api/controller")]
       // [System.Web.Http.HttpGet]
        [HttpGet,Route("{booknamee}")]
        public book Get(string booknamee)
        {
            SqlDataAdapter d = new SqlDataAdapter("fetchbook", con);
            d.SelectCommand.CommandType = CommandType.StoredProcedure;
            d.SelectCommand.Parameters.AddWithValue("@bookname", booknamee);
            DataTable dt = new DataTable();
            d.Fill(dt);
            book boook = new book();
            if (dt.Rows.Count > 0)
            {
                boook.bookname = dt.Rows[0]["bookname"].ToString();
                boook.bookid = Convert.ToInt32(dt.Rows[0]["bookid"].ToString());
                boook.category = dt.Rows[0]["category"].ToString();
                boook.shelf = Convert.ToInt32(dt.Rows[0]["shelf"].ToString());
                boook.availibilty = Convert.ToInt32(dt.Rows[0]["availibilty"].ToString());
            }
            if (boook != null && boook.availibilty==-1)
            {
                // -1 means book is avaialable 
                return boook;
            }
            else
            {
                return null;
            }
        }

        public string Post(book bookk)
        {
            string msg = "";
            if (bookk != null)
            {
                SqlCommand cmd = new SqlCommand("insertbook", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@bookname", bookk.bookname);
                cmd.Parameters.AddWithValue("@bookid", bookk.bookid);
                cmd.Parameters.AddWithValue("@category", bookk.category);
                cmd.Parameters.AddWithValue("@shelf", bookk.shelf);
                cmd.Parameters.AddWithValue("@avail", bookk.availibilty);
                con.Open();
                int i = cmd.ExecuteNonQuery();
                con.Close();
                if (i > 0)
                {
                    msg = "data has been inserted";
                }
                else
                {
                    msg = "data has not inserted";
                }
            }
            return msg;
        }

        public string Put(int id)
        {
            string msg = "";
            if (bookk != null)
            {
                SqlCommand cmd = new SqlCommand("updatebook", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@bookname", bookk.bookname);
                cmd.Parameters.AddWithValue("@bookid",id);
                cmd.Parameters.AddWithValue("@category", bookk.category);
                cmd.Parameters.AddWithValue("@shelf", bookk.shelf);
                cmd.Parameters.AddWithValue("@avail", bookk.availibilty);
                con.Open();
                int i = cmd.ExecuteNonQuery();
                con.Close();
                if (i > 0)
                {
                    msg = "data has been updated";
                }
                else
                {
                    msg = "data has not beenupdated";
                }
            }
            return msg;
        }
    }
}
