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
            List <string> _certificates = new List<string>();
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
                Console.WriteLine("3. Download a previous certificate");
                Console.WriteLine("4. Quit");
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
                                Console.Write("Enter person full name: ");
                                string _name1 = Console.ReadLine();
                                Console.Write("Enter birth location: ");
                                string _birthLocation1 = Console.ReadLine();
                                Console.Write("Enter ID number: ");
                                string _idNumber1 = Console.ReadLine();  
                                Console.Write("Enter birth date (dd-MM-yyyy): ");
                                string _birthDate1 = Console.ReadLine();
                                Console.Write("Enter gender (Male/Female): ");
                                string _gender1 = Console.ReadLine(); 
                                Console.Write("Enter mother name: ");
                                string _motherName1 = Console.ReadLine(); 
                                Console.Write("Enter father name: ");
                                string _fatherName1 = Console.ReadLine(); 
                                
                                Console.Write("Save file as: ");
                                string _fileName1 = Console.ReadLine();            

                                BirthCertificate _birthCertificate = new BirthCertificate(_name1,_date, _fileName1,_birthLocation1,_birthDate1,_gender1,_idNumber1,_motherName1,_fatherName1);
                                _birthCertificate.CreatePDF();
                                _certificates.Add(_birthCertificate.ReturnCertificateInfo());
                                break;
                            case 2:
                                Console.Write("Enter person name: ");
                                string _name2 = Console.ReadLine();
                                Console.Write("Enter spouse name: ");
                                string _spouseName1 = Console.ReadLine();
                                Console.Write("Enter wedding location: ");
                                string _weddingLocation1 = Console.ReadLine(); 
                                Console.Write("Enter wedding date (dd-MM-yyyy): ");
                                string _weddingDate1 = Console.ReadLine();

                                Console.Write("Save file as: ");
                                string _fileName2 = Console.ReadLine();

                                MarriageCertificate _marriageCertificate = new MarriageCertificate(_name2,_date,_fileName2, _spouseName1,_weddingLocation1,_weddingDate1);
                                _marriageCertificate.CreatePDF();
                                _certificates.Add(_marriageCertificate.ReturnCertificateInfo());

                                break;
                            case 3:
                                Console.Write("Enter person name: ");
                                string _name3 = Console.ReadLine();
                                Console.Write("Enter Birth Date (dd-MM-yyyy): ");
                                string _birthDate2 = Console.ReadLine();
                                Console.Write("Enter ID Number: ");
                                string _idNumber2 = Console.ReadLine();
                                Console.Write("Enter gender (Male/Female): ");
                                string _gender3 = Console.ReadLine();
                                Console.Write("Enter cause of death: ");
                                string _causeOfDeath1 = Console.ReadLine();
                                Console.Write("Enter funeral location: ");
                                string _funeralLocation1 = Console.ReadLine(); 

                                Console.Write("Save file as: ");
                                string _fileName3 = Console.ReadLine();

                                DeathCertificate _deathCertificate = new DeathCertificate(_name3,_date,_fileName3,_birthDate2,_idNumber2,_gender3, _causeOfDeath1,_funeralLocation1);
                                _deathCertificate.CreatePDF();
                                _certificates.Add(_deathCertificate.ReturnCertificateInfo());
                             
                                break;
                            case 4:
                                Console.Write("Enter person name: ");
                                string _name4 = Console.ReadLine();
                                Console.Write("Enter institution name: ");
                                string _institution1 = Console.ReadLine();
                                Console.Write("Enter field of study: ");
                                string _fieldOfStudy1 = Console.ReadLine(); 
                                Console.Write("Enter graduation date (dd-MM-yyyy): ");
                                string _graduationDate1 = Console.ReadLine(); 
                                
                                Console.Write("Save file as: ");
                                string _fileName4 = Console.ReadLine();

                                EducationalCertificate _educationalCertificate = new EducationalCertificate(_name4,_date,_fileName4, _institution1,_fieldOfStudy1,_graduationDate1);
                                _educationalCertificate.CreatePDF(); 
                                _certificates.Add(_educationalCertificate.ReturnCertificateInfo());
                               
                                break;
                            case 5:
                                Console.Write("Enter person name: ");
                                string _name5 = Console.ReadLine();
                                Console.Write("Enter organization name: ");
                                string _organization1 = Console.ReadLine();
                                Console.Write("Enter certification name: ");
                                string _certificationName1 = Console.ReadLine(); 
                                Console.Write("Enter certification date (dd-MM-yyyy): ");
                                string _certificationDate1 = Console.ReadLine();

                                Console.Write("Save file as: ");
                                string _fileName5 = Console.ReadLine();

                                ProfessionalCertificate _professionalCertificate = new ProfessionalCertificate(_name5,_date,_fileName5, _organization1,_certificationName1,_certificationDate1);
                                _professionalCertificate.CreatePDF();
                                _certificates.Add(_professionalCertificate.ReturnCertificateInfo());
                            
                                break;
                            case 6:
                                Console.Write("Enter person name: ");
                                string _name6 = Console.ReadLine();
                                Console.Write("Enter description: ");
                                string _description1 = Console.ReadLine();

                                Console.Write("Save file as: ");
                                string _fileName6 = Console.ReadLine();

                                AchievementCertificate _achievementCertificate = new AchievementCertificate(_name6,_date,_fileName6, _description1);
                                _achievementCertificate.CreatePDF();  
                                _certificates.Add(_achievementCertificate.ReturnCertificateInfo());
 
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

                        foreach (string _certificate in _certificates)
                        {
                            Console.WriteLine(_certificate);
                            Console.WriteLine();
                        }
                        break;
                    case 3:
                        Console.WriteLine();
                        Console.WriteLine("Select a previous certificate to download: ");

                        for (int i = 0; i < _certificates.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {_certificates[i]}");
                        }

                        Console.Write("Enter certificate number: ");
                        string certificateNumberStr = Console.ReadLine();

                        if (!int.TryParse(certificateNumberStr, out int certificateNumber) || certificateNumber < 1 || certificateNumber > _certificates.Count)
                        {
                            Console.WriteLine("Invalid certificate number!");
                            break;
                        }

                        string[] selectedCertificate = (_certificates[certificateNumber - 1]).Split("|");

                        if (selectedCertificate[0] == "Birth Certificate")
                        {
                            string _name = selectedCertificate[1];
                            string _birthLocation = selectedCertificate[2];
                            string _idNumber = selectedCertificate[3];
                            string _birthDate = selectedCertificate[4];
                            string _gender = selectedCertificate[5];
                            string _motherName = selectedCertificate[6];
                            string _fatherName = selectedCertificate[7];

                            Console.Write("Save file as: ");
                            string _fileName = Console.ReadLine();

                            BirthCertificate _birthCertificate = new BirthCertificate(_name,_date,_fileName,_birthLocation,_idNumber,_birthDate,_gender,_motherName,_fatherName);
                            _birthCertificate.CreatePDF();
                        }
                        else if(selectedCertificate[0] == "Marriage Certificate")
                        {
                            string _name = selectedCertificate[1];
                            string _spouseName = selectedCertificate[2];
                            string _weddingLocation = selectedCertificate[3];
                            string _weddingDate = selectedCertificate[4];
   

                            Console.Write("Save file as: ");
                            string _fileName = Console.ReadLine();

                            MarriageCertificate _marriageCertificate = new MarriageCertificate(_name,_date,_fileName,_spouseName,_weddingLocation,_weddingDate);
                            _marriageCertificate.CreatePDF();
                        }
                        else if(selectedCertificate[0] == "Death Certificate")
                        {
                            string _name = selectedCertificate[1];
                            string _birthDate = selectedCertificate[2];
                            string _idNumber = selectedCertificate[3];
                            string _gender = selectedCertificate[4];
                            string _causeOfDeath = selectedCertificate[5];
                            string _funeralLocation = selectedCertificate[6];

                            Console.Write("Save file as: ");
                            string _fileName = Console.ReadLine();

                            DeathCertificate _deathCertificate = new DeathCertificate(_name,_date,_fileName,_birthDate,_idNumber,_gender,_causeOfDeath,_funeralLocation);
                            _deathCertificate.CreatePDF();
                        }
                        else if(selectedCertificate[0] == "Educational Certificate")
                        {
                            string _name = selectedCertificate[1];
                            string _institution = selectedCertificate[2];
                            string _fieldOfStudy = selectedCertificate[3];
                            string _graduationDate = selectedCertificate[4];


                            Console.Write("Save file as: ");
                            string _fileName = Console.ReadLine();

                            EducationalCertificate _educationalCertificate = new EducationalCertificate(_name,_date,_fileName,_institution,_fieldOfStudy,_graduationDate);
                            _educationalCertificate.CreatePDF();
                        }
                        else if(selectedCertificate[0] == "Professional Certificate")
                        {
                            string _name = selectedCertificate[1];
                            string _organization = selectedCertificate[2];
                            string _certificationName = selectedCertificate[3];
                            string _certificationDate = selectedCertificate[4];


                            Console.Write("Save file as: ");
                            string _fileName = Console.ReadLine();

                            ProfessionalCertificate _professionalCertificate = new ProfessionalCertificate(_name,_date,_fileName,_organization,_certificationName,_certificationDate);
                            _professionalCertificate.CreatePDF();
                        }
                        else if(selectedCertificate[0] == "Achievement Certificate")
                        {
                            string _name = selectedCertificate[1];
                            string _description = selectedCertificate[2];

                            Console.Write("Save file as: ");
                            string _fileName = Console.ReadLine();

                            AchievementCertificate _achievementCertificate = new AchievementCertificate(_name,_date,_fileName,_description);
                            _achievementCertificate.CreatePDF();
                        }  
                        break;
                    case 4:
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("Please, select a valid option.");
                        break;
                } 
            } while (_menuChoice != 4);
        }
    }

    public abstract class Certificate
    {
        protected string _name;
        protected string _date;
        protected string _fileName;

        public Certificate(string name, string date, string fileName)
        {
            this._name = name;
            this._date = date;
            this._fileName = fileName;
        }
        public abstract void CreatePDF();
        public abstract string ReturnCertificateInfo();
        
    }

    public class BirthCertificate : Certificate
    {
        private string _birthLocation;
        private string _birthDate;
        private string _gender;
        private string _idNumber;
        private string _motherName;
        private string _fatherName;

        public BirthCertificate(string name, string date,string fileName,string birthLocation,string birthDate,string gender,string idNumber,string motherName,string fatherName) : base(name,date,fileName)
        {
            this._birthLocation = birthLocation;
            this._birthDate = birthDate;
            this._gender = gender;
            this._idNumber = idNumber;
            this._motherName = motherName;
            this._fatherName = fatherName;
        }

        public override void CreatePDF()
        {
            Document document = new Document();

            Page page = new Page(PageSize.Letter, PageOrientation.Portrait, 54.0f);
            document.Pages.Add(page);

            string labelText0 = $"_____________________________________________\n\n{_date}";
            Label label0 = new Label(labelText0, 0, 100, 504, 100, Font.Helvetica, 20, TextAlign.Right);
            page.Elements.Add(label0);

            string labelText = "CERTIFICATE";
            Label label = new Label(labelText, 0, 0, 504, 100, Font.Helvetica, 48, TextAlign.Center);
            label.TextColor = RgbColor.Red;
            page.Elements.Add(label);

            string labelText2 = "OF BIRTH";
            Label label2 = new Label(labelText2, 0, 60, 504, 100, Font.Helvetica, 25, TextAlign.Center);
            label2.TextColor = RgbColor.Red;
            page.Elements.Add(label2);
            

            string labelText3 = $"\n\nRegistered Name: {_name}\nBirth Location: {_birthLocation}\nID Number: {_idNumber}\nBirth Date (dd-MM-yyyy): {_birthDate}\nGender: {_gender}\nName of the mother: {_motherName}\nName of the father: {_fatherName}";
            Label label3 = new Label(labelText3, 0, 150, 504, 300, Font.Helvetica, 18, TextAlign.Left);
            page.Elements.Add(label3);

            document.Draw($"{_fileName}.pdf");
        }
        
        public override string ReturnCertificateInfo()
        {
            return $"Birth Certificate|{_name}|{_birthLocation}|{_birthDate}|{_gender}|{_idNumber}|{_motherName}|{_fatherName}";
        }
    }

    public class MarriageCertificate : Certificate
    {
        private string _spouseName;
        private string _weddingLocation;
        private string _weddingDate;

        public MarriageCertificate(string name,string date, string fileName,string spouseName,string weddingLocation, string weddingDate) : base(name,date,fileName)
        {
            this._spouseName = spouseName;
            this._weddingLocation = weddingLocation;
            this._weddingDate = weddingDate;
        }

        public override void CreatePDF()
        {
            Document document = new Document();

            Page page = new Page(PageSize.Letter, PageOrientation.Portrait, 54.0f);
            document.Pages.Add(page);

            string labelText0 = $"_____________________________________________\n\n{_date}";
            Label label0 = new Label(labelText0, 0, 100, 504, 100, Font.Helvetica, 20, TextAlign.Right);
            page.Elements.Add(label0);

            string labelText = "CERTIFICATE";
            Label label = new Label(labelText, 0, 0, 504, 100, Font.Helvetica, 48, TextAlign.Center);
            label.TextColor = RgbColor.Red;
            page.Elements.Add(label);

            string labelText2 = "OF MARRIAGE";
            Label label2 = new Label(labelText2, 0, 60, 504, 100, Font.Helvetica, 25, TextAlign.Center);
            label2.TextColor = RgbColor.Red;
            page.Elements.Add(label2);

            string labelText3 = $"\n\nIt is recognized that: ";
            Label label3 = new Label(labelText3, 0, 150, 504, 300, Font.Helvetica, 18, TextAlign.Center);
            page.Elements.Add(label3);

            string labelText4 = $"\n{_name}";
            Label label4 = new Label(labelText4, 0, 200, 504, 300, Font.Helvetica, 35, TextAlign.Center);
            page.Elements.Add(label4);

            string labelText5 = $"\nhas married";
            Label label5 = new Label(labelText5, 0, 280, 504, 300, Font.Helvetica, 18, TextAlign.Center);
            page.Elements.Add(label5);

            string labelText6 = $"\n{_spouseName}";
            Label label6 = new Label(labelText6, 0, 300, 504, 300, Font.Helvetica, 35, TextAlign.Center);
            page.Elements.Add(label6);

            string labelText7 = $"\n\nthe day {_weddingDate}\n\n in {_weddingLocation}";
            Label label7 = new Label(labelText7, 0, 400, 504, 300, Font.Helvetica, 18, TextAlign.Center);
            page.Elements.Add(label7);

            document.Draw($"{_fileName}.pdf");
        }

        public override string ReturnCertificateInfo()
        {
            return $"Marriage Certificate|{_name}|{_spouseName}|{_weddingLocation}|{_weddingDate}";
        }
    }

    public class DeathCertificate : Certificate
    {
        private string _causeOfDeath;
        private string _funeralLocation;
        private string _birthDate;
        private string _idNumber;
        private string _gender;

        public DeathCertificate(string name, string date, string fileName, string birthDate,string idNumber,string gender,string causeOfDeath, string funeralLocation) : base(name,date,fileName)
        {
            this._birthDate = birthDate;
            this._idNumber = idNumber;
            this._gender = gender;
            this._causeOfDeath = causeOfDeath;
            this._funeralLocation = funeralLocation;
        }

        public override void CreatePDF()
        {
            Document document = new Document();

            Page page = new Page(PageSize.Letter, PageOrientation.Portrait, 54.0f);
            document.Pages.Add(page);

            string labelText0 = $"_____________________________________________\n\n{_date}";
            Label label0 = new Label(labelText0, 0, 100, 504, 100, Font.Helvetica, 20, TextAlign.Right);
            page.Elements.Add(label0);

            string labelText = "CERTIFICATE";
            Label label = new Label(labelText, 0, 0, 504, 100, Font.Helvetica, 48, TextAlign.Center);
            label.TextColor = RgbColor.Red;
            page.Elements.Add(label);

            string labelText2 = "OF DEATH";
            Label label2 = new Label(labelText2, 0, 60, 504, 100, Font.Helvetica, 25, TextAlign.Center);
            label2.TextColor = RgbColor.Red;
            page.Elements.Add(label2);

            string labelText3 = $"\n\nRegistered Name: {_name}\nID Number: {_idNumber}\nBirth Date: {_birthDate}\nGender: {_gender}\nCause of death: {_causeOfDeath}\nFuneral Location: {_funeralLocation}";
            Label label3 = new Label(labelText3, 0, 150, 504, 300, Font.Helvetica, 18, TextAlign.Left);
            page.Elements.Add(label3);

            document.Draw($"{_fileName}.pdf");
        }

        public override string ReturnCertificateInfo()
        {
            return $"Death Certificate|{_name}|{_birthDate}|{_idNumber}|{_gender}|{_causeOfDeath}|{_funeralLocation}";
        }
    }

    public class EducationalCertificate : Certificate
    {
        private string _institution;
        private string _fieldOfStudy;
        private string _graduationDate;

        public EducationalCertificate(string name, string date,string fileName, string institution, string fieldOfStudy, string graduationDate) : base(name,date,fileName)
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

            string labelText0 = $"_____________________________________________\n\n{_date}";
            Label label0 = new Label(labelText0, 0, 100, 504, 100, Font.Helvetica, 20, TextAlign.Right);
            page.Elements.Add(label0);

            string labelText = "EDUCATIONAL";
            Label label = new Label(labelText, 0, 0, 504, 100, Font.Helvetica, 48, TextAlign.Center);
            label.TextColor = RgbColor.Red;
            page.Elements.Add(label);

            string labelText2 = "CERTIFICATE";
            Label label2 = new Label(labelText2, 0, 60, 504, 100, Font.Helvetica, 25, TextAlign.Center);
            label2.TextColor = RgbColor.Red;
            page.Elements.Add(label2);

            string labelText3 = $"\n{_institution}";
            Label label3 = new Label(labelText3, 0, 150, 504, 300, Font.Helvetica, 40, TextAlign.Center);
            page.Elements.Add(label3);

            string labelText4 = $"\nconfers the academic title of";
            Label label4 = new Label(labelText4, 0, 250, 504, 300, Font.Helvetica, 18, TextAlign.Center);
            page.Elements.Add(label4);

            string labelText5 = $"{_fieldOfStudy}";
            Label label5 = new Label(labelText5, 0, 310, 504, 300, Font.Helvetica, 40, TextAlign.Center);
            page.Elements.Add(label5);

            string labelText6 = $"\n\non {_graduationDate}";
            Label label6 = new Label(labelText6, 0, 380, 504, 300, Font.Helvetica, 18, TextAlign.Center);
            page.Elements.Add(label6);

            string labelText7 = $"\nto {_name}";
            Label label7 = new Label(labelText7, 0, 420, 504, 300, Font.Helvetica, 35, TextAlign.Center);
            page.Elements.Add(label7);

            document.Draw($"{_fileName}.pdf");
        }

        public override string ReturnCertificateInfo()
        {
            return $"Educational Certificate|{_name}|{_institution}|{_fieldOfStudy}|{_graduationDate}";
        }
    }

    public class ProfessionalCertificate : Certificate
    {
        private string _organization;
        private string _certificationName;
        private string _certificationDate;

        public ProfessionalCertificate(string name, string date,string fileName,string organization, string certificationName,string certificationDate) : base(name,date, fileName)
        {
            this._organization = organization;
            this._certificationName = certificationName;
            this._certificationDate = certificationDate;
        }

        public override void CreatePDF()
        {
            Document document = new Document();

            Page page = new Page(PageSize.Letter, PageOrientation.Portrait, 54.0f);
            document.Pages.Add(page);

            string labelText0 = $"_____________________________________________\n\n{_date}";
            Label label0 = new Label(labelText0, 0, 100, 504, 100, Font.Helvetica, 20, TextAlign.Right);
            page.Elements.Add(label0);

            string labelText = "PROFESSIONAL";
            Label label = new Label(labelText, 0, 0, 504, 100, Font.Helvetica, 48, TextAlign.Center);
            label.TextColor = RgbColor.Red;
            page.Elements.Add(label);

            string labelText2 = "CERTIFICATE";
            Label label2 = new Label(labelText2, 0, 60, 504, 100, Font.Helvetica, 25, TextAlign.Center);
            label2.TextColor = RgbColor.Red;
            page.Elements.Add(label2);

            string labelText3 = $"\n{_organization}";
            Label label3 = new Label(labelText3, 0, 150, 504, 300, Font.Helvetica, 40, TextAlign.Center);
            page.Elements.Add(label3);

            string labelText4 = $"\ngrants a certificate to";
            Label label4 = new Label(labelText4, 0, 250, 504, 300, Font.Helvetica, 18, TextAlign.Center);
            page.Elements.Add(label4);

            string labelText5 = $"{_name}";
            Label label5 = new Label(labelText5, 0, 310, 504, 300, Font.Helvetica, 40, TextAlign.Center);
            page.Elements.Add(label5);

            string labelText6 = $"\nfor complete";
            Label label6 = new Label(labelText6, 0, 380, 504, 300, Font.Helvetica, 18, TextAlign.Center);
            page.Elements.Add(label6);

            string labelText7 = $"\n{_certificationName}";
            Label label7 = new Label(labelText7, 0, 410, 504, 300, Font.Helvetica, 35, TextAlign.Center);
            page.Elements.Add(label7);

            string labelText8 = $"\non {_certificationDate}";
            Label label8 = new Label(labelText8, 0, 480, 504, 300, Font.Helvetica, 20, TextAlign.Center);
            page.Elements.Add(label8);

            document.Draw($"{_fileName}.pdf");
        }

        public override string ReturnCertificateInfo()
        {
            return $"Professional Certificate|{_name}|{_organization}|{_certificationName}|{_certificationDate}";
        }
    }

    public class AchievementCertificate : Certificate
    {
        private string _description;

        public AchievementCertificate(string name, string date,string fileName,string description) : base(name,date,fileName)
        {
            this._description = description;
        }

        public override void CreatePDF()
        {
           Document document = new Document();

            Page page = new Page(PageSize.Letter, PageOrientation.Portrait, 54.0f);
            document.Pages.Add(page);

            string labelText0 = $"_____________________________________________\n\n{_date}";
            Label label0 = new Label(labelText0, 0, 100, 504, 100, Font.Helvetica, 20, TextAlign.Right);
            page.Elements.Add(label0);

            string labelText = "CERTIFICATE";
            Label label = new Label(labelText, 0, 0, 504, 100, Font.Helvetica, 48, TextAlign.Center);
            label.TextColor = RgbColor.Red;
            page.Elements.Add(label);

            string labelText2 = "OF ACHIEVEMENT";
            Label label2 = new Label(labelText2, 0, 60, 504, 100, Font.Helvetica, 25, TextAlign.Center);
            label2.TextColor = RgbColor.Red;
            page.Elements.Add(label2);

            string labelText3 = $"\nProudly Presented To";
            Label label3 = new Label(labelText3, 0, 150, 504, 300, Font.Helvetica, 25, TextAlign.Center);
            page.Elements.Add(label3);

            string labelText4 = $"\n{_name}";
            Label label4 = new Label(labelText4, 0, 200, 504, 300, Font.Helvetica, 30, TextAlign.Center);
            page.Elements.Add(label4);

            string labelText5 = $"{_description}";
            Label label5 = new Label(labelText5, 0, 310, 504, 300, Font.Helvetica, 25, TextAlign.Center);
            page.Elements.Add(label5);

            document.Draw($"{_fileName}.pdf");
        }
    
        public override string  ReturnCertificateInfo()
        {
            return $"Achievement Certificate|{_name}|{_description}";
        }
    }
}