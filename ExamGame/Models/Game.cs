using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamGame.Models
{
    [Serializable]
    public class Game
    {
        public string Id { get; set; }
        public bool IsOpen { get; set; } = false;
        public IDictionary<string, double>[] ListRoullete { get; set; } = new IDictionary<string, double>[36];
        public Game()
        {
            this.Init();
        }
        private void Init()
        {
            for (int i = 0; i < ListRoullete.Length; i++)
            {
                ListRoullete[i] = new Dictionary<string, double>();
            }
        }
    }
}
