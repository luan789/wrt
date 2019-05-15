var express = require('express');
var router = express.Router();

const pool = require('../public/config');


//var pool= new sql.ConnectionPool(config);
/* GET home page. */
router.get('/tititi', function (req, res, err) {
    res.set({ 'content-type': 'application/json; charset=utf-8' });
    pool.connect(function (err) {
        if (err) {
            console.log('err xay ra');
        } else {
            pool.query('select * from wrt_i_employer', function (err, recordset) {
                if (err) console.log(err);

                res.status(200).send(JSON.stringify({ data: recordset.recordsets }));
            });
        }
    });
});

router.get('/station', function (req, res) {
    res.set({ 'content-type': 'application/json; charset=utf-8' });
    pool.connect(function (err) {
        pool.query('select * from wrt_i_station', function (err, recordset) {
            if (err) console.log(err);
            res.status(200).send(JSON.stringify({ data: recordset.recordsets[0] }));
        });
    });
})

module.exports = router
