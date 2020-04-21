import React from 'react'
import axios from 'axios'

export default class GetEmployee extends React.Component {

    constructor(props) {
        super(props)

        this.state = {
            id: ""

        }
    }
    onChange = (e) => this.setState({ id: e.target.value })

    onSubmit = (e) => {
        e.preventDefault();
        //this.setState();
        console.log(this.state.id);
        this.setState({ employee: [] })
        axios.get(`https://localhost:44372/api/Employee/GetEmployee?id=${this.state.id}`)
            .then(response => {
                console.log(response);
                this.setState({ employee: response.data });

                console.log(this.state.employee.firstName);
            })
            .catch(error => { console.log(error) })
    }

    render() {
        return (
            <div>
                <h3>Get employee from data base</h3>
                <form className='form-delete' onSubmit={this.onSubmit}>
                    <div>
                        <label className='delete-id' name='ID'>id   </label>
                        <input type='text' placeholder='input-id plzz ' value={this.state.id} onChange={this.onChange} />
                    </div>
                    <input type='submit' name='Submit' value='submit' />

                </form>
                <h3>table</h3>
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
                        {this.state.employee.map(
                            <tr>
                                <td>{this.state.employee.id}</td>
                                <td>{this.state.employee.firstName}</td>
                                <td>{this.state.employee.lastName}</td>
                                <td>{this.state.employee.mobileNo}</td>
                                <td>{this.state.employee.emailID}</td>
                            </tr>
                        )
                        }                        
                    </tbody>
                </table>
            </div>
        )
    }
}



