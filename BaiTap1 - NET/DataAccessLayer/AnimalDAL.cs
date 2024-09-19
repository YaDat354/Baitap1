using BaiTap1___NET.DataAccessLayer.DataClass;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1___NET.DataAccessLayer
{
    public class AnimalDAL
    {
        private string connectionString = "Data Source=LAPTOP-1ME411UJ\\MSSQLSERVER01;Initial Catalog=AnimalDB;Integrated Security=True";

        public List<Animal> GetAllAnimals()
        {
            List<Animal> animals = new List<Animal>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM ANIMALS";
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Animal animal;
                    switch (reader["ANIMALTYPE"].ToString())
                    {
                        case "Cow":
                            animal = new Cow();
                            break;
                        case "Sheep":
                            animal = new Sheep();
                            break;
                        case "Goat":
                            animal = new Goat();
                            break;
                        default:
                            animal = new Animal();
                            break;
                    }
                    animal.AnimalID = (int)reader["ANIMALID"];
                    animal.AnimalType = reader["ANIMALTYPE"].ToString();
                    animal.Sound = reader["SOUND"].ToString();
                    animals.Add(animal);
                    Debug.WriteLine(animal.AnimalType);
                }
            }
            return animals;
        }

    }
}
