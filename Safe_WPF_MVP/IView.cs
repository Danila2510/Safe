using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safe
{
    public interface IView
    {
        string Password { get; }
        event EventHandler<EventArgs> Ok_button;
    }
}
