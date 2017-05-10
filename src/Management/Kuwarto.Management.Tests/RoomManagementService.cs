namespace Kuwarto.Management.Tests
{
    public class RoomManagementService
    {
        private readonly IRoomRepository _repository;

        protected IRoomRepository Repository { get { return _repository; } }

        public RoomManagementService(IRoomRepository repository)
        {
            _repository = repository;
        }

        public void Create(string name)
        {
            Repository.Create(new Room(name));
        }
    }
}
