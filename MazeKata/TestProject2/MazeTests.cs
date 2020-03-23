using System.Collections.Generic;
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
        public void It_Should_Return_Walls_When_Given_A_String_Of_Double_Ewes() {
            var a = "WWW";
            var maze = new Maze(a);

            var expectedRow = new List<ISpot>
            {
                new Wall(),
                new Wall(),
                new Wall()
            };
            
            Assert.NotStrictEqual(expectedRow, maze.Rows[0]);
        }        
        
        [Fact]
        public void It_Should_Throw_A_Maze_String_Not_Valid_Exception_When_Given_An_Invalid_String()
        {
            var a = "*%^";
            Assert.Throws<MazeCharacterNotValidException>(() => new Maze(a));
        }
        
        [Fact]
        public void It_Should_Return_Floors_When_Given_A_String_Of_Dots() {
            var a = "...";
            var maze = new Maze(a);

            var expectedRow = new List<ISpot>
            {
                new Floor(),
                new Floor(),
                new Floor()
            }; 
            
            Assert.NotStrictEqual(expectedRow, maze.Rows[0]);
        }
    }
}