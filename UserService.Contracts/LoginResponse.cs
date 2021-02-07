using System.Runtime.Serialization;

namespace UserService.Contracts
{
    [DataContract]
    public class LoginResponse
    {
        [DataMember(Order = 1)]
        public bool IsSuccess { get; set; }

        [DataMember(Order = 2)]
        public string Message { get; set; }
    }
}
