import axios from 'axios';



export async function kilogramToGram(data){
    const response=await axios.get(`https://localhost:5001/api/Weight/api/Converted_KilogramToGram?KG_value=${data}`);
    return response;
}

export async function gramToKilogram(data){
    const response=await axios.get(`https://localhost:5001/api/Weight/api/Converted_GramToKilogram?G_value=${data}`);
    return response;
} 