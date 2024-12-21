namespace WebApp.Models;

public partial class Calendar
{
    public int Id { get; set; }

    public DateOnly ExceptionDateExceptionDate { get; set; }

    public bool IsWorkingDay { get; set; }
}
