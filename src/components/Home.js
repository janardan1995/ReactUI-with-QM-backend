import React, { Component } from 'react'
import { Link } from 'react-router-dom'
//import {Table} from 'react-bootstrap'
import axios from 'axios';
import AddEmployee from './AddEmployee';
import { BrowserRouter as Router, Route, Switch, Redirect } from 'react-router-dom';

export default class Home extends Component {
    constructor(props) {
        super(props)
        this.state = { employees: [] }
    }
    componentDidMount() {
        axios.get('https://localhost:44372/api/Employee/GetAllEmployee')
            .then(response => {
                this.setState({ employees: response.data });
                console.log(response.data);
            });
    }
    render() {
        return (
            <div className="container" id='home-body-div'>
                <div className='table-div'>
                    <div className="add-div">
                        <h2>Employee List</h2>
                    </div>
                    <table className="empTable" striped border hover size="sm" border="1">
                        <thead>
                            <tr>
                                <th>EmployeeId</th>
                                <th>FirstName</th>
                                <th>LastName</th>
                                <th>PhoneNumber</th>
                                <th>Email</th>
                            </tr>
                        </thead>
                        <tbody>
                            {this.state.employees.map(emp =>
                                <tr>
                                    <td>{emp.id}</td>
                                    <td>{emp.firstName}</td>
                                    <td>{emp.lastName}</td>
                                    <td>{emp.mobileNo}</td>
                                    <td>{emp.emailID}</td>
                                </tr>
                            )}
                        </tbody>
                    </table>
                </div>

                <div className='side-bar'>

                    <h3>Employee CRUD</h3>
                    <div className="home-ul-box">
                        <ul className='u'>
                            <li className='a'> <Link to="/AddEmployee" className='link'>Create</Link></li>
                        </ul>
                    </div>
                    <br />

                    <div className="home-ul-box">
                        <ul className='u'>
                            <li className='a'> <Link to="/Update" className='link'>Update</Link></li>
                        </ul>
                    </div>
                    <br />

                    <div className='home-ul-box'>
                        <ul className='u'>
                            <li className='a'> <Link to="/Delete" className='link'>Delete</Link></li>
                        </ul>
                    </div>
                </div>
            </div>            
        )
    }
}
