namespace Common
{
    public interface IContextDataModel
    {
        string Application { get; set; }
        string Organization { get; set; }
        User User { get; set; }
    }
}