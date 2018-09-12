using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Casino;
using Casino.BlackJack;
using System.Data.SqlClient;
using System.Data;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            const string casinoName = "Erics Casino";

            Guid identifier = Guid.NewGuid();


            // Constructor Chaining Demo
            Player newPlayer = new Player("Eric");

            // Welcome and get player name and bank
            Console.WriteLine("Welcome to the {0}! Please enter your name", casinoName);
            string playerName = Console.ReadLine();

            // if admin query exceptions
            if (playerName.ToLower() == "admin")
            {
                List<ExceptionEntity> Exceptions = ReadExceptions();
                foreach (var exception in Exceptions)
                {
                    Console.Write(exception.Id + " | ");
                    Console.Write(exception.ExceptionType + " | ");
                    Console.Write(exception.ExceptionMessage + " | ");
                    Console.Write(exception.TimeStamp + " | ");
                    Console.WriteLine();
                }
                Console.ReadLine();
            }


            int bank = 0;
            bool validAnswer = false;
            while (!validAnswer)
            {
                Console.WriteLine("How much money did you bring today?: ");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer) Console.WriteLine("Pleas only enter digits");
            }


            Console.WriteLine("Hello {0}, whould you like to play Black Jack", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "y" || answer == "yes")
            {
                // Initalize Player and Game, enter game loop.  
                Player player = new Player(playerName, bank);
                // Log A GUID for player
                player.Id = Guid.NewGuid();
                Game game = new BlackJackGame();
                using (StreamWriter file = new StreamWriter(@"..\..\logs\cards_dealt.txt", true))
                {
                    file.WriteLine(player.Id);
                }


                game += player; // operator overload, add player to "Game.Players" list
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0) // wants to play and has money
                {
                    try
                    {
                        game.Play(); // Main Game Loop, represents one hand
                    }
                    catch (FraudException ex)
                    {
                        Console.WriteLine("SECURITY, KICK THIS PERSON OUT!!!");
                        UpdateDBWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine("An argument was entered incorrectly");
                        UpdateDBWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("ERROR ERROR ERROR ERROR ERROR");
                        UpdateDBWithException(ex);
                        Console.ReadLine();
                        return;
                    }

                }
                game -= player; // operator overload, remove player from game object
                Console.WriteLine("Thank you for playing!");
            }

            Console.WriteLine("Feel free to look around the casino, have a nice day");

            // Hold
            Console.Read();
        }

        private static void UpdateDBWithException(Exception ex)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BlackJackGame;
                                        Integrated Security=True;Connect Timeout=30;Encrypt=False;
                                        TrustServerCertificate=False;ApplicationIntent=ReadWrite;
                                        MultiSubnetFailover=False";
            string queryString = @"INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp) VALUES" +
                " (@ExceptionType, @ExceptionMessage, @TimeStamp)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@ExceptionType", SqlDbType.VarChar);
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp", SqlDbType.DateTime);

                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString();
                command.Parameters["@ExceptionMessage"].Value = ex.Message;
                command.Parameters["@TimeStamp"].Value = DateTime.Now;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();





            }
        }

        private static List<ExceptionEntity> ReadExceptions()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BlackJackGame;
                                        Integrated Security=True;Connect Timeout=30;Encrypt=False;
                                        TrustServerCertificate=False;ApplicationIntent=ReadWrite;
                                        MultiSubnetFailover=False";
            string queryString = @"Select Id, ExceptionType, ExceptionMessage, TimeStamp From Exceptions";

            List<ExceptionEntity> Exceptions = new List<ExceptionEntity>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ExceptionEntity exception = new ExceptionEntity();
                    exception.Id = Convert.ToInt32(reader["Id"]);
                    exception.ExceptionType = reader["ExceptionType"].ToString();
                    exception.ExceptionMessage = reader["ExceptionMessage"].ToString();
                    exception.TimeStamp = Convert.ToDateTime(reader["TimeStamp"]);
                    Exceptions.Add(exception);
                }
                connection.Close();
            }
            return Exceptions;

        }
    }
}
