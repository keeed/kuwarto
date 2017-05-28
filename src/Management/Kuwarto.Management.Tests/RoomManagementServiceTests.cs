using Moq;
using Xunit;

namespace Kuwarto.Management.Tests
{
    public class RoomManagementServiceTests
    {

        public class Create_Should
        {


            [Fact]
            public void InvokeRepositorySave()
            {
                var repository = new Mock<IRoomRepository>();

                var service = new RoomManagementService(repository.Object);
                service.Create("Pahiyas");

                repository
                    .Verify(repo => repo.Create(It.Is<Room>(r => r.Name == "Pahiyas")), Times.Once);

            }
        }

    }
}
