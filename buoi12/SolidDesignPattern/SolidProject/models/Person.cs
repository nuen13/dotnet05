public class Person
{
    public string Name {get; set;}
    public Address HomeAddress {get; set;}
    public Job CurrentJob {get; set;}

    public Person(Address address, Job job)
    {
        HomeAddress = address;
        CurrentJob = job;
    }

}