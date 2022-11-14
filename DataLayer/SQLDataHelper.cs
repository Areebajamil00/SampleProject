using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Microsoft.Extensions.Configuration;
using SampleProject.Models;

namespace SampleProject.DataLayer
{
    public class SQLDataHelper : ISQLDataHelper
    {
        //Please add server, db, user and password below
        string connectionString = "server=CMDLHRLTH60\\SQLEXPRESS;database=mvc ; Integrated Security = true;";
        public SQLDataHelper(IConfiguration config)
        {
            var c = config;
            connectionString = config.GetConnectionString("ProjectDB");
        }
        public List<Country> GetCountriesData()
        {
            List<Country> lstCountry = new List<Country>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_GetCountries", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    Country Country = new Country();

                    Country.Id = Convert.ToInt32(sdr["Id"]);
                    Country.CountryName = sdr["CountryName"].ToString();
                    Country.CurrencyCode = sdr["CurrencyCode"].ToString();
                    Country.PenaltyAmount = Convert.ToDecimal(sdr["PenaltyAmount"].ToString());
                    Country.OffDay1 = sdr["OffDay1"].ToString();
                    Country.OffDay2 = sdr["OffDay2"].ToString();
                    lstCountry.Add(Country);
                }
                con.Close();
            }
            return lstCountry;
        }
        public List<SpecialDay> GetSpecialDaysData()
        {
            List<SpecialDay> lstSpecialDay = new List<SpecialDay>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_GetCountriesSpecialDays", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    SpecialDay specialDay = new SpecialDay();

                    specialDay.Id = Convert.ToInt32(sdr["Id"]);
                    specialDay.CountryId = Convert.ToInt32(sdr["CountryId"].ToString());
                    specialDay.SpecialDate = Convert.ToDateTime(sdr["SpecialDate"].ToString());
                    lstSpecialDay.Add(specialDay);
                }
                con.Close();
            }
            return lstSpecialDay;
        }
    }
}