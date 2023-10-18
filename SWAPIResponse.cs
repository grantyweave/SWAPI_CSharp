namespace swapi_csharp
{
    public class SWAPIResponse<T>
    {
        public List<T>? Results { get; set; }
    }
}
