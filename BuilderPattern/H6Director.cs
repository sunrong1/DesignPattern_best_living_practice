using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class H6Director
    {
        private H6Builder builder;
        public H6Director(H6Builder builder)
        {
            this.builder = builder;
        }
        public void Build()
        {
            builder.Engine();
            builder.GearBox();
            builder.UnderPan();
            builder.Appearance();
            builder.Intelligence();
        }
    }
}
