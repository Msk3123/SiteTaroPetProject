namespace Entities.DTO;

public class DtoUser
{
    
}

public class DtoCartTaro
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string UprightMeaning { get; set; }
    public string ReversedMeaning { get; set; }
    public string Keywords { get; set; }
}

public class DtoUserCreate
{
    
}

public class DtoCartTaroCreate
{
    public string Name { get; set; }
    public string UprightMeaning { get; set; }
    public string ReversedMeaning { get; set; }
    public string Keywords { get; set; }
}