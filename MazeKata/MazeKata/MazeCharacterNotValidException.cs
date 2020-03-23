using System;

namespace MazeKata
{
    public class MazeCharacterNotValidException : Exception
    {
        public MazeCharacterNotValidException(char character) : base(FormatMessage(character))
        {
            
        }

        private static string FormatMessage(char character)
        {
            return $"This row is not valid: {character}";
        }
    }
}