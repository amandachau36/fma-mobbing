using MazeKata;
using Xunit;

namespace TestProject2
{
    public class MazeTests
    {
        [Fact]
        public void It_Should_Return_A_Maze_Of_Correct_Size_When_Given_String()
        {
            var a = ".W.\n" +
                       ".W.\n" +
                       "...";
            
            var maze = new Maze(a);
            
            Assert.Equal(3, maze.Rows.Count);
        }
        
        [Fact]
        public void It_
    }
}