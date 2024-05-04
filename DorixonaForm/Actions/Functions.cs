using DorixonaForm.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DorixonaForm.Actions
{
    public class Functions
    {
        public List<Employe> employeList = new List<Employe>();
        public string EmployesListPath = @"C:\DorixonaForm\DorixonaForm\.txt files\EmployesList.txt";
        public Functions()
        {
            string[] EmployesList = File.ReadAllLines(EmployesListPath);
            for (int i = 0; i < EmployesList.Length; i++)
            {
                string[] EmployesListLine = EmployesList[i].Split(",");
                employeList.Add(new Employe() { Id = int.Parse(EmployesListLine[0]), FIO = EmployesListLine[1], Login = EmployesListLine[2], Password = EmployesListLine[3], PhoneNumber = EmployesListLine[4], EmployeType = EmployesListLine[5] });
            }
        }
    }
    public enum EmployeType
    {
        Manager,
        Salesman
    }
}
