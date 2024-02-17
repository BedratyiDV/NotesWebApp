using NotesProcessor;
using NoteDAL;
using NoteContracts;
using Moq;

namespace NotesProcessor.Tests
{
    public class NotesProcessorTest
    {
        [Fact]
        public void GetAllMoq()
        {
            //Arrange
            var repoMock = new Mock<IRepository<Note>>();

            repoMock.Setup(repo=>repo.GetAll()).Returns(new List<Note>()
            {
                new() { Id = 1, Name = "MyNote1", Value = "Math", Priority = 1},
                new() { Id = 2, Name = "MyNote2", Value = "Physics", Priority = 3},
                new() { Id = 3, Name = "MyNote3", Value = "English", Priority = 2}

            });

            var proc = new NoteProcessor(repoMock.Object);

            //Act
            var res = proc.GetAll();

            //Assert
            Assert.Equal(3, res.Count());

        }
    }
}