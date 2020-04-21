import React, { Component } from 'react'
import axios from 'axios'

export default class Update extends Component {
    constructor(props) {
        super(props)

        this.state = {
            "id":"",
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
      
        axios.put('https://localhost:44372/api/Employee/UpdateEmployee', this.state)
    
        .then(response=>{
            alert("Update Granted");
        })
            .catch(error => { alert("invalid-id") })
            this.setState({ [e.target.name]: ""})
            this.props.history.push('./');

    }

    render() {
        const { id,firstName, lastName, emailID, mobileNo } = this.state
        return (
            <div className='main-add-div'>
                
                <div className='add-container'>
                <h2>Enter the id of employee that you wanna update</h2>
                  
                    <form className='add-form' onSubmit={this.onSubmit}>
                    <div className='aligment'>
                            <div className='firstName'>id</div>
                            <input type='text' className="add-firstname" name='id' value={id} onChange={this.onChange} />
                        </div>
                        <br/>
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
        )
    }
}


