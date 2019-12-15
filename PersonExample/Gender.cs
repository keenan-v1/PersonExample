namespace PersonExample
{
    public enum Gender
    {
        Male,
        Female,
        NonBinary
    }

    public static class GenderConverter
    {
        public static Gender FromString(string gender) =>
            gender.ToLower() switch
            {
                "m" => Gender.Male,
                "male" => Gender.Male,
                "f" => Gender.Female,
                "female" => Gender.Female,
                _ => Gender.NonBinary
            };

        public static string ToString(Gender gender) =>
            gender switch
            {
                Gender.Male => "male",
                Gender.Female => "female",
                _ => "a non-binary gender"
            };
    }
}