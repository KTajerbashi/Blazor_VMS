﻿namespace Blazor_Application_Library.Models.General
{
    public interface IResult<TData>
    {
        TData Data { get; }
    }
    public class Result<TData> : IResult<TData>
    {
        public TData Data { get; set; }
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public object? Response { get; set; }
        //public List<string>? Messages { get; set; }
    }
    public class Result<TInput, TOutput> : Result<TInput>
    {
        public TOutput Output { get; set; }
    }

}
