using System;
using System.Collections.Generic;
using System.Text;

namespace PocOnStateDP.Model
{
    class PausedState : IAudioPlayerState
    {
        public IAudioPlayerState Button()
        {
            Console.WriteLine("Stopprd");
            return new StoppedState();
        }

        
    }
}
