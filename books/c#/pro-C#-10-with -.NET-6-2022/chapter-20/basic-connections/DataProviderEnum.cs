﻿namespace basic_connections;

enum DataProviderEnum
{
    SqlServer,
#if PC
    OleDb,
#endif
    Odbc,
    None
}
