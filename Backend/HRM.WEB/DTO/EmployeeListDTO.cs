using Microsoft.Identity.Client;

namespace HRM.WEB.DTO
{
    public class EmployeeListDTO
    {
        public int id { get; set; }  // lowercase to match Angular
        public string? employeeName { get; set; }
        public string? designationName { get; set; }
    }
}
