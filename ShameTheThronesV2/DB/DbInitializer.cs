namespace ShameTheThronesV2.DB
{
    public static class DbInitializer
    {
          public static void Initialize(ShameTheThronesContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}