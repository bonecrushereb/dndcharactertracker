import api from "../utils/api";
import {
    GET_CHARACTERS,
    GET_CHARACTER,
    CHARACTER_ERROR,
    CREATE_CHARACTER
} from './types';


//get characters
export const getCharacters = () => async(dispatch) => {
    try {
        const res = await api.get('/api/character');
        
        dispatch({
            type: GET_CHARACTERS,
            payload: res.data
        })
    } catch (err) {
        dispatch({
            type: CHARACTER_ERROR,
            payload: { msg: err.response.statusText, status: err.response.status }
        });
    }
}

//get single character
export const getCharacter = id => async (dispatch) => {
    try {
       const res = await api.get(`/api/character/${id}`);
       dispatch({
        type: GET_CHARACTER,
        payload: res.data
       });
    } catch (err) {
        dispatch({
            type: CHARACTER_ERROR,
            payload: { msg: err.response.statusText, status: err.response.status }
        });
    }
}

//Create Character
export const createCharacter = (formData, navigate) => async dispatch => {
    try {
        const res = await api.post('/api/character', formData);
        dispatch({
            type: GET_CHARACTER,
            payload: res.data
        })
    } catch (err) {
        const errors = err.response.data.errors;
        if (errors) console.log(errors);
        dispatch({
            type: CHARACTER_ERROR,
            payload: { msg: err.response.statusText, status: err.response.status }
        })
    }
}