using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Reporting.Business;

namespace Reporting.Ui.Pages
{
    public class IndexModel : PageModel
    {
        public List<ReportingResult> ReportingResults { get; set; }
        private readonly IReportingService _service;

        public IndexModel(IReportingService service)
        {
            _service = service;
        }

        public void OnGet()
        {
            ReportingResults = _service.GetReportingResults();
        }
    }
}
