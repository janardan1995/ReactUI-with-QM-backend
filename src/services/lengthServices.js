import axios from 'axios';

export async function FeetToYard(data){
    const response=await  axios.get(`https://localhost:44303/api/Length/api/Converted_FeetToYard?F_Value=${data}`)
    return response;
}

export async function YardToFeet(data){
    const response=await  axios.get(`https://localhost:5001/api/Length/api/Converted_YardToFeet?Y_Value=${data}`)
    return response;
} 

export async function YardToInches(data){
    const response=await  axios.get(`https://localhost:5001/api/Length/api/Converted_YardToInches?Y_Value=${data}`)
    return response;
}

export async function InchesToYard(data){
    const response=await axios.get(`https://localhost:5001/api/Length/api/Converted_InchesToYard?I_Value=${data}`)
} 

export async function FeetToInches(data){
    const response=await axios.get(`https://localhost:5001/api/Length/api/Converted_FeetToInches?F_Value=${data}`)
    return response;
}

export async function InchesToFeet(data){
    const response=await axios.get(`https://localhost:5001/api/Length/api/Converted_InchesToFeet?I_Value=${data}`)
    return response;
} 