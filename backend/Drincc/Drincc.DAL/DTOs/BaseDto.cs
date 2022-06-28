namespace Drincc.DAL.DTOs
{
    public class BaseDto
    {
        public object? Payload { get; set; }

        public BaseDto(object data)
           => Payload = data;
    }
}
