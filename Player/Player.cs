using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    class Player
    {
        public int Volume;
        public Song[] Songs;

        public void VolumeUp()
        {
            if(Volume<100)
            {
                Volume++;
                Console.WriteLine($"Volume up to {Volume}");
            }
            else
            {
                Console.WriteLine($"Volume is minimum");
            }
            
        }
        public void VolumeDown()
        {
            if(Volume>0)
            {
                Volume--;
                Console.WriteLine($"Volume down to {Volume}");
            }
            else
            {
                Console.WriteLine($"Volume is maximum");
            }
            
        }
        public void VolumeChange(int step)
        {
            if((Volume+step<=100) || (Volume - step >=0))
            {
                Volume += step;
            }
            else
            {
                Console.WriteLine($"Volume change value incorrect");
            } 
        }
        public void Play()
        {
            Console.WriteLine($"Player is playing: {Songs[0].Name}");
        }
        public void Stop()
        {
            Console.WriteLine($"Player has stopped.");
        }
    }
}
