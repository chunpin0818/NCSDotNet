//Employee <name, Age, Email, Number and Date of Joining> 
//Add, Remove and Update Data using LINQ to Entity Framework
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Employee__LINQtoENTITIES_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NCS2020Entities mydb=new NCS2020Entities();
            Console.WriteLine("Please choose an option for making an adjustment to Employee Table in database NCS2020: \n1.Adding Data\n2.Updating Data\n3.Removing Data\n4.Display Data\n\nAnswer:");
            int choice=Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    //Adding
                    Console.WriteLine("Enter New Employee ID:");
                    int new_id=Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter New Employee Name:");
                    string new_name = Console.ReadLine();

                    Console.WriteLine("Enter New Employee Age:");
                    int new_age = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter New Employee Email:");
                    string new_email = Console.ReadLine();

                    Employee new_employee = new Employee()
                    {
                        Emp_Id = new_id,
                        Emp_Name = new_name,
                        Emp_Age = new_age,
                        Emp_Email = new_email,
                        Emp_DateofJoining = default             
                    };

                    try
                    {
                        mydb.Employees.Add(new_employee);
                        mydb.SaveChanges();
                        Console.WriteLine("Record is inserted successfully !");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Records not inserted successfully! \nReason:" + ex);
                    }


                    break;

                case 2:
                    //Updating
                    Console.WriteLine("Enter Employee ID to Update:");
                    int update_id = Convert.ToInt32(Console.ReadLine());

                    try
                    {
                        Employee emp = mydb.Employees.FirstOrDefault(e => e.Emp_Id == update_id);
                        Console.WriteLine("\nBelow is the information:\nEmployee ID: {0}\nEmployee Name : {1}\nEmployee Age : {2}\nEmployee Email :{3}\nDate of Joining :{4}", emp.Emp_Id,emp.Emp_Name,emp.Emp_Age,emp.Emp_Email,emp.Emp_DateofJoining);

                        Console.WriteLine("\nEnter New Employee Name:");
                        string updated_name = Console.ReadLine();

                        Console.WriteLine("Enter New Employee Age:");
                        int updated_age = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter New Employee Email:");
                        string updated_email = Console.ReadLine();

                        emp.Emp_Name = updated_name;
                        emp.Emp_Age = updated_age;
                        emp.Emp_Email = updated_email;
                        mydb.SaveChanges();
                        Console.WriteLine("Record is updated successfully !");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Records not updated successfully! \nReason:" + ex);
                    }
                    break;

                case 3:
                    //Removing
                    Console.WriteLine("Enter Employee ID to Delete:");
                    int delete_id = Convert.ToInt32(Console.ReadLine());
                    Employee del_emp = mydb.Employees.FirstOrDefault(e => e.Emp_Id == delete_id);
                    try
                    {
                        mydb.Employees.Remove(del_emp);
                        mydb.SaveChanges();
                        Console.WriteLine("Record is removed successfully !");
                        Console.WriteLine("\nBelow is the information:\nEmployee ID: {0}\nEmployee Name : {1}\nEmployee Age : {2}\nEmployee Email :{3}\nDate of Joining :{4}", del_emp.Emp_Id, del_emp.Emp_Name, del_emp.Emp_Age, del_emp.Emp_Email, del_emp.Emp_DateofJoining);
                    }           
                    catch (Exception ex)
                    {
                        Console.WriteLine("Records not deleted successfully! \nReason:" + ex);
                    }
                    break;

                case 4:
                    //Displaying
                    Console.WriteLine("Below is all the employees:");
                    Employee[] allemployee = mydb.Employees.Select(s => s).ToArray();
                    foreach(var emp in allemployee)
                    {
                        Console.WriteLine("\nEmployee ID: {0}\nEmployee Name : {1}\nEmployee Age : {2}\nEmployee Email :{3}\nDate of Joining :{4}", emp.Emp_Id, emp.Emp_Name, emp.Emp_Age, emp.Emp_Email, emp.Emp_DateofJoining);
                    }
                    break;

                default:
                    Console.WriteLine("Please select a valid option!");
                    break;
                   
            }
            Console.ReadKey();
            
        }
    }
}
