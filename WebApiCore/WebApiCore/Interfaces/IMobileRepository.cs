using WebApiCore.Models;

namespace WebApiCore.Interfaces
{
    public interface IMobileRepository
    {
        MobileModel GetPhoneFromDatabase();
    }
}