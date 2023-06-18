using GraphQLSampleAPI.Model;

namespace GraphQLSampleAPI.GraphQLInput
{
    public class SuperheroInput
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class SuperheroUpdateInput
    {
        public string Id { get; set; }  
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class SuperpowerInput
    {
        public string SuperPower { get; set; }
        public string Description { get; set; }
    }

    public class SuperheroWithPowerInput
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public SuperpowerInput SuperpowerInput { get; set; }  

    }
}
