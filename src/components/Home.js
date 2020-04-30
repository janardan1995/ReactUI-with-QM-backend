import React, { Component } from 'react'
import axios from 'axios'
import { gramToKilogram, kilogramToGram } from '../services/weightServices'
import { celsiusToFahrenheith, fahrenheithToCelsius } from '../services/temperatureServices'
import { InchesToFeet, FeetToInches, InchesToYard, YardToInches, YardToFeet, FeetToYard } from '../services/lengthServices'
//import {gramToKilogram} from '.\services\weightServices'
//import {kilogramToGram} from '.\services\weightServices'

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
            let data=this.state.num;
            FeetToYard(data)
             .then(response => {
                this.setState({outputValue:response.data})
                console.log(response.data);
            })
             .catch(error => { console.log(error) })
        }
        if(this.state.inputParameter==='Yard' && this.state.outputParameter==='Feet'){           
            let data=this.state.num;
            YardToFeet(data)
            .then(response => {
                this.setState({outputValue:response.data})
                console.log(response.data);
            })
        }
        if(this.state.inputParameter==='Yard' && this.state.outputParameter==='Inch'){
           
            let data=this.state.num;
            YardToInches(data)
            .then(response => {
                this.setState({outputValue:response.data})
                console.log(response.data);
            })
        }
        if(this.state.inputParameter==='Inch' && this.state.outputParameter==='Yard'){
            
            let data=this.state.num;
            InchesToYard(data)
            .then(response => {
                this.setState({outputValue:response.data})
                console.log(response.data);
            });
        }
        if(this.state.inputParameter==='Feet' && this.state.outputParameter==='Inch'){
            
            let data=this.state.num;
            FeetToInches(data)
             .then(response => {
                this.setState({outputValue:response.data})
                console.log(response.data);
            });
        }
        if (this.state.inputParameter==='Inch' && this.state.outputParameter==='Feet'){
            
            let data=this.state.num;
            InchesToFeet(data)
            .then(response => {
                this.setState({outputValue:response.data})
                console.log(response.data);
            });
        }

        // Temperature parameter..........................>

        if (this.state.inputParameter==='Fahrenheith' && this.state.outputParameter==='Celsius'){            
            let data=this.state.num;
            fahrenheithToCelsius(data)
            .then(response => {
                this.setState({outputValue:response.data})
                console.log(response.data);
            });
        }

        if (this.state.inputParameter==='Celsius' && this.state.outputParameter==='Fahrenheith'){
            
            let data=this.state.num;
            celsiusToFahrenheith(data)
            .then(response => {
                this.setState({outputValue:response.data})
                console.log(response.data);
            });
        }

        // Weight parameter
        if (this.state.inputParameter==='Kilogram' && this.state.outputParameter==='Gram'){           
           let data=this.state.num;
            kilogramToGram(data)
            .then(response => {
                this.setState({outputValue:response.data})
                console.log(response.data);
            });
        }

        if (this.state.inputParameter==='Gram' && this.state.outputParameter==='Kilogram'){           
            let data=this.state.num;
             gramToKilogram(data)
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
                            <option value='none'>Select</option>
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

