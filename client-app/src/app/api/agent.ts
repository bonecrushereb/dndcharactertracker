import axios, { AxiosResponse } from "axios";
import { Character } from "../models/character";

const sleep = (delay: number) => {
    return new Promise((resolve) => {
        setTimeout(resolve, delay);
    })
}

axios.defaults.baseURL = 'http://localhost:5000/api';

axios.interceptors.response.use(async response => {
    try {
        sleep(1000);
        return response;
    } catch (error) {
        console.log(error);
        return await Promise.reject(error);
    }
})

const responseBody = <T> (response: AxiosResponse<T>) => response.data;

const requests = {
    get: <T> (url: string) => axios.get<T>(url).then(responseBody),
    post: <T> (url: string, body: {}) => axios.post<T>(url, body).then(responseBody),
    put: <T> (url: string, body: {}) => axios.put<T>(url, body).then(responseBody),
    delete: <T> (url: string) => axios.delete<T>(url).then(responseBody)
}

const Characters = {
    list: () => requests.get<Character[]>('/character'),
    details: (id: string) => requests.get<Character>(`/character/${id}`),
    create: (character: Character) => requests.post<void>('/character', character),
    update: (character: Character) => requests.put<void>(`/character/${character.id}`, character),
    delete: (id: string) => requests.delete<void>(`/character/${id}`)
}

const agent = {
    Characters
}

export default agent;