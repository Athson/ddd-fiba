namespace ddd_fiba.archetype.Mvc.Protocols
{
    public class RequestBase
    {
    }

    public class ResponseBase
    {
        public string RequestId { get; set; }

        public string ResponseId { get; set; }

        public string ResponseCode { get; set; }

        public string ResponseMessage { get; set; }

        public string DoActions { get; set; }

        public Dictionary<string, string> Diagnostics { get; set; }
    }
}
