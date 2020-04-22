import React, { Component } from 'react'
import axios from 'axios'

class Home extends Component {
    constructor(props) {
        super(props)

        this.state = {
            inputParameter: '',
            outputParameter:'',
            num: parseInt('0'),
            outputValue:parseInt('0')
        }
    }

    inputText = (event) => {
        this.setState({num:event.target.value}) 
        console.log("num :"+this.state.num) ;      
    }

    inputOnChange = (event) => {
        this.setState(
            {
                inputParameter: event.target.value ,                         
            }
        );    
        console.log(this.state.inputParameter);    
    }

    outputOnChange = (event) => {
        this.setState(
            {
                outputParameter: event.target.value              
            }
        );
        console.log(this.state.outputParameter); 
     }

   
   
    onClick=(e)=>{

        console.log("out"+this.state.outputParameter);
        console.log("in "+this.state.inputParameter);
        console.log("num :"+this.state.num) ;
       
        if(this.state.inputParameter==='Feet' && this.state.outputParameter==='Yard'){
            axios.get(`https://localhost:44303/api/Length/api/Converted_FeetToYard?F_Value=${this.state.num}`)
            .then(response => {
                this.setState({outputValue:response.data})
                console.log(response.data);
            })
             .catch(error => { console.log(error) })
        }
        if(this.state.inputParameter==='Yard' && this.state.outputParameter==='Feet'){
            axios.get(`https://localhost:44303/api/Length/api/Converted_YardToFeet?Y_Value=${this.state.num}`)
            .then(response => {
                this.setState({outputValue:response.data})
                console.log(response.data);
            })
        }
        if(this.state.inputParameter==='Yard' && this.state.outputParameter==='Inch'){
            axios.get(`https://localhost:44303/api/Length/api/Converted_YardToInches?Y_Value=${this.state.num}`)
            .then(response => {
                this.setState({outputValue:response.data})
                console.log(response.data);
            })
        }
        if(this.state.inputParameter==='Inch' && this.state.outputParameter==='Yard'){
            axios.get(`https://localhost:44303/api/Length/api/Converted_InchesToYard?I_Value=${this.state.num}`)
            .then(response => {
                this.setState({outputValue:response.data})
                console.log(response.data);
            });
        }
        if(this.state.inputParameter==='Feet' && this.state.outputParameter==='Inch'){
            axios.get(`https://localhost:44303/api/Length/api/Converted_FeetToInches?F_Value=${this.state.num}`)
            .then(response => {
                this.setState({outputValue:response.data})
                console.log(response.data);
            });
        }
        if (this.state.inputParameter==='Inch' && this.state.outputParameter==='Feet'){
            axios.get(`https://localhost:44303/api/Length/api/Converted_InchesToFeet?I_Value=${this.state.num}`)
            .then(response => {
                this.setState({outputValue:response.data})
                console.log(response.data);
            });
        }

        // Temperature parameter..........................>

        if (this.state.inputParameter==='Fahrenheith' && this.state.outputParameter==='Celsius'){
            axios.get(`https://localhost:44303/api/Temperature/api/Converted_FarhenheithToCelsius?F_value=${this.state.num}`)
            .then(response => {
                this.setState({outputValue:response.data})
                console.log(response.data);
            });
        }
        if (this.state.inputParameter==='Celsius' && this.state.outputParameter==='Fahrenheith'){
            axios.get(`https://localhost:44303/api/Temperature/api/Converted_CelsiusToFahrenheith?C_value=${this.state.num}`)
            .then(response => {
                this.setState({outputValue:response.data})
                console.log(response.data);
            });
        }

        // Weight parameter
        if (this.state.inputParameter==='Kilogram' && this.state.outputParameter==='Gram'){
            axios.get(`https://localhost:44303/api/Weight/api/Converted_KilogramToGram?KG_value=${this.state.num}`)
            .then(response => {
                this.setState({outputValue:response.data})
                console.log(response.data);
            });
        }
        if (this.state.inputParameter==='Gram' && this.state.outputParameter==='Kilogram'){
            axios.get(`https://localhost:44303/api/Weight/api/Converted_GramToKilogram?G_value=${this.state.num}`)
            .then(response => {
                this.setState({outputValue:response.data})
                console.log(response.data);
            });
        }      
       
    }    

    render() {        
        return (
            <>
                <div id='Main-div'>
                    <div className='container'>
                        <div className='l-w-t-select-div'>
                            <h1>Welcome To QuantityMeasurement UI </h1>
                            <select className='main-select' onChange={this.MainOnChange}>
                                <option value='Length'>Length</option>
                                <option value='Weight'>Weight</option>
                                <option value='Temperature'>Temperature</option>
                            </select>
                        </div>
                        <div className='i-o-box'>
                            <div className='input-div'>
                                <input type='text' placeholder='text' onChange={this.inputText} value={this.state.num}></input>
                                <select className='i-o-select'  onChange={this.inputOnChange}>
                                    <option value='Inch'>Inch</option>
                                    <option value='Feet'>Feet</option>
                                    <option value='Yard'>Yard</option>
                                    <option value='Kilogram'>Kilogram</option>
                                    <option value='Gram'>Gram</option>
                                    <option value='Celsius'>Celsius</option>
                                    <option value='Fahrenheith'>Fahrenheith</option>
                                </select>
                            </div>
                            <div className='equal-sign-div'>
                                <h1>=</h1>
                            </div>
                            <div className='output-div'>
                                <input type='text' value={this.state.outputValue }></input>
                                <select className='i-o-select'  onChange={this.outputOnChange}>
                                    <option value='Inch'>Inch</option>
                                    <option value='Feet'>Feet</option>
                                    <option value='Yard'>Yard</option>
                                    <option value='Kilogram'>Kilogram</option>
                                    <option value='Gram'>Gram</option>
                                    <option value='Celsius'>Celsius</option>
                                    <option value='Fahrenheith'>Fahrenheith</option>
                                </select>
                            </div>
                        </div>
                        <div>
                            <button type='submit' value='Submit' onClick={this.onClick}>Submit</button>
                        </div>
                    </div>
                </div>
            </>
        )
    }

}
export default Home

