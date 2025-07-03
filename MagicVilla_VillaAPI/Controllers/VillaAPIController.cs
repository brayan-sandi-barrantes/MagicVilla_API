using MagicVilla_VillaAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_VillaAPI.Controllers
{
    [Route("api/VillaAPI")]
    [ApiController]
    public class VillaAPIController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<VillaModel> GetVillas()
        {
            return new List<VillaModel>
            {
                new VillaModel { Id = 1, Name = "Villa 1" },
                new VillaModel { Id = 2, Name = "Villa 2" }
            };
        }
    }
}
