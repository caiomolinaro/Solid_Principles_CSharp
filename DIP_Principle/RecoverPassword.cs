using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_Principle;

internal class RecoverPassword
{
    private IDataBaseConnection connectDatabase;

    public RecoverPassword(IDataBaseConnection _connect)
    {
        connectDatabase = _connect;
    }
}