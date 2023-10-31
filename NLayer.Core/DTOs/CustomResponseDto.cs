using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NLayer.Core.DTOs
{
    public class CustomResponseDto<T>
    {
        public T Data { get; set; }

        [JsonIgnore]
        public int StatusCode { get; set; }

        public List<String> Errors { get; set; }

        public static CustomResponseDto<T> Success(int statusCode, T data)
        {
            return new() { Data = data, StatusCode = statusCode, Errors = null };
        }
        public static CustomResponseDto<T> Success(int statusCode)
        {
            return new() { StatusCode = statusCode };
        }
        public static CustomResponseDto<T> Fail(int statusCode, List<String> errors)
        {
            return new() { StatusCode = statusCode, Errors = errors };
        }
        public static CustomResponseDto<T> Fail(int statusCode, string errors)
        {
            return new() { StatusCode = statusCode, Errors = new List<string> { errors } };
        }

    }
}
