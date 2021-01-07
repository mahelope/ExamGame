using System;
using System.Collections.Generic;
using System.Linq;
using EasyCaching.Core;
using ExamGame.Models;

namespace ExamGame.Cache
{
    public class GameCache : IGameCache
    {
        private IEasyCachingProviderFactory cachingProviderFactory;
        private IEasyCachingProvider _provider;
        private const string KEY = "ROULETEGAME";
        public GameCache(IEasyCachingProviderFactory cachingProviderFactory)
        {
            this.cachingProviderFactory = cachingProviderFactory;
            this._provider = this.cachingProviderFactory.GetCachingProvider("game");
        }
        public Game GetById(string Id)
        {
            var item = this._provider.Get<Game>(KEY + Id);

            return !item.HasValue ? null : item.Value;
        }
        public List<Game> ListAll()
        {
            var game = this._provider.GetByPrefix<Game>(KEY);
            if (game.Values.Count == 0)
            {
                return new List<Game>();
            }

            return new List<Game>(game.Select(x => x.Value.Value));
        }
        public Game Update(string Id, Game game)
        {
            game.Id = Id;

            return Save(game);
        }
        public Game Save(Game game)
        {
            _provider.SetAsync(KEY + game.Id , game, TimeSpan.FromMinutes(1));

            return game;
        }
    }
}