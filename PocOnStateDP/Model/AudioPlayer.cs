using System;
using System.Collections.Generic;
using System.Text;

namespace PocOnStateDP.Model
{
    class AudioPlayer
    {
        private IAudioPlayerState currentState;

        public AudioPlayer()
        {
            currentState = new StoppedState();
            Change();
        }

        //public void ChangeState()
        //{
        //    if (currentState == new StoppedState())
        //    {
        //        currentState = new PlayingState();
        //        Display();
        //    }
                

        //    if (currentState == new PlayingState())
        //    {
        //        currentState = new PausedState();
        //        Display();
        //    }
                
        //    if (currentState == new PausedState())
        //    {
        //        currentState = new StoppedState();
        //        Display();
        //    }
                
        //}

        //public void Play()
        //{
        //    currentState.Play();
        //}

        //public void Pause()
        //{
        //    currentState.Pause();
        //}

        //public void Stop()
        //{
        //    currentState.Stop();
        //}
        public void Change()
        {
            currentState=currentState.Button();
        }
    }
}
