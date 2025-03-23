using AutoTrade.Model;
using AutoTrade.Services;
using MapsterMapper;
using Microsoft.AspNetCore.Mvc;
using Request;
using SearchObject;

namespace Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoodTrackerController : BaseCRUDController<MoodTracker, MoodTrackerSerachObject, MoodTrackerUpsertRequest, MoodTrackerUpsertRequest>
    {

        protected IMoodTrackerService _service;
        private readonly IMapper _mapper;
        public MoodTrackerController(IMoodTrackerService service, IMapper mapper) : base(service)
        {
            _service = service;
            _mapper =mapper;
        }
    }
}