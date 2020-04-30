import axios from 'axios';



export async function celsiusToFahrenheith(data){
    const response=await axios.get(`https://localhost:5001/api/Temperature/api/Converted_CelsiusToFahrenheith?C_value=${data}`);
    return response;
}

export async function fahrenheithToCelsius(data){
    const response=await axios.get(`https://localhost:5001/api/Temperature/api/Converted_FarhenheithToCelsius?F_value=${data}`)
    return response;
} 
