using System;
using FluentAssertions;
using Xunit;

namespace Kuwarto.Management.Tests
{
    public class RoomTests
    {
        public class Constructor_Should
        {

            //room will have id and name
            //room is inactive when no location and available schedule

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

            [Fact]
            public void IdIsZero_WhenNotAssigned()
            {
                var room = new Room("Pahiyas");
                room.Id.Should().Be(0);
            }

            [Fact]
            public void IdHasValue_WhenAssigned()
            {
                var room = new Room(1, "Pahiyas");
                room.Id.Should().Be(1);
            }

            [Fact]
            public void ThrowException_WhenIdAssigned_AndZero()
            {
                Action sut = () => new Room(0, "Pahiyas");
                sut.ShouldThrow<ArgumentOutOfRangeException>();
            }
        }
    }
}