using Microsoft.Data.SqlClient;
using MovieNomination___ASP.Net.Models;

namespace MovieNomination___ASP.Net.Services
{
    public class GETLIST
    {
        const string connectionString = @"Data Source=172.21.187.182, 1433;
                                            Initial Catalog=MovieNomination;
                                            User ID=WPFLogin;Password=Passw0rd;
                                            encrypt=false;";
        public List<MoviesModel> GetData()
        {
            List<MoviesModel> returnList = new();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand cmd = new("SELECT * FROM MOVIE", connection);

                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        MoviesModel data = new();


                        data.movieTitle = dr.GetString(1);
                        data.directorName = dr.GetString(2);
                        data.releaseDate = dr.GetDateTime(3);
                        data.rating = dr.GetInt32(4);


                        returnList.Add(data);
                    }


                    return returnList;
                }
            }
            catch (Exception ex)
            {

            }
            return null;
        }
    }
}
