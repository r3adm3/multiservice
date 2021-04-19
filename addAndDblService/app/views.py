from app import app
from flask import render_template
from flask import request

@app.route('/')
def home():
   a = int(request.args.get('a'))
   b = int(request.args.get('b'))
   c = 2 * (a+b)
   return c

@app.route('/template')
def template():
    return render_template('home.html')
