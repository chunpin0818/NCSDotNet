//Create a table Department with following details 
//Dept ID, INT 
//DepartmentName Varchar(50) 
//IMplement Insert, Update and Delete using LINQ
//Use Visual Studio for creating Table structure.  

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4___Department_Table__CRUD_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String connectionstring = "Data Source=.;Initial Catalog=NCS2020;Integrated Security=True";
            NCS2020_DeptDataContext mydb=new NCS2020_DeptDataContext();

            Console.WriteLine("NCS 2020 Department Table\n1. Insert Record\n2. Update Record\n3. Delete Record\n4. Display\n\nAnswer:");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    //Insert New Record
                    Console.WriteLine("--------------------------\nPlease enter the New Department ID: ");
                    int new_id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("--------------------------\nPlease enter the New Department Name: ");
                    var new_name = Console.ReadLine();

                    Department dept = new Department();
                    dept.Dept_ID = new_id;
                    dept.Dept_Name = new_name;
                    try
                    {
                        mydb.Departments.InsertOnSubmit(dept);
                        mydb.SubmitChanges();
                        Console.WriteLine("New Record is inserted Successfully!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("New Record is NOT inserted !\nReason:" + ex);
                    }
                    break;

                case 2:
                    //Updating Record
                    Console.WriteLine("--------------------------\nPlease enter the Department ID to update: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    try
                    {
                        Department mydept = mydb.Departments.FirstOrDefault(i => i.Dept_ID == id);
                        Console.WriteLine("Below is the information:\nDepartment ID:{0}\nDepartment Name:{1}", mydept.Dept_ID, mydept.Dept_Name);

                        Console.WriteLine("\nPlease update the Department Name:");
                        string update_name = Console.ReadLine();

                        mydept.Dept_Name = update_name;
                        mydb.SubmitChanges();

                        Department updated_mydept = mydb.Departments.FirstOrDefault(i => i.Dept_ID == id);
                        Console.WriteLine("\nBelow is the information:\nDepartment ID:{0}\nDepartment Name:{1}", updated_mydept.Dept_ID, updated_mydept.Dept_Name);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"The ID :{id} is not found!");
                    }
                    break;

                case 3:
                    Console.WriteLine("--------------------------\nPlease enter the Department ID to delete: ");
                    int del_id = Convert.ToInt32(Console.ReadLine());
                    try
                    {
                        Department mydept2 = mydb.Departments.FirstOrDefault(i => i.Dept_ID == del_id);
                        mydb.Departments.DeleteOnSubmit(mydept2);
                        mydb.SubmitChanges(); 
                        Console.WriteLine("\nBelow is the delete information:\n");
                        Console.WriteLine("Department ID:{0}\nDepartment Name:{1}", mydept2.Dept_ID, mydept2.Dept_Name);
                        Console.WriteLine($"\n\nID {del_id} is deleted successfully!!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"The ID :{del_id} is not found!");
                    }
                    break;

                case 4:
                    Department[] display_dept = mydb.Departments.Select(i => i).ToArray();
                    foreach(var item in display_dept)
                    {
                        Console.WriteLine("\nDepartment ID:{0}\nDeparment Name:{1}",item.Dept_ID,item.Dept_Name);
                    }
                    break;

                default:
                    Console.WriteLine("Please enter valid option");
                    break;
            }
            Console.ReadKey();
        }
    }
}
