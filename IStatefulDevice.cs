using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeController
{
    public interface IStatefulDevice
    {
        DeviceState SaveState();
        void RestoreState(DeviceState state);
    }
}
