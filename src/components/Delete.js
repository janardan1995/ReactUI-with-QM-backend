import React from 'react'
import axios from 'axios'


export default class Delete extends React.Component {

    constructor(props) {
        super(props)

        this.state = {
            "id": "",
        }
    }

    onChange = (e) => this.setState({ id: e.target.value })

    onSubmit = (e) => {
        e.preventDefault();
        axios.delete(`https://localhost:44372/api/Employee/DeleteEmployee?id=${this.state.id}`)
            .then(response => {
                alert("Delete sucess");
            })
            .catch(error => { alert("invalid-id") })
        this.setState({ id: "" })
        this.props.history.push('./');
    }
    render() {
        return (
            <>
                <div className="delete-div">
                    <h2>Delete employee from data base</h2>
                    <form className='form-delete' onSubmit={this.onSubmit} >
                        <div>
                            <label className='delete-id' name='ID'>Emp-loyeeId </label>
                            <input type='text' placeholder='input-id plzz ' value={this.state.id} onChange={this.onChange} />
                        </div>
                        <input type='submit' name='Submit' value='submit' />
                    </form>
                </div>
            </>
        )
    }
}



