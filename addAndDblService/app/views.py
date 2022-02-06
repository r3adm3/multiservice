from app import app
from flask import render_template
from flask import request
import sys
import socket

@app.route('/api/addanddbl')
def home():
   a = request.args.get('a')
   b = request.args.get('b')
   a = int(a)
   b = int(b)
   c = 2 * (a+b)
   return str('{"mathresult":' + str(c) + ',"pythonver":"'+ str(sys.version_info) +'","hostname":"' + str(socket.gethostname()) + '"}')

@app.route('/template')
def template():
    return render_template('home.html')
