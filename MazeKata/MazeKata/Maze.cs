using System.Collections.Generic;
using System.Linq;

namespace MazeKata
{
    public class Maze
    {
        public List<List<ISpot>> Rows { get; private set; }
        
        public Maze (string map)
        {
            Rows = map.Split("\n").ToList();
        }
    }
}