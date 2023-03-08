using System;

namespace PolymorphismEx1
{
    public class DbCommand
    {
        private readonly DbConnection _dbConnection;
        private readonly string _dbInstruction;

        public DbCommand(DbConnection dbConnection, string dbInstruction)
        {
            if (dbConnection == null)
                throw new NullReferenceException("No Active Database Connection");
            if (String.IsNullOrEmpty(dbInstruction))
                throw new NullReferenceException("Instruction is non-existant. Please add one in order to proceed");

            _dbConnection = dbConnection;
            _dbInstruction = dbInstruction;
        }

        public void Execute()
        {
            _dbConnection.Open();
            Console.WriteLine($"Executing the instruction: \"{_dbInstruction}\"");
            _dbConnection.Close();
        }
    }
}