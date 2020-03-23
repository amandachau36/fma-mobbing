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
            // foreach (var spot in maze.Rows[0]) {
            //     Assert.IsType<Wall>(spot);
            // }
        }
        
        [Fact]
        public void It_Should_Return_Floors_When_Given_A_String_Of_Dots() {
            var a = "...";
            var maze = new Maze(a);

            foreach (var spot in maze.Rows[0]) {
                Assert.IsType<Floor>(spot);
            }
        }
        
        
        [Fact]
        public void It_Should_Return_ListOfThreeSpots_When_Given_A_String_Of_3_Chars() {
            var a = "...";
            var maze = new Maze(a);

            Assert.Equal(3, maze.Rows[0].Count);
        }
        
        
    }
}