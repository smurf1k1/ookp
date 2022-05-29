namespace lab2.Dal
{
    public class DbInitializer
    {
        public static void Initialize(ParkingDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
