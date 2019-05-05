const express = require('express')
const app = express()
const port = 3000

app.get('/', (req, res) => res.send('Hello World!'))

app.get('/ab', function (req, res) {
    res.send('Hello World!')
  })

app.listen(port, () => console.log(`Example app listening on port ${port}!`))

express.static(root, [options])
app.use(express.static('public'))