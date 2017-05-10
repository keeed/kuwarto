using System;

namespace Kuwarto.Management.Tests
{
    public class Room
    {
        public Room(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
        }

        public string Name { get; set; }
    }
}
