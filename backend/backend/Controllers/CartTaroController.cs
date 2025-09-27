using Microsoft.AspNetCore.Mvc;
using Entities.DTO;
using Repository;
using Entities.Models;
using AutoMapper;

namespace backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CartTaroController : ControllerBase
{
    private readonly RepositoryManager _repositoryManager;
    private readonly IMapper _mapper;
    private readonly ILogger<RepositoryManager> _logger;

    public CartTaroController(RepositoryManager repositoryManager, IMapper mapper, ILogger<RepositoryManager> logger)
    {
        _repositoryManager = repositoryManager;
        _mapper = mapper;
        _logger = logger;
    }

    [HttpPost]
    public async Task<IActionResult> CreateNewCartTaro(DtoCartTaroCreate dtoCartTaroCreate)
    {
        if (dtoCartTaroCreate == null)
        {
            _logger.LogError("DtoCartTaroCreate object sent from client is null.");
            return BadRequest("Data is null");  // ✅ Повертаємо результат
        }

        var entityCartTaro = _mapper.Map<CartTaro>(dtoCartTaroCreate); 
        _repositoryManager.CartTaro.AddCartTaro(entityCartTaro);
        await _repositoryManager.SaveAsync();
        string result = "CartTaro created";
        return Ok(result);

    }
}