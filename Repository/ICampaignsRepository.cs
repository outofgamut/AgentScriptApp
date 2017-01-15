using AgentScriptApp.Models;
using System.Collections.Generic;

namespace AgentScriptApp.Repository
{
    public interface ICampaignsRepository
    {
        void Add(Campaign item);
        IEnumerable<Campaign> GetAll();
        Campaign Find(string key);
        void Remove(string Id);
        void Update(Campaign item);
    }
}