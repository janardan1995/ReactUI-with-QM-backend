import React,{ Component } from "react";

 export default class Select extends Component {
    state = {
      options: [
        {
          name: 'Select…',
          value: null,
        },
        {
          name: 'A',
          value1: 'Inch',
          value2:'Feet',
          value3:'Yard'
        },
        {
          name: 'B',
          value: 'b',
        },
        {
          name: 'C',
          value: 'c',
        },
      ],
      value: '?',
    };
  
    handleChange = (event) => {
        console.log('one');
      this.setState({ value: event.target.value });
    };
  
    render() {
      const { options, value } = this.state;
  
      return (
        <>
          <select onChange={this.handleChange} value={value}>
            {options.map(item => (
              <option key={item.name} value={item.value}>
                {item.name}
              </option>
            ))}
          </select>
          <h1>Favorite letter: {value}</h1>
        </>
      );
    }
  }

  
//   ReactDOM.render(<Select />, window.document.body);