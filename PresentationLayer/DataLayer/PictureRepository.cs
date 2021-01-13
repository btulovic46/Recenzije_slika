using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class PictureRepository
    {
        public List<Picture> GetAllPictures()
        {
            List<Picture> results = new List<Picture>();

            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Picture";

                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Picture p = new Picture();
                    p.Id = sqlDataReader.GetInt32(0);
                    p.Name = sqlDataReader.GetString(1);
                    p.Creator = sqlDataReader.GetString(2);
                    p.Description = sqlDataReader.GetString(3);
                    //long b = sqlDataReader.GetBytes(4, 0, p.Image, 0, Int32.MaxValue);
                    p.AverageGrade = sqlDataReader.GetDecimal(5);
                    p.GalleryId = sqlDataReader.GetInt32(6);


                    results.Add(p);
                }
            }
            return results;
        }
        public int InsertPicture(Picture p)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("INSERT INTO Picture VALUES ('{0}','{1}','{2}','{3}',{4},{5})", p.Name, p.Creator, p.Description,p.Image, p.AverageGrade, p.GalleryId);

                sqlConnection.Open();

                return sqlCommand.ExecuteNonQuery();
            }
        }
        public int UpdatePicture(Picture p)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("UPDATE Picture SET Name = '{0}', Creator = '{1}', Description = '{2}',Image='{3}', AverageGrade = {4}, WHERE Id = '{5}'",
                 p.Name, p.Creator, p.Description,p.Image, p.AverageGrade, p.Id);

                return sqlCommand.ExecuteNonQuery();
            }
        }
        public int DeletePicture(Picture p)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("DELETE FROM Picture WHERE Id = '{0}'", p.Id);

                sqlConnection.Open();

                return sqlCommand.ExecuteNonQuery();
            }
        }
    }
}
