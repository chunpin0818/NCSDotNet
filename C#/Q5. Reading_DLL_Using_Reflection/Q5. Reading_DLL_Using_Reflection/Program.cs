//WAP to Read Content of a Dll/Exe using pathname  
//Display all Classes inside Namespace followed by Methods, types and Arguments. 
using System;
using System.Reflection;

namespace Q5.Reading_DLL_Using_Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly sampleAssembly = Assembly.LoadFrom(@"C:\Users\User\OneDrive - Asia Pacific University\Desktop\Doc Net\Practical Assignments\C#\Q5. Reading_DLL_Using_Reflection\Q5.1 Library");

            Type[] types = sampleAssembly.GetTypes();
            foreach (var type in types)
            {
                Console.WriteLine("---- Type: {0} ----",type.Name);

                MethodInfo[] methods = type.GetMethods();
                foreach(var method in methods)
                {
                    Console.WriteLine("--Methods: "+method.Name);

                    ParameterInfo[] parameters = method.GetParameters();
                    foreach (var parameter in parameters)
                    {
                        Console.WriteLine("-Parameter Name: {0}", parameter.Name);
                        Console.WriteLine("-Parameter Type: {0}", parameter.ParameterType);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
