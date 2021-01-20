﻿using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ReviewerRepository
    {
        public List<Reviewer> GetAllReviewers()
        {
            List<Reviewer> results = new List<Reviewer>();

            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Reviewer";

                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Reviewer r = new Reviewer();
                    r.Id = sqlDataReader.GetInt32(0);
                    r.Name = sqlDataReader.GetString(1);
                    r.LastName = sqlDataReader.GetString(2);
                    r.Email = sqlDataReader.GetString(3);
                    r.Password = sqlDataReader.GetString(4);
                    r.Adress = sqlDataReader.GetString(5);
                    r.City = sqlDataReader.GetString(6);
                    r.PhoneNumber = sqlDataReader.GetString(7);

                    results.Add(r);
                }
            }
            return results;
        }
        public int InsertReviewer(Reviewer r)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("INSERT INTO Reviewer VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", r.Name, r.LastName, r.Email,r.Password, r.Adress, r.City, r.PhoneNumber);

                sqlConnection.Open();

                return sqlCommand.ExecuteNonQuery();
            }
        }
        public int UpdateReviewer(Reviewer r)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("UPDATE Reviewer SET Name = '{0}', LastName = '{1}', Email = '{2}',Adress = '{3}',City='{4}',PhoneNumber={5} WHERE Id = '{6}'",
                 r.Name, r.LastName, r.Email, r.Adress, r.City, r.PhoneNumber, r.Id);

                sqlConnection.Open();

                return sqlCommand.ExecuteNonQuery();
            }
        }
        public int DeleteReviewer(Reviewer r)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("DELETE FROM Reviewer WHERE Id = '{0}'", r.Id);

                sqlConnection.Open();

                return sqlCommand.ExecuteNonQuery();
            }
        }
    }
}
