namespace ExceptionHandlingWithResultPattern.Api.Models.Responses;

public class ResponseModelDto
{
    public ResponseModelDto()
    {}
    public ResponseModelDto(string userId, string name)
    {
        UserId = userId;
        Name = name;
    }

    
    public string Id { get; set; }
    public string UserId { get; set; }
    public string Name { get; set; }
}