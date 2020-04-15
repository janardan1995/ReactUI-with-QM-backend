import React,{Component} from "react"; 
// import ReactDOM from 'react-dom';
import './App.css';
import Login from './components/Login';
import {BrowserRouter as Router,Switch,Route } from 'react-router-dom';

class App extends Component{
    constructor(props){
        super(props)
    }
    render(){ 
        return(
            <Router>
            <Switch>
            <Route path='/' component={Login} exact/>
            
            </Switch>
            </Router>
        );
    }
}

export default App;