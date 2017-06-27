// The Vue build version to load with the `import` command
// (runtime-only or standalone) has been set in webpack.base.conf with an alias.
const { app, BrowserWindow } = require('electron');
const path = require('path');
const url = require('url');

let win = null;

let createWindow = () => {
    win = new BrowserWindow({
        height: 800,
        width: 1200,        
        frame: false
    });
  win.loadURL(url.format({
    pathname: path.join(__dirname, './dist/index.html'),
    protocol: 'file:',
    slashes: true
  }));

  win.webContents.openDevTools();

  win.on('closed',
    () => {
      win = null;
    });

 
  // eslint-disable-next-line no-console
  console.log('win opened');
}

app.on('ready', createWindow);

app.on('window-all-closed',
  () => {
    if (process.platform !== 'darwin') {
      app.quit();
    }
  });

app.on('activate',
  () => {
    if (win === null) {
      createWindow();
    }
  });

/* eslint-disable no-new */
//window.onload = ()=>{};
