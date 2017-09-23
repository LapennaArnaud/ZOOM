using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoom.Model.Activite
{
    public abstract class AActivite : IEntite
    {
        public int Id { get ; set ; }

        public AActivite(int id)
        {
            this.Id = id;
        }
    }
}
