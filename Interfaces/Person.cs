using System;

namespace Interfaces
{
    public class Person : ILoggable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Gender { get; set; }

        public string Log()
        {
            return $"{FirstName} {LastName} is a {Gender} born on {DateOfBirth.Value.ToString("d MMM yyyy")}";
        }
    }
}