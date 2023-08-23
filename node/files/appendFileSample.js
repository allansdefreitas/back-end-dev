var fs = require('fs');

fs.appendFile('mynewfile1.txt', ' This is my joyful. This is my song', function (err) {
  if (err) throw err;
  console.log('Updated!');
});