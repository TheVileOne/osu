//Copyright (c) 2007-2016 ppy Pty Ltd <contact@ppy.sh>.
//Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu/master/LICENCE

namespace osu.Game.Beatmaps.Samples
{
    public class SampleInfo
    {
        public SampleBank Bank { get; set; }
        public SampleSet Set { get; set; }
        public int Volume { get; set; }

        public SampleInfo()
        {
            Volume = 100;
        }

        public SampleInfo Clone()
        {
            return new SampleInfo
            {
                Bank = Bank,
                Set = Set,
                Volume = Volume
            };
        }
    }
}
