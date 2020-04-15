namespace StravaDemo.StravaClients.Upload
{
    public class ActivityUploadDto
    {
        public string ActivityType { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int TrainerId { get; set; }

        public string DataType { get; set; }

        public int ExternalId { get; set; }

        public string FilePath { get; set; }

        public bool IsPrivate { get; set; }

        public bool IsCommute { get; set; }
    }
}
