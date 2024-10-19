namespace Domain.Events
{
    public class PatientRegistered
    {
        public Guid PatientId { get; set; }
        public DateTime RegisteredAt { get; set; }
    }
}