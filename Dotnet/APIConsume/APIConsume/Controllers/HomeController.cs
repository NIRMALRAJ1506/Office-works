using APIConsume.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace APIConsume.Controllers
{
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class HomeController : Controller
    {
        private readonly HttpClient _httpClient;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public HomeController(HttpClient httpClient, IHttpContextAccessor httpContextAccessor)
        {
            _httpClient = httpClient;
            _httpContextAccessor = httpContextAccessor;
        }

        // Display the main page
        public IActionResult Index()
        {
            return View();
        }

        // Display form to get reservation
        [HttpGet]
        public IActionResult GetReservation() => View();

        // Handle form submission to get reservation
        [HttpPost]
        public async Task<IActionResult> GetReservation(int id)
        {
            var jwt = _httpContextAccessor.HttpContext.Request.Cookies["jwtcookie"];
            Reservation reservation = new Reservation();

            try
            {
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", jwt);
                var response = await _httpClient.GetAsync($"http://localhost:5293/api/Reservation/{id}");

                if (response.IsSuccessStatusCode)
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    reservation = JsonConvert.DeserializeObject<Reservation>(apiResponse);
                }
                else
                {
                    ViewBag.StatusCode = response.StatusCode;
                    ViewBag.Message = "Failed to retrieve reservation.";
                }
            }
            catch (Exception ex)
            {
                ViewBag.Message = $"An error occurred: {ex.Message}";
            }

            return View(reservation);
        }

        // Display form to add a reservation
        [HttpGet]
        public IActionResult AddReservation() => View();

        // Handle form submission to add a reservation
        [HttpPost]
        public async Task<IActionResult> AddReservation(Reservation reservation)
        {
            var jwt = _httpContextAccessor.HttpContext.Request.Cookies["jwtcookie"];
            Reservation newBooking = new Reservation();

            try
            {
                var content = new StringContent(
                    JsonConvert.SerializeObject(reservation),
                    Encoding.UTF8,
                    "application/json");

                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", jwt);
                var response = await _httpClient.PostAsync("http://localhost:5293/api/Reservation/", content);

                if (response.IsSuccessStatusCode)
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    newBooking = JsonConvert.DeserializeObject<Reservation>(apiResponse);
                    ViewBag.Message = "Reservation added successfully.";
                }
                else
                {
                    ViewBag.Message = "Failed to add reservation.";
                }
            }
            catch (Exception ex)
            {
                ViewBag.Message = $"An error occurred: {ex.Message}";
            }

            return View(newBooking);
        }

        // Display form to update a reservation
        [HttpGet]
        public async Task<IActionResult> UpdateReservation(int id)
        {
            var jwt = _httpContextAccessor.HttpContext.Request.Cookies["jwtcookie"];
            Reservation reservation = new Reservation();

            try
            {
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", jwt);
                var response = await _httpClient.GetAsync($"http://localhost:5293/api/Reservation/{id}");

                if (response.IsSuccessStatusCode)
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    reservation = JsonConvert.DeserializeObject<Reservation>(apiResponse);
                }
                else
                {
                    ViewBag.StatusCode = response.StatusCode;
                    ViewBag.Message = "Failed to retrieve reservation.";
                }
            }
            catch (Exception ex)
            {
                ViewBag.Message = $"An error occurred: {ex.Message}";
            }

            return View(reservation);
        }

        // Handle form submission to update a reservation
        [HttpPost]
        public async Task<IActionResult> UpdateReservation(Reservation reservation)
        {
            var jwt = _httpContextAccessor.HttpContext.Request.Cookies["jwtcookie"];
            Reservation updatedBooking = new Reservation();

            try
            {
                var content = new StringContent(
                    JsonConvert.SerializeObject(reservation),
                    Encoding.UTF8,
                    "application/json");

                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", jwt);
                var response = await _httpClient.PutAsync($"http://localhost:5293/api/Reservation/{reservation.Id}", content);

                if (response.IsSuccessStatusCode)
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    updatedBooking = JsonConvert.DeserializeObject<Reservation>(apiResponse);
                    ViewBag.Result = "Reservation updated successfully.";
                }
                else
                {
                    ViewBag.Message = "Failed to update reservation.";
                }
            }
            catch (Exception ex)
            {
                ViewBag.Message = $"An error occurred: {ex.Message}";
            }

            return View(updatedBooking);
        }

        // Handle form submission to delete a reservation
        [HttpPost]
        public async Task<IActionResult> DeleteReservation(int id)
        {
            var jwt = _httpContextAccessor.HttpContext.Request.Cookies["jwtcookie"];

            try
            {
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", jwt);
                var response = await _httpClient.DeleteAsync($"http://localhost:5293/api/Reservation/{id}");

                if (response.IsSuccessStatusCode)
                {
                    ViewBag.Message = "Reservation deleted successfully.";
                }
                else
                {
                    ViewBag.Message = "Failed to delete reservation.";
                }
            }
            catch (Exception ex)
            {
                ViewBag.Message = $"An error occurred: {ex.Message}";
            }

            return RedirectToAction("Index");
        }

        // Retrieve and display all reservations
        [HttpGet]
        public async Task<IActionResult> ReservationsList()
        {
            var jwt = _httpContextAccessor.HttpContext.Request.Cookies["jwtcookie"];
            List<Reservation> reservations = new List<Reservation>();

            try
            {
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", jwt);
                var response = await _httpClient.GetAsync("http://localhost:5293/api/Reservation");

                if (response.IsSuccessStatusCode)
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    reservations = JsonConvert.DeserializeObject<List<Reservation>>(apiResponse);
                }
                else
                {
                    ViewBag.Message = "Failed to retrieve reservations.";
                }
            }
            catch (Exception ex)
            {
                ViewBag.Message = $"An error occurred: {ex.Message}";
            }

            return View(reservations);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = HttpContext.TraceIdentifier });
        }
    }
}
