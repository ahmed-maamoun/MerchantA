using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MerchantA.Controllers
{
    [Route("api/user/")]
    [ApiController]
    public class MerchantA : ControllerBase
    {
        [HttpPost("activate")]
        public ActionResult Activate(ActivateDTO activateDTO) {
            return Ok();
        }
        [HttpPost("terminate")]
        public ActionResult Terminate(SuspendDTO suspendDTO)
        {
            return Ok();
        }
        [HttpPost("suspend")]
        public ActionResult Suspend(SuspendDTO suspendDTO)
        {
            return Ok();
        }
        [HttpPost("reactivate")]
        public ActionResult Reactivate(SuspendDTO suspendDTO)
        {
            return Ok();
        }
    }
    public class ActivateDTO { 
        public string PhoneNumber { get; set; }
        public string Package { get; set; }
        public string OperatorName { get; set; }
    }

    public class SuspendDTO
    {
        public string PhoneNumber { get; set; }
        public string Package { get; set; }
    }
}
