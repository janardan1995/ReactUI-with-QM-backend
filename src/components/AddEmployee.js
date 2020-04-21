import React, { Component } from 'react'
import axios from 'axios'

export default class AddEmployee extends Component {
    constructor(props) {
        super(props)

        this.state = {
            "firstName": "",
            "lastName": "",
            "mobileNo": "",
            "emailID": ""
        }
    }

    onChange = (e) => this.setState({ [e.target.name]: e.target.value })

    onSubmit = (e) => {
        e.preventDefault();
        console.log(this.state);
        axios.post('https://localhost:44372/api/Employee/AddEmployee', this.state)

            .then(response => {
                console.log(response)
            })
            .catch(error => { console.log(error) })
        this.setState({ [e.target.name]: "" })
        this.props.history.push('./');
    }

    render() {
        const { firstName, lastName, emailID, mobileNo } = this.state
        return (
            <div className='main-add-div'>
                <div>
                    <div className='add-container'>
                        <h2>Add the Employee</h2>
                        <form className='add-form' onSubmit={this.onSubmit}>
                            <div className='aligment'>
                                <div className='firstName'>FirstName</div>
                                <input type='text' className="add-firstname" name='firstName' value={firstName} onChange={this.onChange} />
                            </div>
                            <br />
                            <div className='aligment'>
                                <div className='firstName'>LastName</div>
                                <input type='text' className="add-firstname" name='lastName' value={lastName} onChange={this.onChange} />
                            </div>
                            <br />
                            <div className='aligment'>
                                <div className='firstName'>MobileNo</div>
                                <input type='text' className="add-firstname" name='mobileNo' value={mobileNo} onChange={this.onChange} />
                            </div>
                            <br />
                            <div className='aligment'>
                                <div className='firstName'>Email_Id</div>
                                <input type='email' className="add-firstname" name='emailID' value={emailID} onChange={this.onChange} />
                            </div>
                            <br />
                            <div className='submit-box'>
                                <input type='submit' name='submit' className='submit-text' />
                            </div>
                        </form>
                    </div>
                </div>
            </div>
        )
    }
}


