using CodeFirstOracle.Model;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstOracle.Model.Apfis;

namespace CodeFirstOracle
{
    //http://www.taringa.net/post/ciencia-educacion/16410475/Instalacion-de-Oracle-Instant-Client-11-2-en-Windows-8.html
    //Oracle Cliente

    //estrategiar de inicializacion de base de datos
    //http://www.entityframeworktutorial.net/code-first/database-initialization-strategy-in-code-first.aspx
    class Program
    {
        //http://www.entityframeworktutorial.net/code-first/turn-off-database-initialization-in-code-first.aspx

        //Using NuGet to Install and Configure Oracle Data Provider for .NET
        //http://www.oracle.com/webfolder/technetwork/tutorials/obe/db/dotnet/NuGet/index.html#

        //Entity Framework Code First and Code First Migrations for Oracle Database
        //http://www.oracle.com/webfolder/technetwork/tutorials/obe/db/dotnet/CodeFirst/index.html
        static void Main(string[] args)
        {
            //Database.SetInitializer<OracleDbContext>(null);
            /*
            using (var db = new hrContext())
            {
                Console.WriteLine("Cantidad de Empleados: " + db.EMPLOYEES.Count());
            }
            */

            using (var db = new ApFisContext())
            {
                
                Console.WriteLine("Cantidad de Empleados: " + db.ACTAS.Count());
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



    /*
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public DateTime HireDate { get; set; }
        //public string Location { get; set; }
    }
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        [ForeignKey("Manager")]
        public int ManagerId { get; set; }
        public Employee Manager { get; set; }
    }
    */
    /*
    public class EMPLOYEES
    {
        [Key]
        public int EMPLOYEE_ID { get; set; }
        public string FIRST_NAME { get; set; }
        //public string Location { get; set; }
    }
    public class OracleDbContext : DbContext
    {
        public DbSet<EMPLOYEES> Employees { get; set; }
        //public DbSet<Employee> Employees { get; set; }
        //public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("HR");
        }
    }
    */
}
