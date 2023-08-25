using System;
using System.Collections.Generic;
using System.Text;

namespace PocOnStateDP.Model
{
    class PlayingState : IAudioPlayerState
    {
        public IAudioPlayerState Button()
        {
            Console.WriteLine("Pausing");
            return new PausedState();
        }
    }
}
