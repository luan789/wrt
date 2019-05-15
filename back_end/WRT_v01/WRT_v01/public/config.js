var sql = require("mssql");
const config = {
    server: "localhost\\SQLEXPRESS",
    database: "WRT_v01",
    user: "sa",
    password: "sa2012",
    port: 1433,
    multipleStatements: true,
};


//pool
var pool= new sql.ConnectionPool(config);


module.exports = pool;