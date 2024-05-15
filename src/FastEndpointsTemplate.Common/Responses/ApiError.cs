namespace FastEndpointsTemplate.Common.Responses;

public class ApiError
{
    public required string Code { get; set; }
    public required string Description { get; set; }
}