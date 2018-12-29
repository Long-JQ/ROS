import React, { Component } from 'react';
import {BrowserRouter as Router, Route, Switch, Link} from "react-router-dom";

import logo from './logo.svg';
import HomePage from './a.js'
import About from './b.js'

import './App.css';

class c extends React.Component {
  render() {
    return (
        <Router>
          <div className="App">
            <div>
              <div><Link to='/'>首页</Link></div>
              <div><Link to='/about'>关于</Link></div>
            </div>
            <hr/>
            <Route exact path="/" component={HomePage} />
            <Route path="/about" component={About} />
          </div>
        </Router>
    );
  }
}

export default c;