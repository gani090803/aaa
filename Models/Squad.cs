namespace Models
{
    public class Squad
    {
        public int Id { get; set; }
        public StartingEleven? StartingEleven { get; set; }
        public Bench? Bench { get; set; }
        public Reserves? Reserves { get; set; }
    }
}