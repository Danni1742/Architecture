using WebApiCore.Interfaces;
using WebApiCore.Models;

namespace WebApiCore.Services
{
    public class MobileService : IMobileService
    {
        private IMobileRepository _mobileRepository;

        public MobileService(IMobileRepository mobileRepository)
        {
            _mobileRepository = mobileRepository;
        }

        public MobileModel GetPhone()
        {
            var result = _mobileRepository.GetPhoneFromDatabase();

            return result;
        }
    }
}