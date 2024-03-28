using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;

namespace Asp_core_Razor_applictaion.Pages
{
    public class IndexModel : PageModel
    {
        public required List<DefaultData> DataSource { get; set; }

        public void OnGet()
        {
            DataSource = GetDefaultData();
        }

        public List<DefaultData> GetDefaultData()
        {
            List<DefaultData> DefaultData =
            [
                new() {
                    Id = 1,
                    Subject = "Event-1",
                    StartTime = new DateTime(2023, 4, 1, 1, 0, 0),
                    EndTime = new DateTime(2023, 4, 1, 5, 0, 0),
                    IsAllDay = false,
                },
                new() {
                    Id = 2,
                    Subject = "Event-2",
                    StartTime = new DateTime(2023, 4, 2, 1, 0, 0),
                    EndTime = new DateTime(2023, 4, 2, 5, 0, 0),
                    IsAllDay = false,
                },
                new() {
                    Id = 3,
                    Subject = "Event-3",
                    StartTime = new DateTime(2023, 4, 3, 1, 0, 0),
                    EndTime = new DateTime(2023, 4, 3, 5, 0, 0),
                    IsAllDay = false,
                }
            ];
            return DefaultData;
        }

        public class DefaultData
        {
            public int Id { get; set; }
            public required string Subject { get; set; }
            public DateTime StartTime { get; set; }
            public DateTime EndTime { get; set; }
            public bool IsAllDay { get; set; }
        }
    }
}
