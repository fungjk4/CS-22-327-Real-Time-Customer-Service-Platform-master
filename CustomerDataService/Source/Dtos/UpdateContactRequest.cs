using System;
using System.Runtime.Serialization;

namespace CustomerDataService.Dtos
{
    [DataContract]
    public class UpdateContactRequest
    {
        [DataMember(IsRequired = false)]
        public string? FirstName { get; set; }

        [DataMember(IsRequired = false)]
        public string? LastName { get; set; }

        [DataMember(IsRequired = false)]
        public string? PhoneNumber { get; set; }

        [DataMember(IsRequired = false)]
        public string? Email { get; set; }
    }
}
