using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AgentScriptApp.Data;

namespace AgentScriptApp.Models
{
    public static class DbInitializer
    {
        public static void Initialize(CallCenterContext context)
        {
            context.Database.EnsureCreated();

            // Look for any campaigns.
            if (context.Campaigns.Any())
            {
                return;   // DB has been seeded
            }

            var campaigns = new Campaign[]
            {
            new Campaign{Name="Campaign 1"},
            new Campaign{Name="Campaign 2"},
            new Campaign{Name="Campaign 3"},
            new Campaign{Name="Campaign 4"},
            new Campaign{Name="Campaign 5"},
            new Campaign{Name="Campaign 6"},
            new Campaign{Name="Campaign 7"},
            new Campaign{Name="Campaign 8"},
            new Campaign{Name="Campaign 9"},
            new Campaign{Name="Campaign 10"},
            new Campaign{Name="Campaign 11"}
            };
            foreach (Campaign c in campaigns)
            {
                context.Campaigns.Add(c);
            }
            context.SaveChanges();

            var plans = new Plan[]
            {
            new Plan{Name="Plan 1"},
            new Plan{Name="Plan 2"},
            new Plan{Name="Plan 3"},
            new Plan{Name="Plan 4"},
            new Plan{Name="Plan 5"},
            new Plan{Name="Plan 6"},
            new Plan{Name="Plan 7"},
            new Plan{Name="Plan 8"},
            };
            foreach (Plan p in plans)
            {
                context.Plans.Add(p);
            }
            context.SaveChanges();
        }
    }
}
