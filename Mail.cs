using System.IO;

namespace Encoding
{
    internal class Mail
    {
        public string Subject { get; set; }

        public static Mail CreateFromFile(FileInfo fileInfo)
        {
            var mail = new Mail();
            var fileContent = File.ReadAllLines(fileInfo.FullName);
            mail.Subject = fileContent[0];

            return mail;
        }

    }
}