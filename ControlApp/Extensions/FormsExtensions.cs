namespace ControlApp.Extensions;

public static class FormsExtensions
{
    public static void ChangeForm<TNewForm>(this Form formSender, string? name = null)
        where TNewForm : Form
    {
        Program.ChangeForm<TNewForm>(name);
        formSender.Close();
    }
}
