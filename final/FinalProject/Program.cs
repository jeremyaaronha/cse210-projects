//dotnet add package ceTe.DynamicPDF.CoreSuite.NET --version 12.2.0

using System;
using ceTe.DynamicPDF;
using ceTe.DynamicPDF.PageElements;

namespace DynamicPDFCoreSuite.Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            List <string> _certificate = new List<string>();
            int _menuChoice = 0;
            DateTime _actualDate = DateTime.Now;
            string _date = _actualDate.ToString("dd-MM-yyyy");


             do
            {
                Console.WriteLine();
                Console.WriteLine("Menu:");
                Console.WriteLine();

                Console.WriteLine("1. Generate New Certificate");
                Console.WriteLine("2. See Certificates Info");
                Console.WriteLine("3. Quit");
                Console.WriteLine();

                Console.Write("Enter option: ");
                int.TryParse(Console.ReadLine(), out _menuChoice);
                Console.Clear();

                switch (_menuChoice)
                {
                    case 1:
                        Console.WriteLine("The types of certificates are: ");
                        Console.WriteLine(" 1. Birth Certificate");
                        Console.WriteLine(" 2. Marriage Certificate");
                        Console.WriteLine(" 3. Death Certificate");
                        Console.WriteLine(" 4. Educational Certificate");
                        Console.WriteLine(" 5. Professional Certificate");
                        Console.WriteLine(" 6. Achievement Certificate");
                        Console.WriteLine();
                        Console.Write("Wich type of certificate would you like to generate?: ");
                        int _goalTypeMenu;
                        if (!int.TryParse(Console.ReadLine(), out _goalTypeMenu))
                        {
                            Console.WriteLine();
                            Console.WriteLine("Invalid option!");
                            break;
                        }
                        switch (_goalTypeMenu)
                        {
                            case 1:
                                Console.Write("Enter person name: ");
                                string _name1 = Console.ReadLine();
                                Console.Write("Enter birth location: ");
                                string _birthLocation1 = Console.ReadLine();
                                Console.Write("Enter mother name: ");
                                string _motherName1 = Console.ReadLine(); 
                                Console.Write("Enter father name: ");
                                string _fatherName1 = Console.ReadLine();             
                                   
                                BirthCertificate _birthCertificate = new BirthCertificate(_name1,_date, _birthLocation1,_motherName1,_fatherName1);
                                _birthCertificate.CreatePDF();
                                break;
                            case 2:
                                Console.Write("Enter name: ");
                                string _name2 = Console.ReadLine();
                                break;
                            case 3:
                                Console.Write("Enter name: ");
                                string _name3 = Console.ReadLine();
                                break;
                            case 4:
                                Console.Write("Enter name: ");
                                string _name4 = Console.ReadLine();
                                break;
                            case 5:
                                Console.Write("Enter name: ");
                                string _name5 = Console.ReadLine();
                                break;
                            case 6:
                                Console.Write("Enter name: ");
                                string _name6 = Console.ReadLine();
                                break;
                            default:
                                Console.WriteLine("Invalid option!");
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine();
                        Console.WriteLine("Certificates Info:");
                        Console.WriteLine();
                        break;
                    case 3:
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("Please, select a valid option.");
                        break;
                } 
            } while (_menuChoice != 3);
        }
    }

    public abstract class Certificate
    {
        protected string _name;
        protected string _date;

        public Certificate(string name, string date)
        {
            this._name = name;
            this._date = date;
        }
        public abstract void CreatePDF();
        
    }

    public class BirthCertificate : Certificate
    {
        private string _birthLocation;
        private string _motherName;
        private string _fatherName;

        public BirthCertificate(string name, string date,string birthLocation,string motherName,string fatherName) : base(name,date)
        {
            this._birthLocation = birthLocation;
            this._motherName = motherName;
            this._fatherName = fatherName;
        }

        public override void CreatePDF()
        {
            Document document = new Document();

            Page page = new Page(PageSize.Letter, PageOrientation.Portrait, 54.0f);
            document.Pages.Add(page);
            
            string labelText = "Jeremy Aaron Herrera Arevalo\nFor Finish the Example  - Programming with Classes\nMarch 20 - 2023";
            Label label = new Label(labelText, 0, 0, 504, 100, Font.Helvetica, 18, TextAlign.Center);
            page.Elements.Add(label);
            
            document.Draw("Pdf-Example.pdf");
        }
    }

    public class MarriageCertificate : Certificate
    {
        private string _spouseName;
        private string _weddingLocation;

        public MarriageCertificate(string name,string date, string spouseName,string weddingLocation) : base(name,date)
        {
            this._spouseName = spouseName;
            this._weddingLocation = weddingLocation;
        }

        public override void CreatePDF()
        {
            Document document = new Document();

            Page page = new Page(PageSize.Letter, PageOrientation.Portrait, 54.0f);
            document.Pages.Add(page);
            
            string labelText = "Jeremy Aaron Herrera Arevalo\nFor Finish the CSE 210 Course - Programming with Classes\nMarch 15 - 2023";
            Label label = new Label(labelText, 0, 0, 504, 100, Font.Helvetica, 18, TextAlign.Center);
            page.Elements.Add(label);
            
            document.Draw("Pdf-Example.pdf");
        }
    }

    public class DeathCertificate : Certificate
    {
        private string _causeOfDeath;
        private string _funeralLocation;

        public DeathCertificate(string name, string date, string causeOfDeath, string funeralLocation) : base(name,date)
        {
            this._causeOfDeath = causeOfDeath;
            this._funeralLocation = funeralLocation;
        }

        public override void CreatePDF()
        {
            Document document = new Document();

            Page page = new Page(PageSize.Letter, PageOrientation.Portrait, 54.0f);
            document.Pages.Add(page);
            
            string labelText = "Jeremy Aaron Herrera Arevalo\nFor Finish the CSE 210 Course - Programming with Classes\nMarch 15 - 2023";
            Label label = new Label(labelText, 0, 0, 504, 100, Font.Helvetica, 18, TextAlign.Center);
            page.Elements.Add(label);
            
            document.Draw("Pdf-Example.pdf");
        }
    }

    public class EducationalCertificate : Certificate
    {
        private string _institution;
        private string _fieldOfStudy;
        private string _graduationDate;

        public EducationalCertificate(string name, string date, string institution, string fieldOfStudy, string graduationDate) : base(name,date)
        {
            this._institution = institution;
            this._fieldOfStudy = fieldOfStudy;
            this._graduationDate = graduationDate;
        }

        public override void CreatePDF()
        {
            Document document = new Document();

            Page page = new Page(PageSize.Letter, PageOrientation.Portrait, 54.0f);
            document.Pages.Add(page);
            
            string labelText = "Jeremy Aaron Herrera Arevalo\nFor Finish the CSE 210 Course - Programming with Classes\nMarch 15 - 2023";
            Label label = new Label(labelText, 0, 0, 504, 100, Font.Helvetica, 18, TextAlign.Center);
            page.Elements.Add(label);
            
            document.Draw("Pdf-Example.pdf");
        }
    }

    public class ProfessionalCertificate : Certificate
    {
        private string _organization;
        private string _certificationName;

        public ProfessionalCertificate(string name, string date,string organization, string certificationName) : base(name,date)
        {
            this._organization = organization;
            this._certificationName = certificationName;
        }

        public override void CreatePDF()
        {
            Document document = new Document();

            Page page = new Page(PageSize.Letter, PageOrientation.Portrait, 54.0f);
            document.Pages.Add(page);
            
            string labelText = "Jeremy Aaron Herrera Arevalo\nFor Finish the CSE 210 Course - Programming with Classes\nMarch 15 - 2023";
            Label label = new Label(labelText, 0, 0, 504, 100, Font.Helvetica, 18, TextAlign.Center);
            page.Elements.Add(label);
            
            document.Draw("Pdf-Example.pdf");
        }
    }

    public class AchievementCertificate : Certificate
    {
        private string _description;

        public AchievementCertificate(string name, string date, string description) : base(name,date)
        {
            this._description = description;
        }

        public override void CreatePDF()
        {
            Document document = new Document();

            Page page = new Page(PageSize.Letter, PageOrientation.Portrait, 54.0f);
            document.Pages.Add(page);
            
            string labelText = "Jeremy Aaron Herrera Arevalo\nFor Finish the CSE 210 Course - Programming with Classes\nMarch 15 - 2023";
            Label label = new Label(labelText, 0, 0, 504, 100, Font.Helvetica, 18, TextAlign.Center);
            page.Elements.Add(label);
            
            document.Draw("Pdf-Example.pdf");
        }
    }
}