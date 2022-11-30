namespace Galleria.Data
{
    public class DbInitializer
    {
        public static void Initialize(CommissionContext commissionContext, CommissionContext userContext)
        {
            commissionContext.Database.EnsureCreated();
            userContext.Database.EnsureCreated();

            SetupCommissions(commissionContext);
            SetupUsers(userContext);
        }

        public static void SetupCommissions(CommissionContext commissionContext)
        {
            if (commissionContext.Commissions.Any())
            {
                return;
            }
        }

        public static void SetupUsers(CommissionContext userContext)
        {
            if (userContext.Users.Any())
            {
                return;
            }
        }
    }
}
