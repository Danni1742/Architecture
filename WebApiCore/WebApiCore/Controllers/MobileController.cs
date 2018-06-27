using Microsoft.AspNetCore.Mvc;
using WebApiCore.Interfaces;
using WebApiCore.Models;

namespace WebApiCore.Controllers
{
    [Route("api/Mobile")]
    public class MobileController : Controller
    {
        private IMobileService _mobileService;

        public MobileController(IMobileService mobileService)
        {
            _mobileService = mobileService;
        }

        [HttpGet]
        [Route("/api/Mobile/GetMobileInfo")]
        public IActionResult GetMobileInfo()
        {
            var mobileModel = _mobileService.GetPhone();
            return Ok(mobileModel);
        }

        [HttpPost]
        [Route("/api/Mobile/PostMobileInfo")]
        public IActionResult PostMobileInfo([FromBody]MobileModel mobileModel)
        {
            if (mobileModel != null)
            {
                var mobileModelDto = new MobileModel
                {
                    Brand = $"[Stub from Server] {mobileModel.Brand}",
                    Model = $"[Stub from Server] {mobileModel.Model}",
                    Display = mobileModel.Display + 1
                };
                return Ok(mobileModelDto);
            }
            else return BadRequest();
        }
    }
}