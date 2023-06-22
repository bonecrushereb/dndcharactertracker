import {
    GET_CHARACTERS,
    GET_CHARACTER,
    CHARACTER_ERROR,
    UPDATE_CHARACTER,
    CREATE_CHARACTER
} from '../actions/types';

const initialState = {
    character: [],
    characters: [],
    error: {}
}

function characterReducer(state = initialState, action) {
    const { type, payload } = action;

    switch (type) {
        case GET_CHARACTERS:
            return {
                ...state,
                characters: payload
            };
            case GET_CHARACTER:
                return {
                    ...state,
                    character: payload,
                };
        case CHARACTER_ERROR:
            return {
                ...state,
                error: payload
            };
        case CREATE_CHARACTER:
            return {
                ...state,
                character: [payload, ...state.characters]
            };
        default:
            return state;
    }
}

export default characterReducer;