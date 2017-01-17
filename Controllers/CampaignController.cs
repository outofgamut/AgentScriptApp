using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AgentScriptApp.Repository;
using AgentScriptApp.Models;

namespace AgentScriptApp.Controllers
{
    [Route("api/[controller]")]
    public class CampaignController : Controller
    {

        public ICampaignRepository CampaignRepo { get; set; }
 
        public CampaignController(ICampaignRepository _repo)
        {
            CampaignRepo = _repo;
        }
        
        [HttpGet]
        public IEnumerable<Campaign> GetAll()
        {
            return CampaignRepo.GetAll();
        }
 
        [HttpGet("{id}", Name = "GetCampaign")]
        public IActionResult GetById(string id)
        {
            var item = CampaignRepo.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }
 
        [HttpPost]
        public IActionResult Create([FromBody] Campaign item)
        {
            if (item == null)
            {
                return BadRequest();
            }
            CampaignRepo.Add(item);
            return CreatedAtRoute("GetCampaign", new { Controller = "Campaign", id = item.ID }, item);
        }
 
        [HttpPut("{id}")]
        public IActionResult Update(string id, [FromBody] Campaign item)
        {
            if (item == null)
            {
                return BadRequest();
            }
            var campaignObj = CampaignRepo.Find(id);
            if (campaignObj == null)
            {
                return NotFound();
            }
            CampaignRepo.Update(item);
            return new NoContentResult();
        }
 
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            CampaignRepo.Remove(id);
        }
    }
}