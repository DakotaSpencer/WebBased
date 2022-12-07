namespace Galleria.Data
{
    public class DbInitializer
    {
        public static void Initialize(GalleriaContext commissionContext, GalleriaContext userContext)
        {
            commissionContext.Database.EnsureCreated();
            userContext.Database.EnsureCreated();

            SetupCommissions(commissionContext);
            SetupUsers(userContext);
        }

        public static void SetupCommissions(GalleriaContext context)
        {
            if (context.Commissions.Any())
            {
                return;
            }
        }

        public static void SetupUsers(GalleriaContext userContext)
        {
            if (userContext.Users.Any())
            {
                return;
            }
        }
    }
}
