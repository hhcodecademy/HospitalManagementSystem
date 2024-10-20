using HospitalManagementSystem.BLL.Services.Interfaces;
using HospitalManagementSystem.DAL.Dtos;
using HospitalManagementSystem.DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManagementSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HospitalsController : ControllerBase
    {
        private readonly IGenericService<HospitalDto, Hospital> _hospitalService;
        public HospitalsController(IGenericService<HospitalDto, Hospital> hospitalService)
        {
            _hospitalService = hospitalService;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var result = await _hospitalService.GetAsync(id);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _hospitalService.GetAllAsync();
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Post(HospitalDto dto)
        {
            var res = await _hospitalService.AddAsync(dto);
            return Ok(res);
        }
        [HttpPut]
        public async Task<IActionResult> Update(Guid id, HospitalDto dto)
        {
            var res = await _hospitalService.UpdateAsync(id,dto);
            return Ok(res);
        }
        [HttpDelete]
        public async Task<IActionResult> Remove(Guid id)
        {
           var res = await _hospitalService.Remove(id);
            return Ok(res);
        }
    }
}
