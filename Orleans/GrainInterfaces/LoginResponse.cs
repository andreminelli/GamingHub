namespace GrainInterfaces
{
    public class LoginResponse
    {
        public bool IsSuccess => User != null;

        public IUser User { get; set; }

        public string Message { get; set; }
    }
}
