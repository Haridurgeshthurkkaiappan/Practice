using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using Dapper;


namespace HariDataaccesslayer
{

    public class employeeregister
    {
        public int EmpId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


    }

    public class RegisterationRepository
    {


        public readonly string connectionString;

        public employeeregister employeeregisterinfo()
        {
            employeeregister e = new employeeregister();

            Console.WriteLine("enter EMPid");
            e.EmpId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter first name ");
            e.FirstName = Console.ReadLine();
            Console.WriteLine("enter last name ");
            e.LastName = Console.ReadLine();

            return e;
        }


        public RegisterationRepository()
        {
            connectionString = @"Data source=DESKTOP-UCPA9BN;Initial catalog=Employee;User Id=sa;Password=Anaiyaan@123";
        }




        public void Insert(employeeregister e)
        {
            try
            {



                SqlConnection con = new SqlConnection(connectionString);

                con.Open();
                con.Execute($"insert into EmployeeRegisters values ('{e.EmpId}','{e.FirstName}','{e.LastName}')");

                con.Close();

            }
            catch (SqlException ep)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void update(employeeregister e)
        {
            try
            {

                Console.WriteLine("enter the condition for emp id");
               int emp = Convert.ToInt32(Console.ReadLine());


                SqlConnection con = new SqlConnection(connectionString);

                con.Open();
                con.Execute($" update EmployeeRegisters set EmpId={e.EmpId},Firstname = ' {e.FirstName}' ,Lastname='{e.LastName}'where EmpId='{emp}'");
                //con.Execute($"  update EmployeeRegisters set EmpId = 333, FirstName ='hari', LastName = 'hari' where EmpId=888 ");

                con.Close();

            }
            catch (SqlException eu)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public List<employeeregister> Read()
        {
            try
            {
                List<employeeregister> constrain = new List<employeeregister>();

                var connection = new SqlConnection(connectionString);
                connection.Open();
                constrain = connection.Query<employeeregister>("select * from EmployeeRegisters").ToList();
                connection.Close();
                foreach (var cons in constrain)
                {


                    Console.WriteLine($"EmpId\t{cons.EmpId},FirstName\t{cons.FirstName},LastName\t{cons.LastName}");
                }

                return constrain;


            }

            catch (SqlException er)
            {
                throw;
            }
            catch (Exception r)
            {
                throw r;
            }
        }

        public void delete()
        {
            try
            {



                SqlConnection con = new SqlConnection(connectionString);
                Console.WriteLine("enter the record name to be deleted");
                int del = Convert.ToInt32(Console.ReadLine());

                con.Open();
                // con.Execute($"  delete from EmployeeRegisters where ( EmpId=333)");
                con.Execute($"  delete from EmployeeRegisters where EmpId='{del}'");

                con.Close();

            }
            catch (SqlException ed)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public void doit()
        {


            int a = 0;
            do
            {
                Console.WriteLine("choose the option");
                Console.WriteLine("0.exit");
                Console.WriteLine("1.add");
                Console.WriteLine("2.list");
                Console.WriteLine("3.update");
                Console.WriteLine("4.delete");


                Console.WriteLine("enter the option");
                a = Convert.ToInt32(Console.ReadLine());

                RegisterationRepository obj = new RegisterationRepository();

                switch (a)
                {
                    case 0:
                        Console.WriteLine("exiting");
                        break;

                    case 1:
                       var detail = obj.employeeregisterinfo();
                        obj.Insert(detail);
                        break;

                    case 2:
                        obj.Read();
                        break;

                    case 3:
                        var change = obj.employeeregisterinfo();
                        obj.update(change);

                        break;

                    case 4:
                        obj.delete();
                        break;

                    default:
                        Console.WriteLine("you entered the invalid option");
                        break;
                }
            } while (a != 0);

        }
    }

}


