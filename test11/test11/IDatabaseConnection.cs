using System;
using System.Collections.Generic;
using System.Text;

namespace test11
{
    public interface IDatabaseConnection
    {
        SQLite.SQLiteConnection DbConnection();
    }
}
