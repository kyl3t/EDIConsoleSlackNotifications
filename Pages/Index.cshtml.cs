using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EDIConsoleSlackNotifications.Notifications;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace EDIConsoleSlackNotifications.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly INotificationService _notificationService;

        public IndexModel(ILogger<IndexModel> logger, INotificationService notificationService)
        {
            _logger = logger;
            _notificationService = notificationService;
        }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            ChangeStage();
        }

        public void ChangeStage(string nextStage = "Go Live Checklist", string iaName = "Melvin")
        {
            _notificationService.Send(new NotificationParams
            {
                Name = "New connection live",
                Body = $"Moved into Go live checklist by {iaName}"
            });
        }
    }
}
