using System.Collections.Generic;
using System.Linq;
using AgentScriptApp.Models;
using AgentScriptApp.Data;

namespace AgentScriptApp.Repository
{
    public class CampaignRepository : ICampaignRepository
    {
        CallCenterContext _context;
        public CampaignRepository(CallCenterContext context)
        {
            _context = context;
        }
        static List<Campaign> CampaignList = new List<Campaign>();

        public void Add(Campaign item)
        {
            //ContactsList.Add(item);
            _context.Campaigns.Add(item);
            _context.SaveChanges();
        }

        public Campaign Find(string key)
        {
            // ToDo - Integrate with EF Core, DbSet.Find not available yet
            return CampaignList
                .Where(e => e.ID.Equals(key))
                .SingleOrDefault();
        }

        public IEnumerable<Campaign> GetAll()
        {
            //ContactsList.Add(new Contacts() {FirstName ="Mithun", MobilePhone = "2345" });

            return _context.Campaigns.ToList();
        }

        public void Remove(string Id)
        {
            // ToDo - Integrate with EF Core
            var itemToRemove = CampaignList.SingleOrDefault(r => r.ID.ToString() == Id);
            if (itemToRemove != null)
                CampaignList.Remove(itemToRemove);
        }

        public void Update(Campaign item)
        {
            // ToDo - Integrate with EF Core
            var itemToUpdate = CampaignList.SingleOrDefault(r => r.ID == item.ID);
            if (itemToUpdate != null)
            {
                itemToUpdate.Name = item.Name;
            }
        }
    }
}