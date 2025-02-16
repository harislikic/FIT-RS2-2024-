using AutoTrade.Services.Database;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AutoTrade.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AutomobileAdEquipmentController : ControllerBase
    {
        private readonly AutoTradeContext _context;

        public AutomobileAdEquipmentController(AutoTradeContext context)
        {
            _context = context;
        }

        [HttpDelete("{automobileAdId}")]
        [Authorize]
        public async Task<IActionResult> RemoveEquipment(int automobileAdId, [FromBody] List<int> equipmentIds)
        {
            if (equipmentIds == null || !equipmentIds.Any())
            {
                return BadRequest("No equipment IDs provided.");
            }

            var equipmentToRemove = await _context.AutomobileAdEquipments
                .Where(ae => ae.AutomobileAdId == automobileAdId && equipmentIds.Contains(ae.EquipmentId))
                .ToListAsync();

            if (!equipmentToRemove.Any())
            {
                return NotFound("No matching equipment found for the provided IDs.");
            }

            _context.AutomobileAdEquipments.RemoveRange(equipmentToRemove);

            await _context.SaveChangesAsync();

            return Ok(new { message = "Equipment removed successfully.", removedEquipmentIds = equipmentIds });
        }

        [HttpPut("update-automobile")]
        [Authorize]
        public async Task<IActionResult> UpdateAutomobileForEquipment([FromBody] UpdateAutomobileRequest request)
        {
            if (request == null || request.EquipmentIds == null || !request.EquipmentIds.Any())
            {
                return BadRequest("No equipment IDs provided.");
            }

            var automobile = await _context.AutomobileAds
                .Include(a => a.AutomobileAdEquipments)
                .FirstOrDefaultAsync(a => a.Id == request.NewAutomobileAdId);

            if (automobile == null)
            {
                return NotFound($"Automobile ad with ID {request.NewAutomobileAdId} not found.");
            }

            foreach (var equipmentId in request.EquipmentIds.Distinct())
            {

                var equipmentExists = _context.Equipments.Any(e => e.Id == equipmentId);
                if (!equipmentExists)
                {
                    throw new ArgumentException($"Equipment with ID {equipmentId} does not exist.");
                }

                var existingAdEquipment = _context.AutomobileAdEquipments
                    .FirstOrDefault(ae => ae.AutomobileAdId == automobile.Id && ae.EquipmentId == equipmentId);

                if (existingAdEquipment == null)
                {
                    automobile.AutomobileAdEquipments.Add(new Database.AutomobileAdEquipment
                    {
                        EquipmentId = equipmentId,
                        AutomobileAdId = automobile.Id
                    });
                }
            }

            await _context.SaveChangesAsync();

            return Ok(new { message = "Automobile ID and equipment updated successfully.", updatedEquipmentIds = request.EquipmentIds });
        }

        public class UpdateAutomobileRequest
        {
            public int NewAutomobileAdId { get; set; }
            public List<int> EquipmentIds { get; set; }
        }

    }



}
