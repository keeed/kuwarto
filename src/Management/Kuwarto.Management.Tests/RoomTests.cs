using System;
using FluentAssertions;
using Xunit;

namespace Kuwarto.Management.Tests
{
    public class RoomTests
    {
        public class Constructor_Should
        {


            [Fact]
            public void RequireName()
            {
                var room = new Room("Pahiyas");

                room.Name.Should().Be("Pahiyas");
            }

            [Theory]
            [InlineData(null)]
            [InlineData("")]
            public void ThrowException_WhenNameIsNull(string name)
            {
                Action sut = () => new Room(name);

                sut.ShouldThrow<ArgumentNullException>();
            }
        }
    }
}