using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hybrid1
{
    public class MarkSheet : TheoryExamMarks, ICalculate
    {
        private static int s_marksheetNumber=2000;
        public string MarkSheetNumber { get; set; }
        public double TotalPercentage { get; set; }
        public DateTime DateOfIssue { get; set; }
        public double ProjectMark { get; set; }

        public MarkSheet(string registorNumber,string name, string fatherName,long phone,DateTime date, Gender gender,double[] sem1,double[] sem2,double[] sem3,double[] sem4,DateTime dateOfIssue)
        {
            s_marksheetNumber++;
            MarkSheetNumber="MID"+s_marksheetNumber;
            RegistorNumber=registorNumber;
            Name=name;
            FatherName=fatherName;
            Phone=phone;
            DOB=date;
            Gender=gender;
            Sem1=sem1;
            Sem2=sem2;
            Sem3=sem3;
            Sem4=sem4;
            DateOfIssue=dateOfIssue;
        }
        
        public string CalculateUG(double[] Sem)
        {
            double total = 0;
            for(int i=0;i<6;i++)
            {
                total += Sem[i];
            }
            TotalPercentage=total/6;
            return "\nTotal : "+total+"\nPercentage : "+TotalPercentage;
        }

        public string ShowUGMarkSheet()
        {
            s_marksheetNumber++;
            MarkSheetNumber="MID"+s_marksheetNumber;
            return "Mark sheet number : "+MarkSheetNumber+"\nDate of Issue : "+DateOfIssue+"\n\nName : "+Name+"\nFather Name : "+FatherName+"\nPhone : "+Phone+"\nDOB : "+DOB+"\nGender : "+Gender+"\n\nSem1 "+CalculateUG(Sem1)+"\nSem2 "+CalculateUG(Sem2)+"\nSem3 "+CalculateUG(Sem3)+"\nSem4 "+CalculateUG(Sem4);
        }
    }
}