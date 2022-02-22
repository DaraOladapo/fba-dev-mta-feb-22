namespace Statics
{
    public class EmailService
    {
        public static void SendEmail(string to, string from, string subject, string body)
        {
            Console.WriteLine($"Sending email to {to} from {from} with subject {subject} and body {body}");
        }
    }
}