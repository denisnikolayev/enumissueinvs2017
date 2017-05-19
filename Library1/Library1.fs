namespace Library1

open FSharp.Data


type Enum1 = SqlEnumProvider<"select name, id from table1", "Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=New Database;Integrated Security=True;">