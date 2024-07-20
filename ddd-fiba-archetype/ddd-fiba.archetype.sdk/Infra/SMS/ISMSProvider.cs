namespace ddd_fiba.archetype.Infra.SMS
{
    public interface ISMSProvider
    {
        ISMSController CreateController(string channel);
    }
}
