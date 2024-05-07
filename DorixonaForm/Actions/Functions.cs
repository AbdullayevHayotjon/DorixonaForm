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
        public List<Pill> sellingPillesList = new List<Pill>();
        public List<Employe> employeList = new List<Employe>();
        public List<Pill> pillsList = new List<Pill>();
        public string SellingPillesListPath = @"C:\DorixonaForm\DorixonaForm\.txt files\SellingPillesList.txt";
        public string EmployesListPath = @"C:\DorixonaForm\DorixonaForm\.txt files\EmployesList.txt";
        public string PillsListPath = @"C:\DorixonaForm\DorixonaForm\.txt files\PillesList.txt";
        public Functions()
        {
            string[] EmployesList = File.ReadAllLines(EmployesListPath);
            for (int i = 0; i < EmployesList.Length; i++)
            {
                string[] EmployesListLine = EmployesList[i].Split(",");
                employeList.Add(new Employe() { Id = int.Parse(EmployesListLine[0]), FIO = EmployesListLine[1], Login = EmployesListLine[2], Password = EmployesListLine[3], PhoneNumber = EmployesListLine[4], EmployeType = EmployesListLine[5] });
            }
            string[] PillsList = File.ReadAllLines(PillsListPath);
            for(int i = 0; i < PillsList.Length; i++)
            {
                string[] PillsListLine = PillsList[i].Split(",");
                pillsList.Add(new Pill() { Id = int.Parse(PillsListLine[0]), Nomi = PillsListLine[1], Soni = int.Parse(PillsListLine[2]), Narxi = int.Parse(PillsListLine[3]) });
            }
            string[] SellingPillesList = File.ReadAllLines(SellingPillesListPath);
            for (int i = 0; i < SellingPillesList.Length; i++)
            {
                string[] SellingPillsListLine = SellingPillesList[i].Split(",");
                sellingPillesList.Add(new Pill() { Id = int.Parse(SellingPillsListLine[0]), Nomi = SellingPillsListLine[1], Soni = int.Parse(SellingPillsListLine[2]), Narxi = int.Parse(SellingPillsListLine[3]) });
            }
        }
    }
    public enum EmployeType
    {
        Manager,
        Salesman
    }
}
