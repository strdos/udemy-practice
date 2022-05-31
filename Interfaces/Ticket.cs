using System;

namespace Interfaces
{
    internal class Ticket : IEquatable<Ticket>
    {
        public int DurationInHours { get; set; }

        public Ticket(int durationInHours)
        {
            DurationInHours = durationInHours;
        }

        //manual implementation
        public bool Equals(Ticket other)
        {
            return DurationInHours == other.DurationInHours;
        }

        // auto implementation (explicit)
        //bool IEquatable<Ticket>.Equals(Ticket other)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
