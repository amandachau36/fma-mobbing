using System;
using System.Collections.Generic;
using System.Linq;

namespace MazeKata
{
    public class Maze
    {
        public List<List<ISpot>> Rows { get; private set; } = new List<List<ISpot>>();
        
        public Maze (string map)
        {
            var stringRows = map.Split("\n").ToList();
            foreach (var row in stringRows) {
                Rows.Add(GetISpotsFromString(row));
            }
        }

        private List<ISpot> GetISpotsFromString(string row) {
            var spots = new List<ISpot>();
            foreach (var character in row) {
                spots.Add(ParseSpot(character));
            }
            return spots;
        }

        private ISpot ParseSpot(char character)
        {
            return character switch
            {
                'W' => new Wall(),
                '.' => new Floor(),
                _ => throw new MazeCharacterNotValidException(character)
            };
        }
    }
}