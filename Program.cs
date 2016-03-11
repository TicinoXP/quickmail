using System;
using System.Collections.Generic;
using System.Net.Mail;

namespace Encoding
{
    class Program
    {
        const string EmailStoragePath = "../../mails";
        const string SubjectsFile = "../../subjects.txt";
            
        static void Main(string[] args)
        {
            var emailQuickReader = new EmailQuickReader(EmailStoragePath, SubjectsFile);
            
            emailQuickReader.ReadEmails();
            emailQuickReader.PrintSubjects();
            emailQuickReader.ExportSubjectsToFile(SubjectsFile, System.Text.Encoding.UTF8);

            Console.WriteLine("Done");
            Console.ReadLine();

        }
    }
}
