using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ReservationDemoApi.Models;
using System.Collections.Generic;

namespace ReservationDemoApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class ReservationController : ControllerBase
    {
        private readonly IRepository _repository;

        public ReservationController(IRepository repository) => _repository = repository;

        [HttpGet]
        public ActionResult<IEnumerable<Reservation>> Get()
        {
            return Ok(_repository.Reservations);
        }

        [HttpGet("{id}")]
        public ActionResult<Reservation> Get(int id)
        {
            if (id <= 0)
            {
                return BadRequest("ID must be greater than 0");
            }

            var reservation = _repository[id];
            if (reservation == null)
            {
                return NotFound("Reservation not found");
            }

            return Ok(reservation);
        }

        [HttpPost]
        public ActionResult<Reservation> Post([FromBody] Reservation res)
        {
            if (res == null)
            {
                return BadRequest("Reservation must be provided");
            }

            var createdReservation = _repository.AddReservation(new Reservation
            {
                Name = res.Name,
                StartLocation = res.StartLocation,
                EndLocation = res.EndLocation
            });

            return CreatedAtAction(nameof(Get), new { id = createdReservation.Id }, createdReservation);
        }

        [HttpPut("{id}")]
        public ActionResult<Reservation> Put(int id, [FromBody] Reservation res)
        {
            if (id <= 0 || res == null || id != res.Id)
            {
                return BadRequest("Invalid reservation data");
            }

            var updatedReservation = _repository.UpdateReservation(res);
            if (updatedReservation == null)
            {
                return NotFound("Reservation not found");
            }

            return Ok(updatedReservation);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (id <= 0)
            {
                return BadRequest("ID must be greater than 0");
            }

            var success = _repository.DeleteReservation(id);
            if (!success)
            {
                return NotFound("Reservation not found");
            }

            return NoContent();
        }
    }
}
