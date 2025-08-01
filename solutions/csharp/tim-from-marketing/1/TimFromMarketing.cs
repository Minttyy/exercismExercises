static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        if (department != null){
            department = department.ToUpper();
        }
        
        string message = "";

        if ((id != null) && (department == null))
        {
            message = $"[{id}] - {name} - OWNER";
        }
        else if ((id == null) && (department != null))
        {
            message = $"{name} - {department}";
        }
        else if ((id == null) && (department == null))
        {
            message = $"{name} - OWNER";
        }
        else{
            message = $"[{id}] - {name} - {department}";
        }

        

        return message;
        
    }
}
