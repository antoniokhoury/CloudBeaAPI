using AutoMapper;
using CloudBeatAPI.Contexts;
using CloudBeatAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CloudBeatAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PatientsController : ControllerBase
    {
        private readonly CloudBeatDbContext _context;
        private readonly IMapper _mapper;
        public PatientsController(CloudBeatDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        [Produces("application/json")]
        public IEnumerable<PatientDto> Get()
        {
            var patientRecords = _context.Patients
                .Include(p => p.Device)
                .Include(p => p.Events)
                .ToList();

            var patientRecordDtos = _mapper.Map<List<PatientDto>>(patientRecords);

            return patientRecordDtos;
        }
    }
}