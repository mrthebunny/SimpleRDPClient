using AwakeCoding.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AwakeCoding
{
    public interface ISecuredSettings2 : ISecuredSettings
    {
        string BinaryPassword2 { get; set; }
    }
}
