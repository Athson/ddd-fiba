using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace ddd_fiba.archetype.Mvc.Controllers
{

    [Route("api")]
    [EnableCors("ClientCORS")]
    public class ApiControllerBase : Controller
    {

    }
}
