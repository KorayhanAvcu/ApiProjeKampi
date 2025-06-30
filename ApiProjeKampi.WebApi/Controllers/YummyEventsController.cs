using ApiProjeKampi.WebApi.Context;
using ApiProjeKampi.WebApi.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProjeKampi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class YummyEventsController : ControllerBase
    {
        private readonly ApiContext _context;
        public YummyEventsController(ApiContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult YummyEventList()
        {
            var values = _context.YummyEvents.ToList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateYummyEvent(YummyEvent yummyevent)
        {
            _context.YummyEvents.Add(yummyevent);
            _context.SaveChanges();
            return Ok("Ekleme islemi basarili");
        }
        [HttpDelete]
        public IActionResult DeleteYummyEvent(int id)
        {
            var value = _context.YummyEvents.Find(id);
            _context.YummyEvents.Remove(value);
            _context.SaveChanges();
            return Ok("Silme işlemi başarılı");
        }
        [HttpGet("GetYummyEvent")]
        public IActionResult GetYummyEvent(int id)
        {
            var value = _context.YummyEvents.Find(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult PutYummyEvent(YummyEvent yummyevent)
        {
            _context.YummyEvents.Update(yummyevent);
            _context.SaveChanges();
            return Ok("Güncelleme basarili");
        }
    }
}
