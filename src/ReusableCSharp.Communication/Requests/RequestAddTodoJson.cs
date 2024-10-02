namespace ReusableCSharp.Communication.Requests
{
    public class RequestAddTodoJson
    {
        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public bool IsCompleted { get; set; } = false;

        public DateTime CreationDate { get; set; } = DateTime.Now;

    }
}
