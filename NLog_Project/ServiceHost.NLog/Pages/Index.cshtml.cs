using Microsoft.AspNetCore.Mvc.RazorPages;
using NLog;

namespace ServiceHost.NLog.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private static readonly Logger nlog = LogManager.GetCurrentClassLogger();
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            for (int i = 0; i < 200; i++)
            {
                nlog.Info($"Will Save In DataBase {i}");
            }
            /*       #region Information
                   nlog.Info("Request Ended...");
                   #endregion

                   #region Warning
                   string? username = null;
                   if (username is null)
                       nlog.Warn("User Not Found...");
                   #endregion

                   #region Error
                   try
                   {
                       throw new Exception();
                   }
                   catch (Exception ex)
                   {
                       nlog.Error(ex, "Error Type 1...");
                   }
                   #endregion 

                   #region Debug&trace
                   int a = 10, b = 5;
                   int c = a + b;
                   nlog.Debug("Sum Of 2 Numbers"); //فرایند
                   nlog.Trace($"c = {c}"); //نتیجه فرایند
                   #endregion

                   #region Critical
                   try
                   {
                       throw new Exception();
                   }
                   catch (Exception ex)
                   {
                       nlog.Fatal(ex, "Example: Can not connect To DataBase...");
                   }
                   #endregion*/
        }
    }
}
