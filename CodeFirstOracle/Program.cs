using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstOracle
{
    class Program
    {
        //http://www.entityframeworktutorial.net/code-first/turn-off-database-initialization-in-code-first.aspx
        static void Main(string[] args)
        {
            Database.SetInitializer<OracleDbContext>(null);

            using (var ctx = new OracleDbContext())
            {
                /*
                var emp = new Employee
                {
                    Name = "Tom",
                    HireDate = DateTime.Now
                };

                ctx.Employees.Add(emp);
                ctx.SaveChanges();

                var dept = new Department
                {
                    Name = "Accounting",
                    ManagerId = emp.EmployeeId
                };

                ctx.Departments.Add(dept);
                ctx.SaveChanges();*/
                Console.WriteLine(ctx.Employees.Count());
            }

            Console.Write("Press any key to continue... ");
            Console.ReadLine();
        }
       /*
        //http://www.oracle.com/webfolder/technetwork/tutorials/obe/db/dotnet/NuGet/index.html#
        //http://www.oracle.com/webfolder/technetwork/tutorials/obe/db/dotnet/CodeFirst/index.html
        static void Main(string[] args)
        {
            try
            {
                // Please replace the connection string attribute settings
                string constr = "user id=hr;password=hr.;data source=localhost/xe";

                OracleConnection con = new OracleConnection(constr);
                con.Open();
                Console.WriteLine("Connected to Oracle Database {0}", con.ServerVersion);
                con.Dispose();

                Console.WriteLine("Press RETURN to exit.");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : {0}", ex);
            }
            Console.ReadKey();
        }
        */ 
    }

    
    public class EMPLOYEES
    {
        [Key]
        public int EMPLOYEE_ID { get; set; }
        public string FIRST_NAME { get; set; }
        //public string Location { get; set; }
    }
    /*
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        [ForeignKey("Manager")]
        public int ManagerId { get; set; }
        public Employee Manager { get; set; }
    }
     * */

    public class OracleDbContext : DbContext
    {
        public DbSet<EMPLOYEES> Employees { get; set; }
        //public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("HR");
        }
    }
}
