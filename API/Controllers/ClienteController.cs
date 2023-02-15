using API.Dtos;
using AutoMapper;
using Domain.Core.Contracts;
using Domain.Core.Entity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ClienteController(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        // GET: api/<ClienteController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                return Ok(_mapper.Map<IEnumerable<ClienteDto>>(await _unitOfWork.ClienteRepository.GetAllAsync()));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // GET api/<ClienteController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                return Ok(_mapper.Map<IEnumerable<ClienteDto>>(await _unitOfWork.ClienteRepository.GetByIdAsync(id)));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // POST api/<ClienteController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ClienteDto value)
        {
            try
            {
                await _unitOfWork.ClienteRepository.SaveAsync(_mapper.Map<tbl_Clientes>(value));
                return Ok(new { Message = "Se ha guardado correctamente." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
            finally
            {
                await _unitOfWork.ClienteRepository.SaveChangesAsync();
            }
        }

        // PUT api/<ClienteController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] ClienteDto value)
        {
            try
            {
                _unitOfWork.ClienteRepository.Edit(_mapper.Map<tbl_Clientes>(value));
                return Ok(new { Message = "Se ha modificado correctamente." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
            finally
            {
                await _unitOfWork.ClienteRepository.SaveChangesAsync();
            }
        }

        // DELETE api/<ClienteController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                _unitOfWork.ClienteRepository.Remove(await _unitOfWork.ClienteRepository.GetByIdAsync(id));
                return Ok(new { Message = "Se ha eliminado correctamente." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
            finally
            {
                await _unitOfWork.ClienteRepository.SaveChangesAsync();
            }
        }
    }
}
