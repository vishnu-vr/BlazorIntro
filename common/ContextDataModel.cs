namespace Common
{
    public class ContextDataModel : IContextDataModel
    {
        public string Organization { get; set; }
        public string Application { get; set; }
        public User User { get; set; }
    }

    public class User
    {
        public string Name { get; set; }
        public string UserId { get; set; }
        public string Access { get; set; }
    }
}