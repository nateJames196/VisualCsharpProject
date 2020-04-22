using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MortgageRateCalculator {
    class MortgageCalculation {
        private UserInformation userInfo;

        public MortgageCalculation(UserInformation info) {
            this.userInfo = info;
            updateDatabase();
        }

        private void updateDatabase() //this function sends all of the user data and the newly calculated mortgage over to the database
        {
            MySqlConnection conn;//create a connection variable
            MySqlCommand cmd;//creates a mySqlCommand variable

            MySqlConnectionStringBuilder connectionString = new MySqlConnectionStringBuilder();//this creates a connection string but a way easier to understand version
            connectionString.Server = "192.168.1.133";//this is temporary we will change it to local host. I am just hitting my server that i created at home on my spare laptop
            connectionString.UserID = "Nelsonthegr8";//this is the userName of my created MySql database server 
            connectionString.Password = "Hellopass13";//this is the password of my created MySql database server
            connectionString.Database = "c#_group_project";//this is the database name of my created MySql database server
            //this is the insert into query turned into a string so that i can pass in the variables from the userInfo class that we created
            string query = "INSERT INTO `UserInformation` (`creditScore`, `amountOfLoan`, `lengthOfLoan`, `income`) " +
                "VALUES('" + userInfo.creditScore + "', '" + "$ " + Math.Round(userInfo.amountOfLoan, 2) + "', '" + userInfo.lengthOfLoan
                + " Years" + "', '" + userInfo.income + "')";

            string log = "INSERT INTO `Log` (`Date`, `Time`, `Command`) " +
                "VALUES('" + DateTime.Now.ToShortDateString() + "', '" + DateTime.Now.ToShortTimeString() + "', '" +"Completed a push to the database. and stored these values:" 
                + userInfo.creditScore +", " + Math.Round(userInfo.amountOfLoan, 1, MidpointRounding.AwayFromZero) + ", " + userInfo.lengthOfLoan + " Years" + ", " + userInfo.income + "')";//log what was submitted
           
            try//we cover everything into a try catch just in case
            {
                conn = new MySqlConnection();//this creates a new instance of the MySqlConnection
                conn.ConnectionString = connectionString.ToString();//this takes our premade connection strind and adds it to the MySqlconnection
                cmd = new MySqlCommand(query, conn);//this creates the new command by appending the query string we created and the MySqlconnection
                conn.Open();//we open the connection
                cmd.ExecuteNonQuery();//we run the command
                //run second command for logging
                cmd = new MySqlCommand(log,conn);
                cmd.ExecuteNonQuery();
                conn.Close();//we close the connection
            } catch (MySql.Data.MySqlClient.MySqlException ex) {
                Console.WriteLine(ex.Message);
            }

        }

    }
}
