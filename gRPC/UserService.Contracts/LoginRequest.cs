using System.Runtime.Serialization;

namespace UserService.Contracts
{
    [DataContract]
    public class LoginRequest
    {
        [DataMember(Order = 1)]
        public string Name { get; set; }
    }
}
