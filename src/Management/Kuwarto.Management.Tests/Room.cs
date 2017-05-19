using System;

namespace Kuwarto.Management.Tests
{
    public class Room
    {

        public Room(string name)
            : this(0, name)
        {
        }

        public Room(int id, string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;

            if (id == 0)
            {
                throw new ArgumentOutOfRangeException(nameof(id));
            }

            Id = id;
        }

        public string Name { get; set; }
        public int Id { get; set; }
    }
}
