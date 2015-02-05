using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            MySqlConnection conDatabase = new MySqlConnection("Server=csweb;Database=cs414_team1;Uid=team1_cs414;Pwd=CS414t1;");
            string[] words;
            MySqlDataReader myreader;
            MySqlCommand mycommand;
            string insert_query;
            try
            {
                using (StreamReader sr = new StreamReader("DB_Data/student_table_data.txt"))
                {

                    String line;
                    while (true)
                    {
                        conDatabase.Open();
                        line = sr.ReadLine();
                        words = line.Split('$');
                        insert_query = "insert into student VALUES ('" + words[0] + "','" + words[1] + "','" + words[2] + "','" + words[3] + "','" + words[4] + "');";
                        mycommand = new MySqlCommand(insert_query, conDatabase);
                        try 
	                    {	        
		                    myreader = mycommand.ExecuteReader();
	                    }
                        catch (MySqlException)
	                    {
	                    }
                        conDatabase.Close();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
                conDatabase.Close();
            }

            try
            {
                using (StreamReader sr = new StreamReader("DB_Data/teacher_table_data.txt"))
                {

                    String line;
                    while (true)
                    {
                        conDatabase.Open();
                        line = sr.ReadLine();
                        // Console.WriteLine(line);
                        words = line.Split('$');
                        insert_query = "insert into teacher VALUES ('" + words[0] + "','" + words[1] + "','" + words[2] + "','" + words[3] + "','" + words[4] + "');";
                        mycommand = new MySqlCommand(insert_query, conDatabase);
                        try
                        {
                            myreader = mycommand.ExecuteReader();
                        }
                        catch (MySqlException)
                        {
                        }
                        conDatabase.Close();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
                conDatabase.Close();

            }

            try
            {
                using (StreamReader sr = new StreamReader("DB_Data/class_table_data.txt"))
                {

                    String line;
                    while (true)
                    {
                        conDatabase.Open();
                        line = sr.ReadLine();
                        words = line.Split('$');
                        insert_query = "insert into class VALUES ('" + words[0] + "','" + words[1] + "','" + words[2] + "');";
                        mycommand = new MySqlCommand(insert_query, conDatabase);
                        try
                        {
                            myreader = mycommand.ExecuteReader();
                        }
                        catch (MySqlException)
                        {
                        }
                        conDatabase.Close();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
                conDatabase.Close();
            }

            try
            {
                using (StreamReader sr = new StreamReader("DB_Data/enrollment_table_data.txt"))
                {

                    String line;
                    while (true)
                    {
                        conDatabase.Open();
                        line = sr.ReadLine();
                        words = line.Split('$');
                        insert_query = "insert into enrollment VALUES ('" + words[0] + "','" + words[1] + "');";
                        mycommand = new MySqlCommand(insert_query, conDatabase);
                        try
                        {
                            myreader = mycommand.ExecuteReader();
                        }
                        catch (MySqlException)
                        {
                        }
                        conDatabase.Close();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
                conDatabase.Close();
            }
            Console.ReadLine();
        }
    }
}
