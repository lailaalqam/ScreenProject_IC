using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ScreenProject.Interface;
using ScreenProject.Models;
using ScreenProject.ViewModles;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ScreenProject.Controllers
{
    [Route("api/[controller]")]
    public class EventController : Controller
    {

        public readonly IEventRepo _IeventRepo;
        public readonly IMapper _iMapper;


        public EventController(IEventRepo IeventRepo, IMapper iMapper)


        {
            _IeventRepo = IeventRepo;
            _iMapper = iMapper;
        }

        // GET: api/<controller>
        [HttpGet("Annual")]
        public DateTime Get()
        {
            return _IeventRepo.GetALL();
        }

        [HttpGet]
        public ActionResult<List<EventViewModles>> Annual()
        {

            List<Event> events = _IeventRepo.GetAnnualMonthlyDailyAndOnce();

            List<EventViewModles> eventViewModles = _iMapper.Map<List<EventViewModles>>(events);
            return eventViewModles;


        }



        [HttpGet("Anal")]
        public List<Event> GetAllAnnual()
        {

           List < Event > events = _IeventRepo.GetAnnualMonthlyDailyAndOnce();

            
            return events;


        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
