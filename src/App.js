import React, { Component } from "react";
import './App.css';
import { BrowserRouter as Router, Switch, Route } from 'react-router-dom';
import Header from "./components/Pages/Header";
import Footer from "./components/Pages/Footer";
import Home from "./components/Home";
import AddEmployee from './components/AddEmployee';
import Delete from "./components/Delete";
import Update from "./components/Update";
import About from "./components/Pages/About";

export default class App extends Component {

  render() {
    return (
      <div>
        <Router>
          <Header />
          <Switch>
            <Route path='/' component={Home} exact />
            <Route path='/AddEmployee' component={AddEmployee} />
            <Route path='/Update' component={Update} />
            <Route path='/Delete' component={Delete} />
            <Route path='/About' component={About} />

          </Switch>
          <Footer />
        </Router>
      </div>
    );
  }
}