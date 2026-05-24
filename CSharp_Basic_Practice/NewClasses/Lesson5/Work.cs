public struct Work
{
    public string Role;
    public string Company;

    public Work(string role, string company)
    {
        Role = role;
        Company = company;
    }

    public override string ToString() => $"{Role} at {Company}";
}