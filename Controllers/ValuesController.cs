//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Net.Http;
//using System.Web.Http;
//using WebApplication16.Models;
//using System.Data;
//using System.Data.SqlClient;
//using System.Configuration;
//namespace WebApplication16.Controllers
//{
//    public class ValuesController : ApiController
//    {
//        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["webapi_conn"].ConnectionString);
//        book bookk = new book();
//        user users = new user();
//        // GET api/values

//        public List<book> Get()
//        {
//            SqlDataAdapter d = new SqlDataAdapter("allbook", con);
//            d.SelectCommand.CommandType = CommandType.StoredProcedure;
//            DataTable dt = new DataTable();
//            d.Fill(dt);
//            List<book> isbook = new List<book>();
//            if (dt.Rows.Count > 0)
//            {
//                for (int i = 0; i < dt.Rows.Count; i++)
//                {
//                    book boook = new book();
//                    boook.bookname = dt.Rows[i]["bookname"].ToString();
//                    boook.bookid = Convert.ToInt32(dt.Rows[i]["bookid"].ToString());
//                    boook.category = dt.Rows[i]["category"].ToString();
//                    boook.shelf = Convert.ToInt32(dt.Rows[i]["shelf"].ToString());
//                    boook.availibilty = Convert.ToInt32(dt.Rows[i]["availibilty"].ToString());
//                    isbook.Add(boook);
//                }
//            }
//            if (isbook.Count > 0)
//            {
//                return (isbook);
//            }
//            else
//            {
//                return null;
//            }
//        }

//        //// GET api/values/5
//        // //   question3



//        //question 4
//       // [HttpGet, Route("{username}")]
//       [System.Web.Http.HttpGet]
//        public user Get(string username)
//        {
//            SqlDataAdapter d = new SqlDataAdapter("fetchuser", con);
//            d.SelectCommand.CommandType = CommandType.StoredProcedure;
//            d.SelectCommand.Parameters.AddWithValue("@username", username);
//            DataTable dt = new DataTable();
//            d.Fill(dt);
//            user user1 = new user();
//            if (dt.Rows.Count > 0)
//            {
//                user1.username = dt.Rows[0]["username"].ToString();
//                user1.userid = Convert.ToInt32(dt.Rows[0]["userid"].ToString());
//                user1.issuelist = dt.Rows[0]["issuelist"].ToString();
//            }
//            if (user1 != null)
//            {
//                return user1;
//            }
//            else
//            {
//                return null;
//            }
//        }
//        // POST api/values
//        //ques1 post a book
//        //public string Post(book bookk)
//        //{
//        //    string msg = "";
//        //    if (bookk != null)
//        //    {
//        //        SqlCommand cmd = new SqlCommand("insertbook", con);
//        //        cmd.CommandType = CommandType.StoredProcedure;
//        //        cmd.Parameters.AddWithValue("@bookname", bookk.bookname);
//        //        cmd.Parameters.AddWithValue("@bookid", bookk.bookid);
//        //        cmd.Parameters.AddWithValue("@category", bookk.category);
//        //        cmd.Parameters.AddWithValue("@shelf", bookk.shelf);
//        //        cmd.Parameters.AddWithValue("@avail", bookk.availibilty);
//        //        con.Open();
//        //        int i = cmd.ExecuteNonQuery();
//        //        con.Close();
//        //        if(i>0)
//        //        {
//        //            msg = "data has been inserted";
//        //        }
//        //        else
//        //        {
//        //            msg="data has not inserted";
//        //        }
//        //    }
//        //    return msg;
//        //}
//        //post for user

//        public string Post(user users)
//        {
//            string msg = "";
//            if (users != null)
//            {
//                SqlCommand cmd = new SqlCommand("listofusers", con);
//                cmd.CommandType = CommandType.StoredProcedure;
//                cmd.Parameters.AddWithValue("@username", users.username);
//                cmd.Parameters.AddWithValue("@userid", users.userid);
//                cmd.Parameters.AddWithValue("@issuelist", users.issuelist);

//                con.Open();
//                var i = cmd.ExecuteNonQuery();
//                con.Close();
//                if (i > 0)
//                {
//                    msg = "user has been inserted";
//                }
//                else
//                {
//                    msg = "user has not inserted";
//                }
//            }
//            return msg;
//        }
//       // PUT api/values/3
//       // update book
        
//        //update user
//        public string Put(int userid )
//        {
//            string msg = "";
//            if (users != null)
//            {
//                SqlCommand cmd = new SqlCommand("updateuser", con);
//                cmd.CommandType = CommandType.StoredProcedure;
//                cmd.Parameters.AddWithValue("@userid", users.userid);
//                cmd.Parameters.AddWithValue("@username", users.username);
                
//                cmd.Parameters.AddWithValue("@issuelist", users.issuelist);
 
//                con.Open();
//                int i = cmd.ExecuteNonQuery();
//                con.Close();
//                if (i > 0)
//                {
//                    msg = "user has been updated";
//                }
//                else
//                {
//                    msg = "user has not beenupdated";
//                }
//            }
//            return msg;
//        }
//        // DELETE api/values/5blic
//        // 
           
//        //ques10
//        public string Put(string bookname)
//        {
//            string msg = "";
//            if (users != null)
//            {
//                SqlCommand cmd = new SqlCommand("returnbook", con);
//                cmd.CommandType = CommandType.StoredProcedure;
                
//                cmd.Parameters.AddWithValue("@bookname",bookname);

//                con.Open();
//                int i = cmd.ExecuteNonQuery();
//                con.Close();
//                if (i > 0)
//                {
//                    msg = "book is returned";
//                }
//                else
//                {
//                    msg = "book not retured";
//                }
//            }
//            return msg;
//        }
//        public string Delete(string bookname)
//        {
//            string msg = "";
//            if (users != null)
//            {
//                SqlCommand cmd = new SqlCommand("deletebook", con);
//                cmd.CommandType = CommandType.StoredProcedure;

//                cmd.Parameters.AddWithValue("@bookname", bookname);

//                con.Open();
//                int i = cmd.ExecuteNonQuery();
//                con.Close();
//                if (i > 0)
//                {
//                    msg = "book is returned";
//                }
//                else
//                {
//                    msg = "book not retured";
//                }
//            }
//            return msg;
//        }
//    }
//}
