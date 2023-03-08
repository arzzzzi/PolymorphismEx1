using PolymorphismEx1;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString;
            string instruction;

            while (true)
            {
                switch (Menu())
                {
                    case 1:
                        Console.Write("Please enter connection string for SQL DB: ");
                        connectionString = Console.ReadLine();
                        Console.Clear();
                        Console.Write("Enter instrucions for the database connection: ");
                        instruction = Console.ReadLine();
                        Console.Clear();

                        var SQL = new DbCommand(new SqlConnection(connectionString), instruction);
                        SQL.Execute();

                        Console.WriteLine("");
                        Console.WriteLine("Would you like to go back to the menu? Y/N");

                        if (Console.ReadLine().ToLower() == "n")
                            Environment.Exit(0);

                        Console.Clear();
                        break;

                    case 2:
                        Console.Write("Please enter connection string for Oracle DB: ");
                        connectionString = Console.ReadLine();
                        Console.Clear();
                        Console.Write("Enter instrucions for the database connection: ");
                        instruction = Console.ReadLine();
                        Console.Clear();

                        var Oracle = new DbCommand(new OracleConnection(connectionString), instruction);
                        Oracle.Execute();


                        Console.WriteLine("");
                        Console.WriteLine("Would you like to go back to the menu? Y/N");

                        if (Console.ReadLine().ToLower() == "n")
                            Environment.Exit(0);

                        Console.Clear();
                        break;

                    case 3:
                        Environment.Exit(0);
                        break;

                }

            }
        }

        public static int Menu()
        {
            short DbSelection;

            Console.WriteLine(String.Format(@"Please select which database you would like to connect to:
     Enter 1: SQL Database
     Enter 2: Oracle Database
     Enter 3: Exit Program"));

            DbSelection = Convert.ToInt16(Console.ReadLine());
            Console.Clear();

            return DbSelection;
        }
    }
}


