namespace Portfolio.Standard.Models
{
    public class EventLog
    {
        public int UserId { get; set; }
        public string Message { get; set; }

        public override string ToString() => base.ToString() + $"{UserId} : {Message}";
    }
}