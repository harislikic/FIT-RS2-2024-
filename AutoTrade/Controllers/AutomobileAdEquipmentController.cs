using AutoTrade.Model;
using AutoTrade.Services.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        public async Task<IActionResult> UpdateAutomobileForEquipment([FromBody] UpdateAutomobileRequest request)
        {
            // Validacija ulaznih parametara
            if (request == null || request.EquipmentIds == null || !request.EquipmentIds.Any())
            {
                return BadRequest("No equipment IDs provided.");
            }

            // Pronađi automobil oglas na osnovu prosleđenog NewAutomobileAdId
            var automobile = await _context.AutomobileAds
                .Include(a => a.AutomobileAdEquipments)
                .FirstOrDefaultAsync(a => a.Id == request.NewAutomobileAdId);

            if (automobile == null)
            {
                return NotFound($"Automobile ad with ID {request.NewAutomobileAdId} not found.");
            }

            // Dodaj novu opremu ako ne postoji
            foreach (var equipmentId in request.EquipmentIds.Distinct())
            {
                // Proveri da li oprema postoji
                var equipmentExists = _context.Equipments.Any(e => e.Id == equipmentId);
                if (!equipmentExists)
                {
                    throw new ArgumentException($"Equipment with ID {equipmentId} does not exist.");
                }

                // Proveri da li entitet već postoji u bazi
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

            // Sačuvaj izmene u bazi
            await _context.SaveChangesAsync();

            return Ok(new { message = "Automobile ID and equipment updated successfully.", updatedEquipmentIds = request.EquipmentIds });
        }


        // DTO klasa za ulazne podatke
        public class UpdateAutomobileRequest
        {
            public int NewAutomobileAdId { get; set; }
            public List<int> EquipmentIds { get; set; }
        }

    }



}
