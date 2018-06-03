using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Web.Http;

namespace wetubeAPI.Controllers
{
    public class UserController : ApiController
    {
        SqlConnection conn;
        SqlCommand cmd = new SqlCommand();

        public IHttpActionResult PostNewUser(Models.User user)
        {
            //Validate later
            /*if (!ModelState.IsValid)
                return BadRequest("Invalid data.");*/

            conn = new DBConnectionManager().OpenConnection();
           
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO T_USER(userID, avatarName, dateOfBirth) " + 
                                    "Values(@param1,@param2,@param3)";
            cmd.Parameters.AddWithValue("@param1", user.UserID);
            cmd.Parameters.AddWithValue("@param2", user.AvatarName);
            cmd.Parameters.AddWithValue("@param3", user.DateOfBirth);

            cmd.ExecuteNonQuery();

            //for test only
            //TestPostData();

            conn.Close();
            return Ok();           
        }

        private void TestPostData()
        {
            cmd = new SqlCommand("SELECT * FROM T_USER", conn);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                Console.WriteLine(read["userID"].ToString(), read["avatarName"].ToString(), read["dateOfBirth"].ToString());
            }
        }
    }
}
