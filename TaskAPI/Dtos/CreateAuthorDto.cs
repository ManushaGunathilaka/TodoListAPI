using System.ComponentModel.DataAnnotations;
using TaskAPI.Models;

namespace TaskAPI.Dtos
{
    public class CreateAuthorDto
    {
        public string FullName { get; set; }
        public string AddressNo { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string JobRole { get; set; }
    }
}
