using System;
namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }

        private static int nextId;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        

        // TODO: Add the two necessary constructors.
        public Job()
        {
            nextId += 1;
            Id = nextId;            
        }

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }

        public override string ToString()
        {
            if (this.Name == "" && this.EmployerName.Value == "" && this.EmployerLocation.Value == "" && this.JobType.Value == "" && this.JobCoreCompetency.Value == "")
            {
                return "OOPS! This job does not seem to exist.";
            }

            if (this.Name == "") 
            {
                this.Name = "Data not available";
            }

            if (this.EmployerName.Value == "")
            {
                this.EmployerName.Value = "Data not available";
            }

            if (this.EmployerLocation.Value == "")
            {
                this.EmployerLocation.Value = "Data not available";
            }

            if (this.JobType.Value == "")
            {
                this.JobType.Value = "Data not available";
            }

            if (this.JobCoreCompetency.Value == "")
            {
                this.JobCoreCompetency.Value = "Data not available";
            }

            return "\n ID:" + this.Id + "\n Name:" + this.Name + "\n Employer:" + this.EmployerName.Value + "\n Location:" + this.EmployerLocation.Value + "\n Position Type:" + this.JobType.Value + "\n Core Competency:" + this.JobCoreCompetency.Value + "\n";
        }

        // TODO: Generate Equals() and GetHashCode() methods.
        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }


        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
        
    }
}
