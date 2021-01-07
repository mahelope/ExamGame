using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamGame.Models;
using ExamGame.Cache;


namespace ExamGame.Services
{
    public class GameService : IGameService
    {
        private IGameCache gameCache;
        public GameService(IGameCache gameCache)
        {
            this.gameCache = gameCache;
        }
        public Game Create()
        {
            Game game = new Game()
            {
                Id = Guid.NewGuid().ToString(),
                IsOpen = false
            };
            gameCache.Save(game);

            return game;
        }
        public List<Game> ListAll()
        {
            return gameCache.ListAll();
        }
    }
}
