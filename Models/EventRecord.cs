namespace CloudBeatAPI.Models
{
    public class EventRecord
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int HeartRateBPM { get; set; }
        public DateTime Date { get; set; }
        public int PatientId { get; set; }
        public PatientRecord Patient { get; set; }
    }
    public class EventDto
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int HeartRateBPM { get; set; }
        public DateTime Date { get; set; }
    }
}