using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DorixonaForm.Actions
{
    public class Functions : IAction
    {
        public List<SellingPill> sellingPillesList = new List<SellingPill>();
        public List<Employe> employeList = new List<Employe>();
        public List<Pill> pillsList = new List<Pill>();
        public List<AllInformations> allInformations = new List<AllInformations>();
        public List<ReportSelesPill> reportSelesPills = new List<ReportSelesPill>();
        public string SellingPillesListPath = @"..\..\..\.txt files\SellingPillesList.txt";
        public string EmployesListPath = @"..\..\..\.txt files\EmployesList.txt";
        public string PillsListPath = @"..\..\..\.txt files\PillesList.txt";
        public string AllInformationsPath = @"..\..\..\.txt files\AllInformations.txt";
        public string ReportSelesPillsPath = @"..\..\..\.txt files\ReportSelesPill.txt";
        public Functions()
        {
            string[] EmployesList = File.ReadAllLines(EmployesListPath);
            for (int i = 0; i < EmployesList.Length; i++)
            {
                string[] EmployesListLine = EmployesList[i].Split(",");
                employeList.Add(new Employe() { Id = int.Parse(EmployesListLine[0]), FIO = EmployesListLine[1], Login = EmployesListLine[2], Password = EmployesListLine[3], PhoneNumber = EmployesListLine[4], EmployeType = EmployesListLine[5] });
            }
            string[] PillsList = File.ReadAllLines(PillsListPath);
            for (int i = 0; i < PillsList.Length; i++)
            {
                string[] PillsListLine = PillsList[i].Split(",");
                pillsList.Add(new Pill() { Id = int.Parse(PillsListLine[0]), Nomi = PillsListLine[1], Soni = int.Parse(PillsListLine[2]), Muddati = int.Parse(PillsListLine[3]), Narxi = int.Parse(PillsListLine[4]), QoshilganSana = DateTime.Parse(PillsListLine[5]) });
            }
            string[] SellingPillesList = File.ReadAllLines(SellingPillesListPath);
            for (int i = 0; i < SellingPillesList.Length; i++)
            {
                string[] SellingPillsListLine = SellingPillesList[i].Split(",");
                sellingPillesList.Add(new SellingPill() { Id = int.Parse(SellingPillsListLine[0]), Nomi = SellingPillsListLine[1], Soni = int.Parse(SellingPillsListLine[2]), Narxi = int.Parse(SellingPillsListLine[3]) });
            }
            string[] AllInformationsList = File.ReadAllLines(AllInformationsPath);
            for (int i = 0; i < AllInformationsList.Length; i++)
            {
                string[] AllInformationsListLine = AllInformationsList[i].Split(",");
                allInformations.Add(new AllInformations() { Id = int.Parse(AllInformationsListLine[0]), FIO = AllInformationsListLine[1], ProcessType = AllInformationsListLine[2], Information = AllInformationsListLine[3], ProcessTime = AllInformationsListLine[4] });
            }
            string[] ReportSelesPills = File.ReadAllLines(ReportSelesPillsPath);
            for (int i = 0; i < ReportSelesPills.Length; i++)
            {
                string[] ReportSelesPillsLine = ReportSelesPills[i].Split(",");
                reportSelesPills.Add(new ReportSelesPill() { DoriId = int.Parse(ReportSelesPillsLine[0]), FIO = ReportSelesPillsLine[1], Nomi = ReportSelesPillsLine[2], Soni = int.Parse(ReportSelesPillsLine[3]), SotilganVaqti = ReportSelesPillsLine[4], Narxi = int.Parse(ReportSelesPillsLine[5]) });
            }
        }
        public bool CheckProbel(string str)
        {
            if (str.Length > 0)
            {
                int sanoq = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == ' ')
                    {
                        sanoq++;
                    }
                }
                if (sanoq != str.Length)
                {
                    return true;
                }
            }
            return false;
        }
        public bool CheckNumber(string str)
        {
            if (str.Length > 0)
            {
                int sanoq = 0;
                char FirstChar = '1';
                for (int i = 0; i < str.Length; i++)
                {
                    FirstChar = str[0];
                    if (str[i] >= 48 && str[i] <= 57)
                    {
                        sanoq++;
                    }
                }
                if ( FirstChar != '0' && sanoq == str.Length)
                {
                    return true;
                }
            }
            return false;
        }
    }
    public enum EmployeType
    {
        Manager,
        Salesman
    }
    public enum InformationType
    {
        ChangePassword,
        ChangePhoneNumber,
        AddPill,
        DeletePill,
        UpdatePill,
        SalesPill,
        AddSalesman,
        DeteleSalesman,
        EmployeEnter,
        EmployeExit
    }
}
