namespace Day1MVC.models
{
    public class attendmember
    {
        private static List<member> member = new List<member>();
        public static List<member> Member { get => member; }

        public static void addmembers(member members)
        {
            member.Add(members);
        }
    }
}
