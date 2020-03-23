using System.Collections.Generic;
using System.Linq;

namespace MazeKata
{
    public class Maze
    {
        public List<List<ISpot>> Rows { get; private set; } = new List<List<ISpot>>();
        
        public Maze (string map)
        {
            var StringRows = map.Split("\n").ToList();
            foreach (var row in StringRows) {
                Rows.Add(GetISpotsFromString(row));
            }
        }

        private List<ISpot> GetISpotsFromString(string row) {
            var spots = new List<ISpot>();
            foreach (var spot in row) {
                switch (spot) {
                    case 'W':
                        spots.Add(new Wall());
                        break;
                }
            }

            return spots;
        }
    }
}