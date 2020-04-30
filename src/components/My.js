import React, { Component } from 'react'

export class My extends Component {
    // constructor(props) {
    //     super(props)

    //     this.state = {
    //         options: [
    //             {
    //                 name: 'Length',
    //                 val: [
    //                     {
    //                         value1: 'Inch'
    //                     }, {
    //                         value1: 'Feet'
    //                     }, {
    //                         value1: 'Yard'
    //                     }
    //                 ]

    //             },
    //             {
    //                 name: 'Weight',
    //                 val: [
    //                     {
    //                         value1: 'Kilogram'
    //                     }, {
    //                         value1: 'Gram'
    //                     }
    //                 ]

    //             },
    //             {
    //                 name: 'Temperature',
    //                 val: [
    //                     {
    //                         value1: 'Celsius'
    //                     }, {
    //                         value1: 'Fahrenheith'
    //                     }
    //                 ]

    //             }
    //         ],
    //         value: "Length"
    //     }
    // }

    onChange = (event) => {
        console.log(event.target.value);
        console.log("event.target.name");
        if (event.target.value === 'Length') {
            console.log('le');

        }
        if (event.target.value === 'Weight') {
            console.log('We');
        }
        if (event.target.value === 'Temperature') {
            console.log('Te');
        }
    }
    render() {

        return (
            <div>
                <select onChange={this.onChange}>
                    {
                        this.state.options.map(item => (
                            <option key={item.name} value={item.name}>
                                {item.name}
                            </option>
                        )
                        )}
                </select>

                <hr />
                <select onChange={this.onChange}>
                    {
                        this.state.options.val.value1.map(item => (
                            <option key={item.value1} value={item.value1}>
                                {item.value1}
                            </option>
                        )
                        )}
                </select>
                <div><oop /></div>
            </div>
        )
    }
}

export default My
