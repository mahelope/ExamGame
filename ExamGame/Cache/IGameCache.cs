using System.Collections.Generic;
using ExamGame.Models;

namespace ExamGame.Cache
{
    public interface IGameCache 
    {
        public Game GetById(string Id);
        public List<Game> ListAll();
        public Game Update(string Id, Game roulette);
        public Game Save(Game game);
    }
}