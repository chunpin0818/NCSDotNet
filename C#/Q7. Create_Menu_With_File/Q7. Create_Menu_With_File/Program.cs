//Write a Menu Driven program with Following options  
//Press 1 to Create a File  
//Press 2 To Append a text into a File  
//Press 3 To Remove content of the File.  
//Press 4 to Display file attributes like last time changes etc 
//Press 5 to Show Total Line of the file  
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7.Create_Menu_With_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" --- Menu Drive Program --- \n1. Create a File  \n2. Append a text into a File\n3. Remove content of the File\n4. Display file attributes with last modified\n5. Show Total Line of the file \nAnswer:");
            int choice= Convert.ToInt16(Console.ReadLine());
            switch(choice){
                case 1:
                    Console.WriteLine("\nPlease Name your file:");
                    string filename = Console.ReadLine();
                    File.Create(filename+".txt");
                    Console.WriteLine("\nYour File {0}.txt has been created successfully!",filename);
                    break;

                case 2:
                    Console.WriteLine("\nPlease write the FULL name of your file:");
                    string myFile = Console.ReadLine();
                    Console.WriteLine("\nPlease write your content to append the created file:");
                    string text = Console.ReadLine();
                    using (StreamWriter sw = File.AppendText(myFile))
                    {
                        sw.WriteLine(text);
                    }

                    Console.WriteLine("\nBelow is your file content after appended:");
                    using (StreamReader sr = File.OpenText(myFile))
                    {
                        string s = "";
                        while ((s = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(s);
                        }
                    }
                    break;

                case 3:
                    Console.WriteLine("\nPlease write the FULL name of your file that want to be deleted:");
                    string myFile2 = Console.ReadLine();
                    File.WriteAllText(myFile2, string.Empty);
                    Console.WriteLine("All the content in the file '{0}' have been removed successfully.",myFile2);
                    break;

                case 4:
                    Console.WriteLine("\nPlease write the FULL name of your file:");
                    string myFile3 = Console.ReadLine();
                    Console.WriteLine("\nBelow is the File Attributes:\n"+File.GetAttributes(myFile3));
                    DateTime dt = File.GetLastWriteTimeUtc(myFile3);
                    Console.WriteLine("\nThe last modified date & time is :" + dt);
                    break;

                case 5:
                    Console.WriteLine("\nPlease write the FULL name of your file:");
                    string myFile4 = Console.ReadLine();
                    var lineCount = File.ReadLines(myFile4).Count();
                    Console.WriteLine("\nThe total line of file {0} is : {1}",myFile4,lineCount);
                    break;

                default:
                    Console.WriteLine("Please Choose a Valid Options!");
                    break;
            }

            Console.ReadKey();
        }
    }
}
