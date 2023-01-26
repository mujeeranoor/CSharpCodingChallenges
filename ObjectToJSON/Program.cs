using System;
using System.Text.Json;

namespace ObjectToJSON
{
    public class Department
    {
        public int DeptId  { get; set;}
        public string DepartmentName { get; set; }
    }


    class Program
    {
        
        static void Main(string[] args)
        {
            Department dept = new Department() { DeptId = 101, DepartmentName = "IT" };
            string strJSON = JsonSerializer.Serialize<Department>(dept);
            Console.WriteLine(strJSON);
        }
    }
}
