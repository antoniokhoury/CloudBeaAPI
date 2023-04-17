namespace CloudBeatAPI.Models
{
    public class PatientRecord
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime StudyStartTime { get; set; }
        public DateTime StudyEndTime { get; set; }
        public int DeviceId { get; set; }
        public DeviceRecord Device { get; set; }
        public ICollection<EventRecord> Events { get; set; }
    }

    public class PatientDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime StudyStartTime { get; set; }
        public DateTime StudyEndTime { get; set; }
        public int DeviceId { get; set; }
        public DeviceDto Device { get; set; }
        public ICollection<EventDto> Events { get; set; }
    }
}