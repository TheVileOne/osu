//Copyright (c) 2007-2016 ppy Pty Ltd <contact@ppy.sh>.
//Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu/master/LICENCE

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu.Game.Beatmaps.Timing
{
    class TimingChange : ControlPoint
    {
        public double BeatLength;
        public TimeSignatures TimeSignature;

        public double BPM => 60000 / BeatLength;
    }

    public enum TimeSignatures
    {
        SimpleQuadruple = 4,
        SimpleTriple = 3
    }
}
