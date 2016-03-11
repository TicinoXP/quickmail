using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Encoding
{
    internal class EmailQuickReader
    {
        private readonly string _emailStoragePath;
        private readonly string _subjectsFile;
        private IEnumerable<Mail> _mails;

        public EmailQuickReader(string emailStoragePath, string subjectsFile)
        {
            _emailStoragePath = emailStoragePath;
            _subjectsFile = subjectsFile;
        }

        public void ReadEmails()
        {
            var directoryInfo = new DirectoryInfo(_emailStoragePath);
            var files = directoryInfo.EnumerateFiles();
            _mails = files.Select(Mail.CreateFromFile);
        }

        public void PrintSubjects()
        {
            foreach (var mail in _mails)
            {
                Console.WriteLine(mail.Subject);
            }

        }

        public void ExportSubjectsToFile(string subjectsFile, System.Text.Encoding encoding)
        {
            var sb = new StringBuilder();

            foreach (var mail in _mails)
            {
                sb.AppendLine(mail.Subject);
            }

            File.WriteAllText(_subjectsFile, sb.ToString(), encoding);
        }
    }
}