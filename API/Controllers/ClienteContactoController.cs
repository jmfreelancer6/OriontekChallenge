using API.Dtos;
using AutoMapper;
using Domain.Core.Constract;
using Domain.Core.Entity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteContactoController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ClienteContactoController(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                return Ok(_mapper.Map<IEnumerable<ClienteContactoDto>>(await _unitOfWork.ClienteContactoRepository.GetAllAsync()));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ClienteContactoDto value)
        {
            try
            {
                if (!await _unitOfWork.ClienteContactoRepository.ValidateIfExist(value.IDCliente))
                {
                    return StatusCode(400, "Este cliente no existe.");
                }
                await _unitOfWork.ClienteContactoRepository.SaveAsync(_mapper.Map<tbl_Clientes_Contacto>(value));
                return Ok(new {Message = "Se ha guardado correctamente."});
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
            finally
            {
                await _unitOfWork.ClienteContactoRepository.SaveChangesAsync();
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] ClienteContactoDto value)
        {
            try
            {
                if (!await _unitOfWork.ClienteContactoRepository.ValidateIfExist(value.IDCliente))
                {
                    return StatusCode(400, "Este cliente no existe.");
                }
                _unitOfWork.ClienteContactoRepository.Edit(_mapper.Map<tbl_Clientes_Contacto>(value));
                return Ok(new { Message = "Se ha modificado correctamente." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
            finally
            {
                await _unitOfWork.ClienteContactoRepository.SaveChangesAsync();
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                _unitOfWork.ClienteContactoRepository.Remove(await _unitOfWork.ClienteContactoRepository.GetByIdAsync(id));
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
            finally
            {
                await _unitOfWork.ClienteContactoRepository.SaveChangesAsync();
            }
        }
    }
}
