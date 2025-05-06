using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalManagementSystem.DAL;


namespace HospitalManagementSystem.BLL
{
    public class DatabaseService
    {
        private readonly DatabaseHelper _dbHelper = new DatabaseHelper();
        public void TestConnection()
        {
            _dbHelper.TestConnection();
        }
    }
}
