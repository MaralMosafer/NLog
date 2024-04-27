using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Logging.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger; //دسترسی به ای پی آی ثبت لاگ

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            //ثبت لاگ
            //_logger.Log(logLevel:LogLevel.Information,message: "Request Strated...");

            //Extension Method:

            #region Information
            _logger.LogInformation("Request Ended...");
            #endregion

            #region Warning
            string? username = null;
            if (username is null)
                _logger.LogWarning("User Not Found...");
            #endregion

            #region Error
            try
            {
                throw new Exception();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error...");
            }
            #endregion

            #region Debug&trace
            int a = 10, b = 5;
            int c = a + b;
            _logger.LogDebug("Sum Of 2 Numbers"); //فرایند
            _logger.LogTrace($"c = {c}"); //نتیجه فرایند
            #endregion

            #region Critical
            try
            {
                throw new Exception();
            }
            catch (Exception ex)
            {
                _logger.LogCritical(ex, "Example: Can not connect To DataBase...");
            }
            #endregion
        }
    }
}
