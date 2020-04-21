import React, { Component } from 'react';


export default class Login extends Component {
    constructor(props) {
        super(props)
        this.state = {
            email: "",
            password: ""
        }
    }
    handleEmailChange = (event) => {
        const email = event.target.value;
        this.setState({
            email: email
        })
        console.log("email", this.state.email);
    }
    handlePasswordChange = (event) => {
        const email = event.target.value;
        this.setState({
            password: email
        })
        console.log("password", this.state.password);
    }
    handleSubmitButton = () => {
        var data = {
            Email: this.state.email,
            Password: this.state.password

        }
        console.log("data", data);
        console.log("status", this.state, this.email);
    }
    render() {
        return (
            <div className="main-div">
                
                <div className="login-div">Login</div>
                <div className="main-login-div">

                    <div className="email-div">
                        <input className="input-email-div" type="email" placeholder="Email" onChange={this.handleEmailChange} />
                    </div>
                    <div className="email-div">
                        <input className="input-email-div" type='password' placeholder="Password" onChange={this.handlePasswordChange} />
                    </div>
                </div>
                <div className="button">
                    <button className="submit" onClick={this.handleSubmitButton}>submit</button>
                </div>
            </div>
        )

    }
}