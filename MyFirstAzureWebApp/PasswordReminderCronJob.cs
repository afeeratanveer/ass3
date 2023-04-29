using System;
using System.Net;
using System.Net.Mail;
using NCrontab;

public class PasswordReminderCronJob
{
    public static void Main()
    {
        var schedule = CrontabSchedule.Parse("* * * * *");
        var nextRunTime = schedule.GetNextOccurrence(DateTime.Now);

        while (true)
        {
            if (DateTime.Now > nextRunTime)
            {
                SendPasswordReminderEmail();
                nextRunTime = schedule.GetNextOccurrence(DateTime.Now);
            }
        }
    }

    private static void SendPasswordReminderEmail()
    {
        // Replace with the appropriate email address for the user whose password needs to be reset
        string toAddress = "user@example.com";
        string subject = "Password Reminder";
        string body = "This is a reminder to reset your password.";

        using (MailMessage message = new MailMessage())
        {
            message.To.Add(toAddress);
            message.Subject = subject;
            message.Body = body;

            using (SmtpClient client = new SmtpClient("smtp.gmail.com", 587))
            {
                // Replace with the appropriate email credentials
                string fromAddress = "your_email@gmail.com";
                string password = "your_password";

                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential(fromAddress, password);
                client.EnableSsl = true;

                client.Send(message);
            }
        }
    }
}
