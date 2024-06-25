import axios from "axios";

export const GetAllBible = () => {
    return axios.get(`https://localhost:7225/api/V/AllBible`)
}

export const GetFindWord = (name) => {
    return axios.get(`https://localhost:7225/api/V/findWord/${name}`)
}

export const GetCountWord = (name) => {
    return axios.get(`https://localhost:7225/api/V/countWord/${name}`)
}

export const GetName = (name) => {
    return axios.get(`https://localhost:7225/api/V/name/${name}`)
}