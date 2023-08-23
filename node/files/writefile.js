var fs = require('fs');

fs.writeFile('mynewfile3.txt', 'Hello, Allan! Keep studying Node.js if you want be succeed!', function (err) {
  if (err) throw err;
  console.log('Saved!');
});