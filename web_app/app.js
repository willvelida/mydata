var express = require('express');
var app = express();

app.use(express.static("public"));
app.set("view engine", "ejs");

app.get('/', function (req, res) {
  res.render("index.ejs");
})

app.listen(8000, function () {
  console.log('My data app listening on port 8000!')
})