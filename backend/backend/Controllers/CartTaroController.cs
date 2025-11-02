using Microsoft.AspNetCore.Mvc;
using Entities.DTO;
using Repository;
using Entities.Models;
using AutoMapper;
using Contracts.Interface;

namespace backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CartTaroController : ControllerBase
{
    private readonly IRepositoryManager _repositoryManager;
    private readonly IMapper _mapper;
    private readonly ILogger<RepositoryManager> _logger;

    public CartTaroController(IRepositoryManager repositoryManager, IMapper mapper, ILogger<RepositoryManager> logger)
    {
        _repositoryManager = repositoryManager;
        _mapper = mapper;
        _logger = logger;
    }

    [HttpPost("CreateNewCartTaro")]
    public async Task<IActionResult> CreateNewCartTaro(DtoCartTaroCreate dtoCartTaroCreate)
    {
        try
        {
            _logger.LogInformation("POST запит отримано"); // ✅ Перевіряємо чи доходить запит

            if (dtoCartTaroCreate == null)
            {
                _logger.LogError("DtoCartTaroCreate object is null");
                return BadRequest(new { error = "Data is null" }); // ✅ JSON відповідь
            }

            _logger.LogInformation("Отримані дані: {@DTO}", dtoCartTaroCreate); // ✅ Дивимось що прийшло

            // Перевіряємо чи не пусті основні поля
            if (string.IsNullOrWhiteSpace(dtoCartTaroCreate.Name))
            {
                _logger.LogWarning("⚠Name is empty");
                return BadRequest(new { error = "Name is required" });
            }

            var entityCartTaro = _mapper.Map<CartTaro>(dtoCartTaroCreate);
            _logger.LogInformation("Mapper працює: {@Entity}", entityCartTaro);

            _repositoryManager.CartTaro.AddCartTaro(entityCartTaro);
            await _repositoryManager.SaveAsync();

            _logger.LogInformation("CartTaro успішно збережено з ID: {Id}", entityCartTaro.Id);
            return Ok(new { message = "CartTaro created successfully", id = entityCartTaro.Id });
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Помилка при створенні CartTaro");
            return StatusCode(500, new { error = "Internal server error", details = ex.Message });
        }
    }

    [HttpGet("GetAllCartTaro")]
    public async Task<IActionResult> GetAllCartTaro()
    {
        
        try
        {
            var cartTaros = await _repositoryManager.CartTaro.GetAllCartTaro();
            var dtoCartTaros = _mapper.Map<IEnumerable<DtoCartTaro>>(cartTaros);
            return Ok(dtoCartTaros);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Помилка при отриманні CartTaro");
            return StatusCode(500, new { error = "Internal server error", details = ex.Message });
        }
    }

}