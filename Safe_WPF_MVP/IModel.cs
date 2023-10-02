using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safe
{
    public interface IModel
    {
        string Pass { get; set; }
        void CheckPassword();
    }
}
