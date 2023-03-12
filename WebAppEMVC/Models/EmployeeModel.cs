using WebAppEMVC.Models;


namespace WebAppEMVC.Models
{
    public class EmployeeModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }

 }
