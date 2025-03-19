public class Email : Message
{
    public string[] Attachments { get; set; }

    public HTML[] WebContents { get; set; }

    public string Subject { get; set; }

    public string[] Cc { get; set; }
}