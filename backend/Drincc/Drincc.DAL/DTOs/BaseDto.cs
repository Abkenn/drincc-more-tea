﻿namespace Drincc.DAL.DTOs
{
    public class BaseDto<T>
    {
        public object? Payload { get; set; }

        public BaseDto(T data)
           => Payload = data;
    }
}
