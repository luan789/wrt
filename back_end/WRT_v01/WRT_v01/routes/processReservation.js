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

router.get('/st1/:origin/st2/:destina', function (req, res) {
    res.set({ 'content-type': 'application/json; charset=utf-8' });
    var par1 = req.params.origin;
    var par2 = req.params.destina;
    console.log(req.params.origin);
    pool.connect(function (err) {
        pool.query("select * from wrt_t_schedule where id_route = (select id_route from wrt_i_route where wrt_i_route.id_origin= '" + par1 + "' and wrt_i_route.id_destinate= '" + par2 + "')",
            function (
                error,
                recordset
            ) {
                if (error) {
                    console.log(error);
                    res.send({
                        code: 400,
                        failed: "Error ocurred"
                    });
                } else {
                    res.status(200).send(JSON.stringify({ data: recordset.recordsets[0] }));

                }
            });

    });
})

module.exports = router
