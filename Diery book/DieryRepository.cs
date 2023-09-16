using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;

namespace Diery_book
{
    class DieryRepository : IDierybook
    {
        private string ConnectionString = "Server=DESKTOP-5FTTMPU\\MSSQLSERVER2022;Database=Diery_DB;Trusted_Connection=True;";

        public Image ConvertByteArrayToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }

        public byte[] ConvertImgToBytes(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

                return ms.ToArray();
            }
        }

        public bool Delete(int BookId)
        {
            SqlConnection cn = new SqlConnection(ConnectionString);
            try
            {
                string query = "DELETE FROM Diery_Books WHERE BookId="+BookId;
                SqlCommand cmd = new SqlCommand(query, cn);
                cn.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                cn.Close();
            }

        }


        public bool Edit(int BookId, string Title, string Date, byte[] pic, string Description)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            try
            {
                string query = "UPDATE Diery_Books SET Title=@Title,Date=@date,Img=@pic,Description=@Description WHERE BookId="+BookId;
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Title", Title);
                command.Parameters.AddWithValue("@Date", Date);
                command.Parameters.AddWithValue("@pic", pic);
                command.Parameters.AddWithValue("@Description", Description);
                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public bool Insert(string Title, string Date, byte[] pic, string Description)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            try
            {
                string query = "Insert Into Diery_Books (Title,Date,Img,Description) Values(@Title,@Date,@pic,@Description)";
                SqlCommand command = new SqlCommand(query,connection);
                command.Parameters.AddWithValue("@Title",Title);
                command.Parameters.AddWithValue("@Date", Date);
                command.Parameters.AddWithValue("@pic", pic);
                command.Parameters.AddWithValue("@Description", Description);
                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public bool Insert(string Title, string Date, string Imageurl, string Description)
        {
            throw new NotImplementedException();
        }

        public DataTable SelectAll()
        {
            string query = "Select * From Diery_Books";
            SqlConnection Connection = new SqlConnection(ConnectionString);
            SqlDataAdapter Adapter = new SqlDataAdapter(query,Connection);
            DataTable Data = new DataTable();
            Adapter.Fill(Data);
            return Data;
        }

        public DataTable SelectRow(int BookId)
        {
            string query = "Select * From Diery_Books Where BookId="+BookId;
            SqlConnection Connection = new SqlConnection(ConnectionString);
            SqlDataAdapter Adapter = new SqlDataAdapter(query, Connection);
            DataTable Data = new DataTable();
            Adapter.Fill(Data);
            return Data;
        }
    }
}
