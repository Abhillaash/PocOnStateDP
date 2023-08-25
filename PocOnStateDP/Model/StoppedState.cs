using System;
using System.Collections.Generic;
using System.Text;

namespace PocOnStateDP.Model
{
    class StoppedState : IAudioPlayerState
    {
        public IAudioPlayerState Button()
        {
            Console.WriteLine("Playing");
            return new PlayingState();
        }
    }
}
