using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreehouseDefense
{
    public class FastInvader : Invader
    {
        protected virtual int StepSize { get; } = 2;

        public FastInvader(Path path) : base(path)
        {

        }

    }
}
