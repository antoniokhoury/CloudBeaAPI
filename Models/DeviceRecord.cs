namespace CloudBeatAPI.Models
{
    public class DeviceRecord
    {
        public int Id { get; set; }
        public string SerialNumber { get; set; }
        public ICollection<PatientRecord> Patients { get; set; }
    }
    public class DeviceDto
    {
        public int Id { get; set; }
        public string SerialNumber { get; set; }
    }
}