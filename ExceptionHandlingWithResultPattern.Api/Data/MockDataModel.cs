using System.Collections.Generic;

namespace ExceptionHandlingWithResultPattern.Api.Data;

public class MockDataModel
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Uuid { get; set; }
    
    public static IEnumerable<MockDataModel> GetDatabaseExampleModels()
    {
        return new List<MockDataModel>
        { 
            new(){Id = "1903", Uuid = "d73ba23e-eb08-44be-b595-a6b79bd640af", Name = "Sen"},
            new(){Id = "1881", Uuid = "34b6fa63-0825-4002-be42-4610ed5d1e7c", Name = "Çok"},
            new(){Id = "1938", Uuid = "eee1cab0-35f1-4060-9a73-fd193ea6a6da", Name = "Yaşa"},
            new(){Id = "1923", Uuid = "18c16717-90e9-4bc7-869c-1eb1ded77f3e", Name = "Türkiye"},
            new(){Id = "2023", Uuid = "28f382a9-78fa-4321-9cef-198cb7409717", Name = "Cumhuriyeti"}
        };
    }
}