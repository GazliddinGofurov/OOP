namespace _Demo
{
    public class EmailGenerator
    {
        public void SendEmailToUser(object sender, UserArgs e)
        {
            Console.WriteLine($"Email sent to User {e.Name}");
        } 
    }
}