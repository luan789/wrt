var createError = require('http-errors');
var express = require('express');
var path = require('path');
var cookieParser = require('cookie-parser');
var logger = require('morgan');
var session = require('express-session');
var processRSV = require('./routes/processReservation');
var usersRouter = require('./routes/users');
var express = require('express');

// const config = require('./public/config.js');
// var sql = require("mssql");
var app = express();
//pool
// var pool= new sql.ConnectionPool(config);
// view engine setup
app.set('views', path.join(__dirname, 'views'));
app.set('view engine', 'pug');

app.use(session({
  secret: 'luanhoangnguyen',
  resave: false,
  saveUninitialized: true,
  cookie: { maxAge: 1000000 }
}))
var temp;
app.use(logger('dev'));
app.use(express.json());
app.use(express.urlencoded({ extended: false }));
app.use(cookieParser());
app.use(express.static(path.join(__dirname, 'public')));

app.use(function (req, res, next) {
  res.header("Access-Control-Allow-Origin", "*");
  res.header("Access-Control-Allow-Headers", "Origin, X-Requested-With, Content-Type, Accept");
  next();
});

//app.use('/', indexRouter);
app.use('/', processRSV);

app.get('/login', function (req, res) {
  temp = req.session.id;
  console.log(temp);
  res.send('login thanh cong');
})

app.get('/employer', function (req, res) {
  res.set({ 'content-type': 'application/json; charset=utf-8' });
  pool.connect(function (err) {
    pool.query('select * from wrt_i_employer', function (err, recordset) {
      if (err) console.log(err);

      res.status(200).send(JSON.stringify({ data: recordset.recordsets }));
    });
  });
})

app.get('/station2', function (req, res) {
  console.log(req.session.id);
  if (req.session.id == temp) {
    res.set({ 'content-type': 'application/json; charset=utf-8' });
    pool.connect(function (err) {
      pool.query('select * from wrt_i_station;select * from wrt_i_employer', function (err, recordset) {
        if (err) console.log(err);
        res.send(JSON.stringify(recordset));
      });
    });
  } else {
    res.send('login fail')
  }
})

// catch 404 and forward to   error handler
app.use(function (req, res, next) {
  next(createError(404));
});

// error handler
app.use(function (err, req, res, next) {
  // set locals, only providing error in development
  res.locals.message = err.message;
  res.locals.error = req.app.get('env') === 'development' ? err : {};

  // render the error page
  res.status(err.status || 500);
  res.render('error');
});

module.exports = app;
