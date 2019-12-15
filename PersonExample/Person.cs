namespace PersonExample
{
    public class Person
    {
        public string FirstName { get; }
        public string LastName { get; }
        public Gender Gender { get; }
        public string FullName => $"{FirstName} {LastName}";
        public string GenderName => GenderConverter.ToString(Gender);

        public Person(string firstName, string lastName, string gender)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = GenderConverter.FromString(gender);
        }
    }
}