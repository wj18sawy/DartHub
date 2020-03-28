using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DartHub.Models
{
    public class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public string AvatarPath { get; set; }
        public readonly string smallAvatarsPath = "/images/avatar/small/";

        public Player(string name, int score)
        {
            Name = name;
            Score = score;
            AvatarPath = String.Concat(smallAvatarsPath, name, ".jpg");
        }
    }
}
