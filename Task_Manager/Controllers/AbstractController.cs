using Microsoft.AspNetCore.Mvc;
using Task_Manager.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using Task_Manager.Database;

namespace Task_Manager.Controllers
{
    public abstract class AbstractController<T> : ControllerBase where T : class, IIdentifiable
    {
        private readonly IGenericInMemoryRepo<T> _context;

        public AbstractController(IGenericInMemoryRepo<T> context)
        {
            _context = context;
        }
      
        [HttpGet("get-all")]
        public async Task<List<T>> GetAll()
        {
            var all = await _context.GetAllAsync();
            return all;
        }
        
        [HttpPost("delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _context.DeleteAsync(id);
            if (result)
            {
                return Ok();
            }
            return NotFound();
        }

        
        [HttpPost("create")]
        public async Task<int> Create(T entity)
        {
            return await _context.CreateAsync(entity);
        }
        

        [HttpPut("update/{id}")]
        public async Task<IActionResult> Update(int id, T entity)
        {
            var updatedEntity = await _context.UpdateAsync(id, entity);
            if (updatedEntity == null)
            {
                return NotFound();
            }
            return Ok(updatedEntity);
        }

        [HttpGet("get/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var entity = await _context.GetByIdAsync(id);
            if (entity == null)
            {
                return NotFound();
            }
            return Ok(entity);
        }
    }
}