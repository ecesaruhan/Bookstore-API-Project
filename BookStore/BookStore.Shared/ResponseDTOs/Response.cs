using System;
namespace BookStore.Shared.ResponseDTOs
{
	public class Response<T>
	{

		public T Data { get; set; }

		public List<string> Errors { get; set; }

		public int StatusCode { get; set; }

		public bool IsSucceeded { get; set; }

		public static Response<T> Success(T data, int statusCode)
		{
			return new Response<T>
			{
				Data = data,
				StatusCode = statusCode,
				IsSucceeded = true
			};
		}

		public static Response<T> Success(int statusCode)
		{
			return new Response<T>
			{
				Data = default(T),
				StatusCode = statusCode,
				IsSucceeded = true
			};
		}

		public static Response<T> Fail(List<string> errors, int statusCode)
		{
			return new Response<T>
			{
				Errors = errors,
				StatusCode = statusCode,
				IsSucceeded = false
			};
		}

		public static Response<T> Fail(string error, int statusCode)
		{
			return new Response<T>
			{
				Errors = new List<string> { error },
				StatusCode = statusCode,
				IsSucceeded = false
			};
		}
	}
}

