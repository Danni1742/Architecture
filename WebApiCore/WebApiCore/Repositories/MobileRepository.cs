using WebApiCore.Interfaces;
using WebApiCore.Models;

namespace WebApiCore.Repositories
{
    public class MobileRepository : IMobileRepository
    {
        //stub, imitates getting data from the database
        public MobileModel GetPhoneFromDatabase()
        {
            var mobileModel = new MobileModel
            {
                Brand = "Samsung",
                Model = "Galaxy S7",
                Display = 5.5
            };

            return mobileModel;
        }
    }
}