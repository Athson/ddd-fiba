namespace ddd_fiba.archetype.QuickLaunch
{
    public interface QuickLaunchCPI
    {
        Task<ILaunchController> RequestLaunchControllerAsync(AccessContext context);
    }
}
