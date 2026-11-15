namespace StudentPortalUI.Models;

public class StudentModel
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Course { get; set; } = string.Empty;
    public string YearLevel { get; set; } = string.Empty;
    public string FullName => $"{FirstName} {LastName}".Trim();
}
