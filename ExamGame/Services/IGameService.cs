using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamGame.Models;

namespace ExamGame.Services
{
    public interface IGameService
    {
        public Game Create();
        public List<Game> ListAll();
    }
}
