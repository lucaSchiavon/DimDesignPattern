using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternDimitri.Strutturali.Composite.NeuronExample
{
   public  class NeuronVer2:ScalarVer2<NeuronVer2>
    {
        public List<NeuronVer2> In, Out;
    }
}
