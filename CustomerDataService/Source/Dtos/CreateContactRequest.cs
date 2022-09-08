using System.Runtime.Serialization;//what does this line do?

namespace CustomerDataService.Dtos
{
    [DataContract]//what does this do?
    public class CreateContactRequest
    {
        public CreateContactRequest() { }

        public CreateContactRequest(string firstName, string lastName, string email, string phoneNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.PhoneNumber = phoneNumber;
        }

        [DataMember(IsRequired = false)]//why do we have 2 setters&getters?, In Contact.cs, we have setters&getters for each of those fields
        public string FirstName { get; set; }

        [DataMember(IsRequired = false)]
        public string LastName { get; set; }

        [DataMember(IsRequired = false)]
        public string PhoneNumber { get; set; }

        [DataMember(IsRequired = false)]
        public string Email { get; set; }
    }
}
