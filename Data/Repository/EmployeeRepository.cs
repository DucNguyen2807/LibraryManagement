using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class EmployeeRepository : RepositoryBase<Employee>
    {
        public EmployeeRepository() { }

        public bool isUserNameExist(string username)
        {
            var accounts = GetAll();
            return accounts.Any(a => a.Username == username);
        }

        public bool CheckLogin(string username, string password)
        {
            var accounts = GetAll();
            return accounts.Any(a => a.Username == username && a.Password == password);
        }

        public bool isAdmin(string username)
        {
            var accounts = GetAll();
            var account = accounts.FirstOrDefault(acc => acc.Username == username);
            if (account != null)
            {
                return account.EmployeeType.Equals("Admin");
            }
            else
            {
                return false;
            }
        }

        public int GetRole(string username)
        {
            var accounts = GetAll();
            var account = accounts.FirstOrDefault(acc => acc.Username == username);
            if (account != null)
            {
                if (account.EmployeeType == "Admin") return 0;
                else return 1;
            }
            else
            {
                return -1;
            }
        }

        public string GetFullName(string username)
        {
            var accounts = GetAll();
            var account = accounts.FirstOrDefault(acc => acc.Username == username);
            if (account != null)
            {
                return account.FullName;
            }
            else
            {
                return "Không tìm thấy tên tài khoản";
            }

        }

        public int GetEmployeeIdByName(string name)
        {
            var employee = GetAll().SingleOrDefault(x => x.FullName == name);

            if (employee != null)
            {
                return employee.EmployeeId;
            }
            
            return -1;
        }

        public int GetEmployeeIdByUsername(string name)
        {
            var employee = GetAll().FirstOrDefault(x => x.Username == name);

            if (employee != null)
            {
                return employee.EmployeeId;
            }

            return -1;
        }

        public bool isEmpIdExisted(int employeeId)
        {
            var accounts = GetAll();
            return accounts.Any(a => a.EmployeeId == employeeId);
        }


    }
}
